using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Gerenciamento_Hotel
{
    public class AcessoBD
    {
        string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;

        public bool inserirFuncionario(string fun_nome,string fun_sobrenome, string fun_titulo)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "insert into funcionarios (fun_nome,fun_sobrenome,fun_titulo) values ('"+ fun_nome + "','"+ fun_sobrenome + "','"+ fun_titulo + "');";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }


}
