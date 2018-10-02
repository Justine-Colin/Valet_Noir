namespace Colin_Justine_Valet_Noir
{
    partial class Ecran_Jeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ecran_Jeu));
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Dlg_Enregistrer = new System.Windows.Forms.SaveFileDialog();
            this.Panel_Jeu = new System.Windows.Forms.Panel();
            this.PB_PiocheA = new System.Windows.Forms.PictureBox();
            this.PB_Defausse = new System.Windows.Forms.PictureBox();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IL_Carte = new System.Windows.Forms.ImageList(this.components);
            this.PB_Copyright = new System.Windows.Forms.PictureBox();
            this.Btn_Paires = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Tour = new System.Windows.Forms.Label();
            this.RTB_Defausse = new System.Windows.Forms.RichTextBox();
            this.Btn_Triche = new System.Windows.Forms.Button();
            this.Panel_Jeu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PiocheA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Defausse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Copyright)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.Linen;
            this.Btn_Save.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(1081, 57);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(146, 40);
            this.Btn_Save.TabIndex = 0;
            this.Btn_Save.Text = "Sauvegarder";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Panel_Jeu
            // 
            this.Panel_Jeu.BackColor = System.Drawing.Color.Linen;
            this.Panel_Jeu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Jeu.Controls.Add(this.PB_PiocheA);
            this.Panel_Jeu.Controls.Add(this.PB_Defausse);
            this.Panel_Jeu.Location = new System.Drawing.Point(12, 11);
            this.Panel_Jeu.Name = "Panel_Jeu";
            this.Panel_Jeu.Size = new System.Drawing.Size(1063, 500);
            this.Panel_Jeu.TabIndex = 1;
            // 
            // PB_PiocheA
            // 
            this.PB_PiocheA.Image = global::Colin_Justine_Valet_Noir.Properties.Resources.Dos_Carte;
            this.PB_PiocheA.Location = new System.Drawing.Point(890, 154);
            this.PB_PiocheA.Name = "PB_PiocheA";
            this.PB_PiocheA.Size = new System.Drawing.Size(150, 200);
            this.PB_PiocheA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_PiocheA.TabIndex = 54;
            this.PB_PiocheA.TabStop = false;
            this.PB_PiocheA.Click += new System.EventHandler(this.Carte_Click);
            // 
            // PB_Defausse
            // 
            this.PB_Defausse.Image = global::Colin_Justine_Valet_Noir.Properties.Resources.Dos_Carte;
            this.PB_Defausse.Location = new System.Drawing.Point(890, 155);
            this.PB_Defausse.Name = "PB_Defausse";
            this.PB_Defausse.Size = new System.Drawing.Size(150, 200);
            this.PB_Defausse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Defausse.TabIndex = 53;
            this.PB_Defausse.TabStop = false;
            // 
            // Btn_New
            // 
            this.Btn_New.BackColor = System.Drawing.Color.Linen;
            this.Btn_New.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_New.Location = new System.Drawing.Point(1081, 11);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(146, 40);
            this.Btn_New.TabIndex = 2;
            this.Btn_New.Text = "Nouvelle partie";
            this.Btn_New.UseVisualStyleBackColor = false;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.BackColor = System.Drawing.Color.Linen;
            this.Btn_Quit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quit.Location = new System.Drawing.Point(1081, 103);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(146, 40);
            this.Btn_Quit.TabIndex = 6;
            this.Btn_Quit.Text = "Quitter";
            this.Btn_Quit.UseVisualStyleBackColor = false;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1027, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Haute Ecole de la Ville de Liège";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(930, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "COLIN Justine";
            // 
            // IL_Carte
            // 
            this.IL_Carte.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL_Carte.ImageStream")));
            this.IL_Carte.TransparentColor = System.Drawing.Color.Transparent;
            this.IL_Carte.Images.SetKeyName(0, "Trefle1.jpg");
            this.IL_Carte.Images.SetKeyName(1, "Trefle2.jpg");
            this.IL_Carte.Images.SetKeyName(2, "Trefle3.jpg");
            this.IL_Carte.Images.SetKeyName(3, "Trefle4.jpg");
            this.IL_Carte.Images.SetKeyName(4, "Trefle5.jpg");
            this.IL_Carte.Images.SetKeyName(5, "Trefle6.jpg");
            this.IL_Carte.Images.SetKeyName(6, "Trefle7.jpg");
            this.IL_Carte.Images.SetKeyName(7, "Trefle8.jpg");
            this.IL_Carte.Images.SetKeyName(8, "Trefle9.jpg");
            this.IL_Carte.Images.SetKeyName(9, "Trefle10.jpg");
            this.IL_Carte.Images.SetKeyName(10, "Trefle12.jpg");
            this.IL_Carte.Images.SetKeyName(11, "Trefle13.jpg");
            this.IL_Carte.Images.SetKeyName(12, "Coeur1.jpg");
            this.IL_Carte.Images.SetKeyName(13, "Coeur2.jpg");
            this.IL_Carte.Images.SetKeyName(14, "Coeur3.jpg");
            this.IL_Carte.Images.SetKeyName(15, "Coeur4.jpg");
            this.IL_Carte.Images.SetKeyName(16, "Coeur5.jpg");
            this.IL_Carte.Images.SetKeyName(17, "Coeur6.jpg");
            this.IL_Carte.Images.SetKeyName(18, "Coeur7.jpg");
            this.IL_Carte.Images.SetKeyName(19, "Coeur8.jpg");
            this.IL_Carte.Images.SetKeyName(20, "Coeur9.jpg");
            this.IL_Carte.Images.SetKeyName(21, "Coeur10.jpg");
            this.IL_Carte.Images.SetKeyName(22, "Coeur11.jpg");
            this.IL_Carte.Images.SetKeyName(23, "Coeur12.jpg");
            this.IL_Carte.Images.SetKeyName(24, "Coeur13.jpg");
            this.IL_Carte.Images.SetKeyName(25, "Carreau1.jpg");
            this.IL_Carte.Images.SetKeyName(26, "Carreau2.jpg");
            this.IL_Carte.Images.SetKeyName(27, "Carreau3.jpg");
            this.IL_Carte.Images.SetKeyName(28, "Carreau4.jpg");
            this.IL_Carte.Images.SetKeyName(29, "Carreau5.jpg");
            this.IL_Carte.Images.SetKeyName(30, "Carreau6.jpg");
            this.IL_Carte.Images.SetKeyName(31, "Carreau7.jpg");
            this.IL_Carte.Images.SetKeyName(32, "Carreau8.jpg");
            this.IL_Carte.Images.SetKeyName(33, "Carreau9.jpg");
            this.IL_Carte.Images.SetKeyName(34, "Carreau10.jpg");
            this.IL_Carte.Images.SetKeyName(35, "Carreau11.jpg");
            this.IL_Carte.Images.SetKeyName(36, "Carreau12.jpg");
            this.IL_Carte.Images.SetKeyName(37, "Carreau13.jpg");
            this.IL_Carte.Images.SetKeyName(38, "Pique1.jpg");
            this.IL_Carte.Images.SetKeyName(39, "Pique2.jpg");
            this.IL_Carte.Images.SetKeyName(40, "Pique3.jpg");
            this.IL_Carte.Images.SetKeyName(41, "Pique4.jpg");
            this.IL_Carte.Images.SetKeyName(42, "Pique5.jpg");
            this.IL_Carte.Images.SetKeyName(43, "Pique6.jpg");
            this.IL_Carte.Images.SetKeyName(44, "Pique7.jpg");
            this.IL_Carte.Images.SetKeyName(45, "Pique8.jpg");
            this.IL_Carte.Images.SetKeyName(46, "Pique9.jpg");
            this.IL_Carte.Images.SetKeyName(47, "Pique10.jpg");
            this.IL_Carte.Images.SetKeyName(48, "Pique11.jpg");
            this.IL_Carte.Images.SetKeyName(49, "Pique12.jpg");
            this.IL_Carte.Images.SetKeyName(50, "Pique13.jpg");
            // 
            // PB_Copyright
            // 
            this.PB_Copyright.BackgroundImage = global::Colin_Justine_Valet_Noir.Properties.Resources.Copyright1;
            this.PB_Copyright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Copyright.Location = new System.Drawing.Point(916, 515);
            this.PB_Copyright.Name = "PB_Copyright";
            this.PB_Copyright.Size = new System.Drawing.Size(12, 15);
            this.PB_Copyright.TabIndex = 10;
            this.PB_Copyright.TabStop = false;
            // 
            // Btn_Paires
            // 
            this.Btn_Paires.BackColor = System.Drawing.Color.Linen;
            this.Btn_Paires.Location = new System.Drawing.Point(1081, 378);
            this.Btn_Paires.Name = "Btn_Paires";
            this.Btn_Paires.Size = new System.Drawing.Size(146, 40);
            this.Btn_Paires.TabIndex = 56;
            this.Btn_Paires.Text = "Tri";
            this.Btn_Paires.UseVisualStyleBackColor = false;
            this.Btn_Paires.Click += new System.EventHandler(this.Btn_Paires_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Lbl_Tour);
            this.panel1.Location = new System.Drawing.Point(1084, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 41);
            this.panel1.TabIndex = 58;
            // 
            // Lbl_Tour
            // 
            this.Lbl_Tour.AutoSize = true;
            this.Lbl_Tour.Location = new System.Drawing.Point(3, 10);
            this.Lbl_Tour.Name = "Lbl_Tour";
            this.Lbl_Tour.Size = new System.Drawing.Size(38, 17);
            this.Lbl_Tour.TabIndex = 6;
            this.Lbl_Tour.Text = "Tour";
            // 
            // RTB_Defausse
            // 
            this.RTB_Defausse.BackColor = System.Drawing.Color.Linen;
            this.RTB_Defausse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_Defausse.Location = new System.Drawing.Point(1087, 150);
            this.RTB_Defausse.Name = "RTB_Defausse";
            this.RTB_Defausse.ReadOnly = true;
            this.RTB_Defausse.Size = new System.Drawing.Size(139, 217);
            this.RTB_Defausse.TabIndex = 59;
            this.RTB_Defausse.Text = "Paires défaussées :";
            // 
            // Btn_Triche
            // 
            this.Btn_Triche.BackColor = System.Drawing.Color.Linen;
            this.Btn_Triche.Location = new System.Drawing.Point(1084, 470);
            this.Btn_Triche.Name = "Btn_Triche";
            this.Btn_Triche.Size = new System.Drawing.Size(146, 40);
            this.Btn_Triche.TabIndex = 60;
            this.Btn_Triche.Text = "Triche";
            this.Btn_Triche.UseVisualStyleBackColor = false;
            this.Btn_Triche.Click += new System.EventHandler(this.Btn_Triche_Click);
            // 
            // Ecran_Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1247, 534);
            this.Controls.Add(this.Btn_Triche);
            this.Controls.Add(this.RTB_Defausse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Paires);
            this.Controls.Add(this.PB_Copyright);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Panel_Jeu);
            this.Controls.Add(this.Btn_Save);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1265, 581);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1265, 581);
            this.Name = "Ecran_Jeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valet Noir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ecran_Jeu_FormClosing);
            this.Panel_Jeu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_PiocheA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Defausse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Copyright)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.SaveFileDialog Dlg_Enregistrer;
        private System.Windows.Forms.Panel Panel_Jeu;
        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.PictureBox PB_Copyright;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList IL_Carte;
        private System.Windows.Forms.Button Btn_Paires;
        private System.Windows.Forms.PictureBox PB_Defausse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Tour;
        private System.Windows.Forms.PictureBox PB_PiocheA;
        private System.Windows.Forms.RichTextBox RTB_Defausse;
        private System.Windows.Forms.Button Btn_Triche;
    }
}