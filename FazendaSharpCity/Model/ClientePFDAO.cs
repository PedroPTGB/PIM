using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class ClientePFDAO : IDAO
    {

        public NpgsqlConnection Connection { get; set; } = null;
        public ClientePFDAO(string host, string port, string database, string user, string pass)
        {
            Connect(host, port, database, user, pass);
        }
        public void Search(ClientePFModel cliente)
        {
            string query = "SELECT * FROM Pessoas WHERE ID = @ID";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", cliente.IdCliente);

            c2.ExecuteNonQuery();
        }
        public void Insert(ClientePFModel cliente)
        {
            string query = "INSERT INTO Pessoas (nome, CPF, RG, dtNasc, email, telefone) VALUES (@Nome, @CPF, @RG, @DtNasc, @email, @telefone)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", cliente.Nome);
            c2.Parameters.AddWithValue("CPF", cliente.Cpf);
            c2.Parameters.AddWithValue("RG", cliente.Rg);
            c2.Parameters.AddWithValue("dtNasc", cliente.DtNasc);
            c2.Parameters.AddWithValue("email", cliente.Email);
            c2.Parameters.AddWithValue("telefone", cliente.Telefone);

            c2.ExecuteNonQuery();
        }

        public void Update(ClientePFModel cliente)
        {
            string query = "UPDATE Pessoas (nome, sexo, CPF, RG, dtNasc, email, telefone) VALUES (@Nome, @Sexo, @CPF, @RG, @DtNasc, @email, @telefone)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", cliente.Nome);
            c2.Parameters.AddWithValue("Sexo", cliente.Sexo);
            c2.Parameters.AddWithValue("CPF", cliente.Cpf);
            c2.Parameters.AddWithValue("RG", cliente.Rg);
            c2.Parameters.AddWithValue("dtNasc", cliente.DtNasc);
            c2.Parameters.AddWithValue("email", cliente.Email);
            c2.Parameters.AddWithValue("telefone", cliente.Telefone);

            c2.ExecuteNonQuery();
        }

        public void Delete(ClientePFModel cliente)
        {
            string query = "DELETE FROM Pessoas WHERE ID = @ID";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", cliente.IdCliente);

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
