using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;

//clientBindingSource.PositionChanged += new EventHandler(Bouger_Client); Exemple de création d'un event

namespace Colin_Justine_Valet_Noir
{
    public partial class Ecran_Jeu : Form
    {
        #region Déclarations
        private int i = 0;
        private Carte[] Liste_Complete = new Carte[51];
        private List<Carte> Main_J1 = new List<Carte>();
        private List<Carte> Main_J2 = new List<Carte>();
        private List<Carte> Pioche = new List<Carte>();
        private List<PictureBox> Images_Main = new List<PictureBox>();
        private List<PictureBox> Images_Adverse = new List<PictureBox>();
        private bool j1 = true; //Permet de déterminer le tour
        #endregion

        public Ecran_Jeu()//Nouvelle partie
        {
            InitializeComponent();
            Setup_Carte();
            Setup();
        }

        public Ecran_Jeu(List<Carte> Main_1, List<Carte> Main_2, List<Carte> PiocheA, string Texte, bool a)//Partie chargée
        {
            InitializeComponent();
            Main_J1 = Main_1;
            Main_J2 = Main_2;
            Pioche = PiocheA;
            RTB_Defausse.Text = Texte;
            j1 = a;

            if (j1)
                Lbl_Tour.Text = "Tour du joueur 1";
            else
                Lbl_Tour.Text = "Tour du joueur 2";
            AffichageMain();
        }

        #region Fonction "automatique"
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Sauver();
        }
        
