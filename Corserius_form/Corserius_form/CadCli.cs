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

namespace Corserius_form
{
    public partial class CadCli : Form
    {
        string caminho = @"C:\Otavio.1DS\Corserius-forms\Corserius-forms\CadastroCliente.txt";
        public CadCli()
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
        private void button1_Click(object sender, EventArgs e)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            try
            {
                Match match = regex.Match(TxbEmail.Text);
                if (!match.Success)
                {
                    MessageBox.Show("Digite o Email corretamente");
                    return;
                }
                var usuario = new Usuario
                {
                    Nome = txbName.Text,
                    Email = TxbEmail.Text,
                    Telefone = maskedTextBox1.Text
                };
                usuarios.Add(usuario);

                System.IO.File.AppendAllText(caminho, usuario.ToString() + Environment.NewLine);

                MessageBox.Show("Cadastro bem sucedido");
                txbName.Clear();
                TxbEmail.Clear();
                maskedTextBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Campos Invalidos");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbName.Clear();
            TxbEmail.Clear();
            maskedTextBox1.Clear();
        }
    }
}
