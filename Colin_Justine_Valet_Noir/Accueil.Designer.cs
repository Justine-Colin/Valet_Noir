namespace Colin_Justine_Valet_Noir
{
    partial class Accueil
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
            this.Dlg_Load = new System.Windows.Forms.OpenFileDialog();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_Aide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dlg_Load
            // 
            this.Dlg_Load.FileName = "openFileDialog1";
            // 
            // Btn_New
            // 
            this.Btn_New.BackColor = System.Drawing.Color.Linen;
            this.Btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_New.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_New.Location = new System.Drawing.Point(27, 12);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(565, 98);
            this.Btn_New.TabIndex = 0;
            this.Btn_New.Text = "Nouvelle Partie";
            this.Btn_New.UseVisualStyleBackColor = false;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_Load
            // 
            this.Btn_Load.BackColor = System.Drawing.Color.Linen;
            this.Btn_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Load.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Load.Location = new System.Drawing.Point(27, 135);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(565, 98);
            this.Btn_Load.TabIndex = 1;
            this.Btn_Load.Text = "Charger Partie";
            this.Btn_Load.UseVisualStyleBackColor = false;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // Btn_Aide
            // 
            this.Btn_Aide.BackColor = System.Drawing.Color.Linen;
            this.Btn_Aide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Aide.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aide.Location = new System.Drawing.Point(27, 362);
            this.Btn_Aide.Name = "Btn_Aide";
            this.Btn_Aide.Size = new System.Drawing.Size(90, 34);
            this.Btn_Aide.TabIndex = 2;
            this.Btn_Aide.Text = "Aide";
            this.Btn_Aide.UseVisualStyleBackColor = false;
            this.Btn_Aide.Click += new System.EventHandler(this.Btn_Aide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "COLIN Justine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Haute Ecole de la Ville de Liège";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Colin_Justine_Valet_Noir.Properties.Resources.Copyright1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(483, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 15);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.BackColor = System.Drawing.Color.Linen;
            this.Btn_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Quit.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quit.Location = new System.Drawing.Point(27, 258);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(565, 98);
            this.Btn_Quit.TabIndex = 6;
            this.Btn_Quit.Text = "Quitter";
            this.Btn_Quit.UseVisualStyleBackColor = false;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(612, 403);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Aide);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.Btn_New);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog Dlg_Load;
        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button Btn_Aide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Quit;
    }
}