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
    public partial class frmMenu : Form
    {
        private bool piscando = true;
        private Timer timer;
        public frmMenu()
        {
            InitializeComponent();

            timer = new Timer
            {
                Interval = 550
            };
            timer.Tick += (s, e) =>
            {
                
                if (piscando)
                {
                    button1.BackColor = Color.RosyBrown;
                }
                else
                {
                    button1.BackColor = Color.LightSkyBlue;
                }
                piscando = !piscando;
            };
            timer.Start();
        }
    

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadCli cadcli = new CadCli();
            cadcli.MdiParent = this;
            cadcli.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFuncionario Cadfun = new frmCadFuncionario();
            Cadfun.MdiParent = this;
            Cadfun.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultClient consultaCliente = new ConsultClient();
            consultaCliente.MdiParent = this;
            consultaCliente.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultFun consultarFun = new frmConsultFun();
            consultarFun.MdiParent = this;
            consultarFun.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            toolmenuUsu.Text = "tavin";
        }

        private void trocarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobrenos = new frmSobre();
            sobrenos.MdiParent = this;
            sobrenos.Show();
        }

        private void exe2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExe2 exe2 = new frmExe2();
            exe2.MdiParent = this;
            exe2.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmExe1 exe1 = new frmExe1();
            exe1.MdiParent = this;
            exe1.Show();
        }

        private void exe3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExe3 exe3 = new frmExe3();
            exe3.MdiParent = this;
            exe3.Show();
        }

        private void exe4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExe4 exe4 = new frmExe4();
            exe4.MdiParent = this;
            exe4.Show();
        }

        private void exe5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExe5 exe5 = new frmExe5();
            exe5.MdiParent = this;
            exe5.Show();
        }

        private void exe6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExe6 exe6 = new frmExe6();
            exe6.MdiParent = this;
            exe6.Show();
        }

        private void exe7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExe7 exe7 = new frmExe7();
            exe7.MdiParent = this;
            exe7.Show();
        }

        private void exe8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExe8 exe8 = new frmExe8();
            exe8.MdiParent = this;
            exe8.Show();
        }

        private void exe9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExe9 exe9 = new frmExe9();
            exe9.MdiParent = this;
            exe9.Show();
        }

        private void exe10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExe10 exe10 = new frmExe10();
            exe10.MdiParent = this;
            exe10.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
