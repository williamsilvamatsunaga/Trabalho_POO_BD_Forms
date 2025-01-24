using MySql.Data.MySqlClient;
using System;

namespace CadastroFuncionario
{
    internal class MySqlConection
    {
        private string bancoServidor;

        public MySqlConection(string bancoServidor)
        {
            this.bancoServidor = bancoServidor;
        }

        internal MySqlCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}