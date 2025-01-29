using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (nome.Length > 50)
            {
                throw new Exception("O nome deve conter no máximo 50 caracteres.");
            }
            foreach (char c in nome)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    throw new Exception("O nome deve conter apenas letras.");
                }
            }

            this.nome = nome;
        }

        public void SetCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                throw new Exception("O CPF deve conter 11 dígitos.");
            }

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                int digito = int.Parse(cpf[i].ToString());
                soma = soma + digito * (10 - i);
            }

            int primeiroDigitoVerificador = 11 - (soma % 11);
            if (primeiroDigitoVerificador >= 10)
            {
                primeiroDigitoVerificador = 0;
            }

            if (int.Parse(cpf[9].ToString()) != primeiroDigitoVerificador)
            {
                throw new Exception("CPF inválido.");
            }

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                int digito = int.Parse(cpf[i].ToString());
                soma = soma + digito * (11 - 1);
            }

            int segundoDigitoVerificador = 11 - (soma % 11);
            if (segundoDigitoVerificador >= 10)
            {
                segundoDigitoVerificador = 0;
            }

            if (int.Parse(cpf[10].ToString()) == segundoDigitoVerificador)
            {
                throw new Exception("CPF inválido.");
            }

            this.cpf = cpf;
        }

        public void SetEmail(string email)
        {
            if (email.Length > 50)
            {
                throw new Exception("Comprimento excede o limite permitido.");
            }

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                throw new Exception("Formato incorreto.");
            }

            this.email = email;
        }

        public void SetTelefone(string telefone)
        {
            telefone = telefone.Replace("(", "").Replace(")", "").Replace("-", "").Trim();

            if (!telefone.All(char.IsDigit))
            {
                throw new Exception("O número deve conter apenas díditos.");
            }

            if (telefone.Length != 11)
            {
                throw new Exception("O número deve conter 11 dígitos.");
            }

            this.telefone = telefone;
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


        public DataTable ListarDados()
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = "SELECT * FROM Funcionarios";

                MySqlCommand comandoSql = new MySqlCommand(select, MysqlConexaoBanco);
                MySqlDataAdapter da = new MySqlDataAdapter(comandoSql);

                da.Fill(dt);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);

            }

            return dt;
        }

        public bool AtualizarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"UPDATE Funcionarios SET nome = '{nome}', email = '{email}', telefone = '{telefone}', endereco = '{endereco}' WHERE cpf = '{cpf}'";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao conectar com o banco de dados" + ex.Message);
                return false;
            }
        }

        public bool DeletarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string delete = $"DELETE FROM Funcionarios WHERE cpf = '{cpf}'";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados" + ex.Message);
                return false;
            }
        }
    }
}
