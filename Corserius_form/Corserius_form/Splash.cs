using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corserius_form
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (PBsplash.Value < 100)
            {
                PBsplash.Value++;
            }
            else { 
                timer1.Enabled = false;
                frmLogin Login = new frmLogin();
                Login.Show();
                this.Hide();
            }
        }
    }
}
