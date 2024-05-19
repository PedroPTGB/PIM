using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class ProdutoDAO : IDAO
    {
        public NpgsqlConnection Connection { get; set; } = null;

        public ProdutoDAO(string host, string port, string database, string user, string pass)
        {
            Connect(host, port, database, user, pass);
        }


        public void Search(ProdutoModel produto)
        {
            string query = "SELECT * FROM Produtos WHERE ID = @ID";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", produto.IdProduto);

            c2.ExecuteNonQuery();
        }
        public void Insert(ProdutoModel produto)
        {
            string query = "INSERT INTO Produtos (produto, preco, tipoProduto) VALUES (@Nome, @Preco, @TipoProduto)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", produto.Nome);
            c2.Parameters.AddWithValue("Preco", produto.Preco);
            c2.Parameters.AddWithValue("TipoProduto", produto.TipoProduto);

            c2.ExecuteNonQuery();
        }

        public void Update(ProdutoModel produto)
        {
            string query = "UPDATE Produtos (produto, preco, tipoProduto) VALUES (@Nome, @Preco, @TipoProduto)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", produto.Nome);
            c2.Parameters.AddWithValue("Preco", produto.Preco);
            c2.Parameters.AddWithValue("TipoProduto", produto.TipoProduto);

            c2.ExecuteNonQuery();
        }

        public void Delete(ProdutoModel produto)
        {
            string query = "DELETE FROM Produtos WHERE ID = @ID";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", produto.IdProduto);

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
