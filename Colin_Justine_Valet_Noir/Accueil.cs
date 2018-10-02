using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Colin_Justine_Valet_Noir
{
    public partial class Accueil : Form
    {

        public Accueil()
        {
            InitializeComponent();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            List<Carte> Main_J1 = new List<Carte>();
            List<Carte> Main_J2 = new List<Carte>();
            List<Carte> Pioche = new List<Carte>();
            string Texte = "Paires défaussées :";
            bool Tour = false;

            if (Dlg_Load.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(Dlg_Load.FileName);
                string lecture;
                while ((lecture = sr.ReadLine()) != "")
                {
                    string[] tab = lecture.Split(';');
                    if (tab[0] == "true")
                        Tour = true;
                    else
                        Tour = false;
                }
                while((lecture = sr.ReadLine()) != "")//Récupération de Main_J1
                {
                    Carte Card = new Carte();
                    string[] tab = lecture.Split(';');
                    Card.Num_Carte = int.Parse(tab[0]);
                    Card.Valeur = int.Parse(tab[1]);
                    Card.Couleur = tab[2];
                    Card.Symbole = tab[3];
                    if (tab[4] == "true")
                        Card.Valet = true;
                    else
                        Card.Valet = false;
                    Main_J1.Add(Card);
                }                
                while ((lecture = sr.ReadLine()) != "")//Récupération de Main_J2
                {
                    Carte Card = new Carte();
                    string[] tab = lecture.Split(';');
                    Card.Num_Carte = int.Parse(tab[0]);
                    Card.Valeur = int.Parse(tab[1]);
                    Card.Couleur = tab[2];
                    Card.Symbole = tab[3];
                    if (tab[4] == "true")
                        Card.Valet = true;
                    else
                        Card.Valet = false;
                    Main_J2.Add(Card);
                }
                while ((lecture = sr.ReadLine()) != "")
                {
                    Texte = sr.ReadLine();
                }
                while ((lecture = sr.ReadLine()) != null)//Récupération de la pioche
                {
                    Carte Card = new Carte();
                    string[] tab = lecture.Split(';');
                    Card.Num_Carte = int.Parse(tab[0]);
                    Card.Valeur = int.Parse(tab[1]);
                    Card.Couleur = tab[2];
                    Card.Symbole = tab[3];
                    if (tab[4] == "true")
                        Card.Valet = true;
                    else
                        Card.Valet = false;
                    Pioche.Add(Card);
                }
                sr.Close();               
            }
            Ecran_Jeu j = new Ecran_Jeu(Main_J1, Main_J2, Pioche, Texte, Tour);
            j.Show();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Ecran_Jeu j = new Ecran_Jeu();
            j.Show();
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Aide_Click(object sender, EventArgs e)
        {
            Aide j = new Aide();
            j.Show();
        }
    }
}
