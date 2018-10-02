using System;
using System.Windows.Forms;

namespace Colin_Justine_Valet_Noir
{
    public partial class Splash : Form
    {
        private int i = 0;
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            i++;
            if (i == 3)
            {
                Close();
            }
        }
    }
}
