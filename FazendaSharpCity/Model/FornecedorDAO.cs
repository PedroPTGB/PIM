using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class FornecedorDAO : IDAO
    {
        public NpgsqlConnection Connection { get; set; } = null;
        public FornecedorDAO(string host, string port, string database, string user, string pass)
        {
            Connect(host, port, database, user, pass);
        }
        public void Search(FornecedorModel fornecedor)
        {
            string query = "SELECT * FROM Pessoas WHERE ID = @ID";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", fornecedor.IdFornecedor);

            c2.ExecuteNonQuery();
        }
        public void Insert(FornecedorModel fornecedor)
        {
            string query = "INSERT INTO Pessoas (nomeFantasia, CNPJ, inscricaoEstadual, inscricaoMunicipal, email, telefone) VALUES (@NomeFantasia, @CNPJ, @inscricaoEstadual, @inscricaoMunicipal, @email, @telefone)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("NomeFantasia", fornecedor.NomeFantasia);
            c2.Parameters.AddWithValue("CNPJ", fornecedor.Cnpj);
            c2.Parameters.AddWithValue("inscricaoEstadual", fornecedor.InscricaoEstadual);
            c2.Parameters.AddWithValue("inscricaoMunicipal", fornecedor.InscricaoMunicipal);
            c2.Parameters.AddWithValue("email", fornecedor.Email);
            c2.Parameters.AddWithValue("telefone", fornecedor.Telefone);

            c2.ExecuteNonQuery();
        }

        public void Update(FornecedorModel fornecedor)
        {
            string query = "UPDATE Pessoas (nomeFantasia, CNPJ, inscricaoEstadual, inscricaoMunicipal, email, telefone) VALUES (@NomeFantasia, @CNPJ, @inscricaoEstadual, @inscricaoMunicipal, @email, @telefone)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("NomeFantasia", fornecedor.NomeFantasia);
            c2.Parameters.AddWithValue("CNPJ", fornecedor.Cnpj);
            c2.Parameters.AddWithValue("inscricaoEstadual", fornecedor.InscricaoEstadual);
            c2.Parameters.AddWithValue("inscricaoMunicipal", fornecedor.InscricaoMunicipal);
            c2.Parameters.AddWithValue("email", fornecedor.Email);
            c2.Parameters.AddWithValue("telefone", fornecedor.Telefone);

            c2.ExecuteNonQuery();
        }

        public void Delete(FornecedorModel fornecedor)
        {
            string query = "DELETE FROM Pessoas WHERE ID = @ID";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", fornecedor.IdFornecedor);

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