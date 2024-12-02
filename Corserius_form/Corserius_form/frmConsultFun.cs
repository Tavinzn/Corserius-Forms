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
    public partial class frmConsultFun : Form
    {
        public frmConsultFun()
        {
            InitializeComponent();
        }
        string caminho = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:\Otavio.1DS\Corserius-forms\Corserius-forms\CadastroFuncionario.txt");
        public class Usuario
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
        }
        private void btnConsultarFun_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(caminho))
            {
                MessageBox.Show("Arquivo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var usuarios = new List<Usuario>();

            string[] linhas = System.IO.File.ReadAllLines(caminho);
            Usuario usuarioTemp = null;
            foreach (string linha in linhas)
            {
                if (linha == "***********" && usuarioTemp != null)
                {
                    usuarios.Add(usuarioTemp);
                    usuarioTemp = null;
                }
                else
                {
                    if (usuarioTemp == null)
                    {
                        usuarioTemp = new Usuario();
                    }


                    if (string.IsNullOrWhiteSpace(usuarioTemp.Nome))
                    {
                        usuarioTemp.Nome = linha;
                    }
                    else if (string.IsNullOrWhiteSpace(usuarioTemp.Email))
                    {
                        usuarioTemp.Email = linha;
                    }
                    else if (string.IsNullOrWhiteSpace(usuarioTemp.Telefone))
                    {
                        usuarioTemp.Telefone = linha;
                    }
                }
            }


            dgListFun.DataSource = usuarios;
        }
    
    }
    }

