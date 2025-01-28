using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtCpf.Text.Equals("")
                    && !txtEmail.Text.Equals("") && !txtTelefone.Text.Equals("")
                    && !txtEndereco.Text.Equals(""))
                {
                    Funcionario c = new Funcionario();

                    string nome = txtNome.Text;
                    c.SetNome(nome);
                    string cpf = txtCpf.Text;
                    c.SetCpf(cpf);
                    string email = txtEmail.Text;
                    c.SetEmail(email);
                    string telefone = txtTelefone.Text;
                    c.SetTelefone(telefone);
                    string endereco = txtEndereco.Text;
                    c.SetEndereco(endereco);

                    if (c.InserirDados())
                    {
                        MessageBox.Show("Funcionário cadastrado com sucesso.");
                        txtNome.Clear();
                        txtCpf.Clear();
                        txtEmail.Clear();
                        txtTelefone.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar funcionário.");
                        txtNome.Clear();
                        txtCpf.Clear();
                        txtEmail.Clear();
                        txtTelefone.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos.");
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtEmail.Clear();
                    txtTelefone.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
                txtNome.Clear();
                txtCpf.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtEndereco.Clear();
                txtNome.Focus();
            }
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            FormListar form = new FormListar();
            form.ShowDialog();
        }
    }
}
