using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario
{
    internal class ConexaoBanco
    {
        private const string servidor = "localhost";
        private const string bancoDados = "CadastrarFuncionario";
        private const string usuario = "root";
        private const string senha = "root";

        static public string bancoServidor = $"Server={servidor};Database={bancoDados};Uid={usuario};Pwd={senha}";
    }
}
