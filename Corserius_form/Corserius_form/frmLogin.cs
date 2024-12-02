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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try { 
            if(txbUsu.Text == "tavin" && txbSenha.Text == "lilica")
                {
                frmMenu Menu = new frmMenu();
                Menu.Show();
                this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha invalidos");
                }
            }
            catch
            {
                MessageBox.Show("Usuario ou Senha incorretos");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