        private void Ecran_Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Enregistrer avant de quitter ?", "Enregistrer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Pop up avec boutons oui/non
                Sauver();
            e.Cancel = false;
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            New_Game();
        }

        private void Btn_Paires_Click(object sender, EventArgs e)
        {
            Paires_Auto();
        }
        #endregion

        #region Fonctions perso
        private void Fct_Tour(List<Carte> Liste)
        {
            if (Main_J1.Count == 0)
            {
                string Gagnant;
                if (j1)
                {
                    Gagnant = "Le joueur 2";
                }
                else
                {
                    Gagnant = "Le joueur 1";
                }

                if (MessageBox.Show(Gagnant + " a gagné !\nVoulez-vous lancer une autre partie ?", "Fin de partie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    New_Game();
                else
                    Close();
            }

            if (Main_J2.Count == 0)
            {
                string Gagnant;
                if (j1)
                {
                    Gagnant = "Le joueur 2";
                }
                else
                {
                    Gagnant = "Le joueur 1";
                }

                if (MessageBox.Show(Gagnant + " a gagné !\nVoulez-vous lancer une autre partie ?", "Fin de partie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    New_Game();
                else
                    Close();
            }

            j1 = !j1;
            if (j1)
                Lbl_Tour.Text = "Tour du joueur 1";
            else
                Lbl_Tour.Text = "Tour du joueur 2";
            this.Panel_Jeu.Controls.Clear();
            AffichageMain();
        }

        private void Sauver()
        {
             if (Dlg_Enregistrer.ShowDialog() == DialogResult.OK)
             {
                StreamWriter sw = new StreamWriter(Dlg_Enregistrer.FileName);
                sw.WriteLine(j1);
                sw.WriteLine("");
                foreach (Carte Card in Main_J1)
                {
                    sw.WriteLine(Card.Num_Carte + ";" + Card.Valeur + ";" + Card.Couleur + ";" + Card.Symbole + ";" + Card.Valet);
                }
                sw.WriteLine("");
                foreach (Carte Card in Main_J2)
                {
                    sw.WriteLine(Card.Num_Carte + ";" + Card.Valeur + ";" + Card.Couleur + ";" + Card.Symbole + ";" + Card.Valet);
                }
                sw.WriteLine("");
                sw.WriteLine(RTB_Defausse.Text);
                sw.WriteLine("");
                foreach (Carte Card in Pioche)
                {
                    sw.WriteLine(Card.Num_Carte + ";" + Card.Valeur + ";" + Card.Couleur + ";" + Card.Symbole + ";" + Card.Valet);
                }
                sw.Close();
             }
        }

        private void New_Game()
        {
            Lbl_Tour.Text = "Tour du joueur 1";
            Main_J1.Clear();
            Main_J2.Clear();
            Images_Main.Clear();
            Setup();
        }

        private void Setup()
        {
            Lbl_Tour.Text = "Tour du joueur 1";
            this.Panel_Jeu.Controls.Clear();
            Distribution_Exam();
            AffichageMain();
            Console.WriteLine(Pioche.Count);
        }

        private void Setup_Carte()
        {
            for (int i = 0; i < 51; i++)
            {
                Carte Carte_Now = new Carte(i);
                
                if (Carte_Now.Num_Carte == 48)
                {
                    Carte_Now.Valet = true;
                }

                if (Carte_Now.Num_Carte <= 11)
                {
                    Carte_Now.Couleur = "Noir";
                    Carte_Now.Symbole = "Trèfle";
                }

                else
                {
                    if (Carte_Now.Num_Carte <= 24)
                    {
                        Carte_Now.Couleur = "Rouge";
                        Carte_Now.Symbole = "Coeur";
                    }

                    else
                    {
                        if (Carte_Now.Num_Carte <= 37)
                        {
                            Carte_Now.Couleur = "Rouge";
                            Carte_Now.Symbole = "Carreau";
                        }

                        else
                        {
                            Carte_Now.Couleur = "Noir";
                            Carte_Now.Symbole = "Pique";
                        }
                    }
                }
                Liste_Complete[i] = Carte_Now;
            }
        }

        private void Distribution()
        {
            int Nb = 0;
            Random Rnd = new Random();
            bool Joueur1 = true, Verif = false;
            List<int> Deja_Tire = new List<int>();

            for (int i = 0; i < 51; i++)
            {
                //Vérifie si la carte à déjà été distribuée
                do
                {
                    Nb = Rnd.Next(0, 51); //Génère aléatoire [0;51[
                    foreach (var el in Deja_Tire)
                    {
                        if (Nb == el)
                        {
                            Verif = true;
                            break;
                            /*Sortie du foreach car carte déjà distribuée => On doit reprendre un nombre.
                            Si on ne sort pas, on passe dans les autres éléments de la liste => Verif redevient faux
                            */
            }
            else
                            Verif = false;
                    }
                } while (Verif == true);
                Deja_Tire.Add(Nb);

                //Alterne entre les 2 joueurs
                if (Joueur1)
                    Main_J1.Add(Liste_Complete[Nb]);
                else
                    Main_J2.Add(Liste_Complete[Nb]);
                Joueur1 = !Joueur1;
            }
        }

        private void Distribution_Exam()
        {
            int Nb = 0;
            Random Rnd = new Random();
            bool Joueur1 = true, Verif = false;
            List<int> Deja_Tire = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                //Vérifie si la carte à déjà été distribuée
                do
                {
                    Nb = Rnd.Next(0, 51); //Génère aléatoire [0;51[
                    foreach (var el in Deja_Tire)
                    {
                        if (Nb == el)
                        {
                            Verif = true;
                            break;
                            /*Sortie du foreach car carte déjà distribuée => On doit reprendre un nombre.
                            Si on ne sort pas, on passe dans les autres éléments de la liste => Verif redevient faux
                            */
                        }
                        else
                            Verif = false;
                    }
                } while (Verif == true);
                Deja_Tire.Add(Nb);

                //Alterne entre les 2 joueurs
                if (Joueur1)
                    Main_J1.Add(Liste_Complete[Nb]);
                else
                    Main_J2.Add(Liste_Complete[Nb]);
                Joueur1 = !Joueur1;
            }

            //Ajoute les cartes restantes dans la pioche
            for (int i = 0; i < 31; i++)
            {
                //Vérifie si la carte à déjà été distribuée
                do
                {
                    Nb = Rnd.Next(0, 51); //Génère aléatoire [0;51[
                    foreach (var el in Deja_Tire)
                    {
                        if (Nb == el)
                        {
                            Verif = true;
                            break;
                            /*Sortie du foreach car carte déjà distribuée => On doit reprendre un nombre.
                            Si on ne sort pas, on passe dans les autres éléments de la liste => Verif redevient faux
                            */
                        }
                        else
                            Verif = false;
                    }
                } while (Verif == true);
                Deja_Tire.Add(Nb);

                Pioche.Add(Liste_Complete[Nb]);
            }
        }

        private void AffichageMain()//Affichage des cartes du joueur
        {
            List<Carte> Liste = new List<Carte>();
            List<Carte> Liste2 = new List<Carte>();
            
            if (j1 == true)
            {
                Liste = Main_J1;
                Liste2 = Main_J2;
            }
            else
            {
                Liste = Main_J2;
                Liste2 = Main_J1;
            }

            Images_Main.Clear();
            i = 0;
            foreach (var el in Liste)
            {
                PictureBox PB = new PictureBox
                {
                    Name = "PB_" + i,
                    Location = new Point(28 + (20 * i), 215),
                    Image = IL_Carte.Images[el.Num_Carte],
                    Width = PB_Defausse.Width,
                    Height = PB_Defausse.Height,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Visible = true
                };
                Images_Main.Add(PB);
                this.Panel_Jeu.Controls.Add(Images_Main[i]);
                i++;
            }
            
            for (i = 0; i < Liste2.Count; i++)
            {
                PictureBox PB = new PictureBox
                {
                    Name = "PB2_" + i,
                    Location = new Point(28 + (20 * i), 10),
                    Image = Colin_Justine_Valet_Noir.Properties.Resources.Dos_Carte,
                    Width = PB_Defausse.Width,
                    Height = PB_Defausse.Height,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Visible = true
                };
                PB.MouseClick += new MouseEventHandler(Carte_Click);
                Images_Adverse.Add(PB);
                this.Panel_Jeu.Controls.Add(Images_Adverse[i]);                
            }

            //Pioche
            if (Pioche.Count > 0)
            {
                PictureBox PB = new PictureBox
                {
                    Name = "PB_Pioche",
                    Location = PB_PiocheA.Location,
                    Image = Colin_Justine_Valet_Noir.Properties.Resources.Dos_Carte,
                    Width = PB_PiocheA.Width,
                    Height = PB_PiocheA.Height,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Visible = true
                };
                PB.MouseClick += new MouseEventHandler(Carte_Click);
                this.Panel_Jeu.Controls.Add(PB);
            }

        }

        private bool M_Paire(Carte Carte1, Carte Carte2)
        {
            if (Carte1.Valet == true || Carte2.Valet == true)
                return false;
            else
            {
                if (Carte1.Couleur == Carte2.Couleur && Carte1.Valeur == Carte2.Valeur)
                {
                    RTB_Defausse.AppendText("\r\n" + Carte1.Valeur + " " + Carte1.Couleur);
                    return true;
                }                    
                else
                    return false;
            }            
        }

        private void Paire_Auto(Carte Card)//Si une carte ajoutée à la main
        {
            bool Ok = false;
            List<Carte> Liste = new List<Carte>();
            if (j1 == true)
                Liste = Main_J1;
            else
                Liste = Main_J2;
            if (Card.Valet)
            {
                if(MessageBox.Show("Vous avez pioché le valet.\nSouhaitez-vous mélanger ?", "Valet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Nb = 0;
                    Random Rnd = new Random();
                    Nb = Rnd.Next(0, Liste.Count);
                    Liste.Insert(Nb, Card);
                    Liste.RemoveAt(Liste.Count-1);
                    if (j1 == true)
                        Main_J1 = Liste;
                    else
                        Main_J2 = Liste;
                    AffichageMain();
                }
            }
            else
            {
                for (int j = 1; j < Liste.Count; j++)
                {
                    if (Card != Liste[j])
                        Ok = M_Paire(Card, Liste[j]);
                    if (Ok == true)
                    {
                        Carte Cd2 = Liste[j];
                        Liste.Remove(Card);
                        Liste.Remove(Cd2);
                        Ok = false;
                        MessageBox.Show("La paire a été défaussée");
                    }
                }
                //foreach (var El in Liste)
                //{ }   Impossible à cause de la suppression

                if (j1)
                    Main_J1 = Liste;
                else
                    Main_J2 = Liste;

                this.Panel_Jeu.Controls.Clear();
                AffichageMain();
                
            }
           
        }

        private void Paires_Auto()//Début de partie
        {
            bool Ok = false;
            i = 0;
            List<Carte> Liste = new List<Carte>();
            List<Carte> Liste2 = new List<Carte>();
            if (j1 == true)
                Liste = Main_J1;
            else
                Liste = Main_J2;
            
            for (int i = 0; i < (Liste.Count - 1); i++)
            {
                for (int j = 1; j < Liste.Count; j++)
                {
                    if (Liste[i] != Liste[j])
                        Ok = M_Paire(Liste[i], Liste[j]);
                    if (Ok == true)
                    {
                        Carte Cd1 = Liste[i];
                        Carte Cd2 = Liste[j];
                        Liste.Remove(Cd1);
                        Liste.Remove(Cd2);
                        if(i > 0)
                        {
                            j = i;
                            i--;
                        }                        
                        Ok = false;
                    }
                }
            }

            //foreach (var El in Liste)
            //{...} Impossible car modification de la liste

            if (j1)
                Main_J1 = Liste;
            else
                Main_J2 = Liste;

            this.Panel_Jeu.Controls.Clear();
            AffichageMain();
            MessageBox.Show("Toutes les paires ont été défaussées");
            j1 = !j1;
            Thread.Sleep(1000);
            AffichageMain();
        }

        private void Carte_Click(object sender, EventArgs e)//Permet de piocher une carte dans la main adverse
        {
            List<Carte> Liste = new List<Carte>();
            List<Carte> Liste2 = new List<Carte>();
            Carte Carte_Now = new Carte();
            var PB = (PictureBox)sender;
            if (PB.Name == "PB_Pioche") //Carte dans pioche
            {
                Random Rnd = new Random();
                int Nb = Rnd.Next(0, Pioche.Count);

                Console.WriteLine(Nb);


                if (!j1)
                {
                    Liste = Pioche;
                    Liste2 = Main_J2;
                }
                else
                {
                    Liste2 = Main_J1;
                    Liste = Pioche;
                }

                Carte_Now = Liste[Nb];

                Liste2.Add(Carte_Now);
                Liste.Remove(Carte_Now);
            }
            else //Carte dans main joueur
            {
                if (!j1)
                {
                    Liste = Main_J1;
                    Liste2 = Main_J2;
                }
                else
                {
                    Liste2 = Main_J1;
                    Liste = Main_J2;
                }
                string[] tab = PB.Name.Split('_'); //On récupère le numéro de la PB
                Carte_Now = Liste[int.Parse(tab[1])]; //On va rechercher la carte dans la liste
                                                      //On change la carte de liste
                Liste2.Add(Carte_Now);
                Liste.Remove(Carte_Now);
            }
            
            MessageBox.Show("Vous avez pioché le " + Carte_Now.Valeur.ToString() + " de " + Carte_Now.Symbole);
            Paire_Auto(Carte_Now); //On vérifie si la carte est le valet noir ou si c'est une paire
            AffichageMain();
            Fct_Tour(Liste);
        }
        #endregion

        private void Btn_Triche_Click(object sender, EventArgs e)
        {
            List<Carte> Liste = new List<Carte>();
            List<Carte> Liste2 = new List<Carte>();

            if (j1)
            {
                Liste = Main_J1;
                Liste2 = Main_J2;
            }
            else
            {
                Liste = Main_J2;
                Liste2 = Main_J1;
            }

            foreach (var el in Liste)
            {
                foreach (var el2 in Liste2)
                {
                    if (M_Paire(el, el2))
                    {
                        Liste.Remove(el);
                        Liste2.Remove(el2);
                        MessageBox.Show("Vous avez pioché le " + el2.Valeur.ToString() + " de " + el2.Symbole);
                        MessageBox.Show("La paire a été défaussée");
                        AffichageMain();
                        Fct_Tour(Liste);
                        return;
                    }
                }
            }
            MessageBox.Show("Impossible de tricher, votre adversaire n'as pas les bonnes cartes.");
            return;
        }
    }
}