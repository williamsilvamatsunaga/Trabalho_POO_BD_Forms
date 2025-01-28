using MySql.Data.MySqlClient;
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
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        private void btListar2_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario c = new Funcionario();

                DataTable dt = c.ListarDados();

                if (dt.Rows.Count > 0)
                {
                    
                    dgListar.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhum funcionário encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar funcionários. "+ ex.Message);
            }
        }
    }
}
