using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Corserius_form
{
    public partial class frmCadFuncionario : Form
    {
        string caminho = @"C:\Otavio.1DS\Corserius-forms\Corserius-forms\CadastroFuncionario.txt";
        public frmCadFuncionario()
        {
            InitializeComponent();
        }
        public class Usuario
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }

            public override string ToString()
            {
                return $"{Nome}\n{Email}\n{Telefone}\n***********";
            }
        }
        private List<Usuario> usuarios = new List<Usuario>();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            try
            {
                Match match = regex.Match(txbEmailfun.Text);
                if (!match.Success)
                {
                    MessageBox.Show("Digite o Email corretamente");
                    return;
                }
                var usuario = new Usuario
                {
                    Nome = txbNamefun.Text,
                    Email = txbEmailfun.Text,
                    Telefone = maskedTextBox2.Text
                };
                usuarios.Add(usuario);

                System.IO.File.AppendAllText(caminho, usuario.ToString() + Environment.NewLine);

                MessageBox.Show("Cadastrado Com Êxito", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbEmailfun.Clear();
                txbNamefun.Clear();
                maskedTextBox2.Clear();
            }
            catch
            {
                MessageBox.Show("Campos Invalidos");
            }
        }

        private void btnLimparFun_Click(object sender, EventArgs e)
        {
            txbEmailfun.Clear();
            txbNamefun.Clear();
            maskedTextBox2.Clear();
        }
    }
}
