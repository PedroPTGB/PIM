using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class FuncionarioDAO : IDAO
    {
        public NpgsqlConnection Connection { get; set; } = null;
        public FuncionarioDAO(string host, string port, string database, string user, string pass)
        {
            Connect(host, port, database, user, pass);
        }
        public void Search(FuncionarioModel funcionario)
        {
            string query = "SELECT * FROM Pessoas WHERE ID = @ID";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", funcionario.IdFuncionario);

            c2.ExecuteNonQuery();
        }
        public void Insert(FuncionarioModel funcionario)
        {
            string query = "INSERT INTO Pessoas (nome, CPF, RG, dtNasc, email, telefone, gerente, login, senha) VALUES (@Nome, @CPF, @RG, @DtNasc, @email, @telefone, @cargo, @login, @senha)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", funcionario.Nome);
            c2.Parameters.AddWithValue("CPF", funcionario.Cpf);
            c2.Parameters.AddWithValue("RG", funcionario.Rg);
            c2.Parameters.AddWithValue("dtNasc", funcionario.DtNasc);
            c2.Parameters.AddWithValue("email", funcionario.Email);
            c2.Parameters.AddWithValue("telefone", funcionario.Telefone);
            c2.Parameters.AddWithValue("cargo", funcionario.Cargo);
            c2.Parameters.AddWithValue("login", funcionario.LoginName);
            c2.Parameters.AddWithValue("senha", funcionario.Senha);

            c2.ExecuteNonQuery();
        }

        public void Update(FuncionarioModel funcionario)
        {
            string query = "UPDATE Pessoas (nome, CPF, RG, dtNasc, email, telefone, gerente, login, senha) VALUES (@Nome, @CPF, @RG, @DtNasc, @email, @telefone, @cargo, @login, @senha)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", funcionario.Nome);
            c2.Parameters.AddWithValue("CPF", funcionario.Cpf);
            c2.Parameters.AddWithValue("RG", funcionario.Rg);
            c2.Parameters.AddWithValue("dtNasc", funcionario.DtNasc);
            c2.Parameters.AddWithValue("email", funcionario.Email);
            c2.Parameters.AddWithValue("telefone", funcionario.Telefone);
            c2.Parameters.AddWithValue("cargo", funcionario.Cargo);
            c2.Parameters.AddWithValue("login", funcionario.LoginName);
            c2.Parameters.AddWithValue("senha", funcionario.Senha);

            c2.ExecuteNonQuery();
        }

        public void Delete(FuncionarioModel funcionario)
        {
            string query = "DELETE FROM Pessoas WHERE ID = @ID";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", funcionario.IdFuncionario);

            c2.ExecuteNonQuery();
        }

        private void Connect(string host, string port, string database, string user, string pass)
        {
            if (Connection == null)
            {
                Connection = new NpgsqlConnection(
                $"Server={host};" +
                $"Port={port};" +
                $"Database={database};" +
                $"Uid={user};" +
                $"Pwd={pass};");

                Connection.Open();
            }
        }

        private void Disconnect()
        {
            if (Connection != null)
            {
                Connection.Close();
            }
        }

    }
}
