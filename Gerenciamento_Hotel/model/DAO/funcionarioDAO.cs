using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Gerenciamento_Hotel
{
    public class funcionarioDAO
    {
        string conexaoString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";
        MySqlConnection connection = null;
        MySqlCommand command;

        public bool inserirFuncionario(string fun_nome,string fun_sobrenome, string fun_cpf, string fun_titulo)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "insert into funcionarios (fun_nome,fun_sobrenome,fun_cpf,fun_titulo) values ('"+ fun_nome + "','"+ fun_sobrenome + "','"+ fun_cpf + "','" + fun_titulo + "');";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool listarFuncionarios()
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
               // command.CommandText = "insert into funcionarios (fun_nome,fun_sobrenome,fun_titulo) values ('" + fun_nome + "','" + fun_sobrenome + "','" + fun_titulo + "');";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool alterarNomeFuncionario(int fun_id,string fun_nome)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "update funcionarios set fun_nome = '"+fun_nome+"' where fun_id = "+fun_id+";";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool alterarSobrenomeFuncionario(int fun_id,string fun_sobrenome)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "update funcionarios set fun_sobrenome = '"+ fun_sobrenome + "' where fun_id = "+fun_id+";";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool alterarTituloFuncionario(int fun_id,string fun_titulo)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "update funcionarios set fun_titulo = '" + fun_titulo + "' where fun_id = "+fun_id+";";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool alterarCpfFuncionario(int fun_id,string fun_cpf)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "update funcionarios set fun_cpf = '" + fun_cpf + "' where fun_id = "+fun_id+";";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool alterarTudoFuncionario(int fun_id,string fun_nome, string fun_sobrenome, string fun_cpf, string fun_titulo)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "update funcionarios set fun_nome = '" + fun_nome + "', fun_sobrenome = '" + fun_sobrenome + "', fun_cpf = '" + fun_cpf + "',fun_titulo = '" + fun_titulo + "' where fun_id = " + fun_id+";";

                command.ExecuteNonQuery();
                command.Connection.Close(); //fecha conexão

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deletarFuncionario(int fun_cpf)
        {
            try
            {
                connection = new MySqlConnection(conexaoString);
                connection.Open(); // abre a conexão
                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "delete from funcionarios where fun_cpf = '"+fun_cpf+"';";

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
