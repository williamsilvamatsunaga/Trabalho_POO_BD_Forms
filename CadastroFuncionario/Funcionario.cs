using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public class Funcionario
    {
        private string id_funcionario;
        private string nome;
        private string cpf;
        private string email;
        private string telefone;
        private string endereco;

        public void SetNome(string nome)
        {
            if (nome.Length <= 50)
            {
                this.nome = nome;
            }
            else
            {
                throw new Exception("O nome deve conter no máximo 50 caracteres.");
            }
        }

        public void SetCpf(string cpf)
        {
            if (cpf.Length == 11)
            {
                this.cpf = cpf;
            }
            else
            {
                throw new Exception("O CPF deve conter 11 caracteres.");
            }
        }

        public void SetEmail(string email)
        {
            if (email.Length <= 50)
            {
                this.email = email;
            }
            else
            {
                throw new Exception("O email deve conter no máximo 50 caracteres.");
            }
        }

        public void SetTelefone(string telefone)
        {
            if (telefone.Length == 11)
            {
                this.telefone = telefone;
            }
            else
            {
                throw new Exception("O telefone deve conter 11 caracteres.");
            }
        }

        public void SetEndereco(string endereco)
        {
            if (endereco.Length <= 50)
            {
                this.endereco = endereco;
            }
            else
            {
                throw new Exception("O endereço deve conter no máximo 50 caracteres.");
            }
        }

        public bool InserirDados()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string insert = $"INSERT INTO Funcionarios (nome, cpf, email, telefone, endereco) VALUES " +
                    $"('{nome}', '{cpf}', '{email}', '{telefone}', '{endereco}')";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                return false;
            }
        }
    }
}
