using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class ClientePJDAO : IDAO
    {
        public NpgsqlConnection Connection { get; set; } = null;
        public ClientePJDAO(string host, string port, string database, string user, string pass)
        {
            Connect(host, port, database, user, pass);
        }
        public void Search(ClientePJModel cliente)
        {
            string query = "SELECT * FROM Pessoas WHERE ID = @ID";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", cliente.IdCliente);

            c2.ExecuteNonQuery();
        }
        public void Insert(ClientePJModel cliente)
        {
            string query = "INSERT INTO Pessoas (nomeFantasia, CNPJ, inscricaoEstadual, inscricaoMunicipal, email, telefone) VALUES (@nomeFantasia, @CNPJ, @inscricaoEstadual, @inscricaoMunicipal, @email, @telefone)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", cliente.NomeFantasia);
            c2.Parameters.AddWithValue("CNPJ", cliente.Cnpj);
            c2.Parameters.AddWithValue("inscricaoEstadual", cliente.InscricaoEstadual);
            c2.Parameters.AddWithValue("inscricaoMunicipal", cliente.InscricaoMunicipal);
            c2.Parameters.AddWithValue("email", cliente.Email);
            c2.Parameters.AddWithValue("telefone", cliente.Telefone);

            c2.ExecuteNonQuery();
        }

        public void Update(ClientePJModel cliente)
        {
            string query = "UPDATE Pessoas (nomeFantasia, CNPJ, inscricaoEstadual, inscricaoMunicipal, email, telefone) VALUES (@nomeFantasia, @CNPJ, @inscricaoEstadual, @inscricaoMunicipal, @email, @telefone)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", cliente.NomeFantasia);
            c2.Parameters.AddWithValue("CNPJ", cliente.Cnpj);
            c2.Parameters.AddWithValue("inscricaoEstadual", cliente.InscricaoEstadual);
            c2.Parameters.AddWithValue("inscricaoMunicipal", cliente.InscricaoMunicipal);
            c2.Parameters.AddWithValue("email", cliente.Email);
            c2.Parameters.AddWithValue("telefone", cliente.Telefone);

            c2.ExecuteNonQuery();
        }

        public void Delete(ClientePJModel cliente)
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

