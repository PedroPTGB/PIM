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


        public System.Data.DataTable Search(ProdutoModel produto)
        {
            if (produto.nome == null)
            {
                string query = "SELECT * FROM produto WHERE idproduto = @ID ORDER BY idproduto;";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

                c2.Parameters.AddWithValue("ID", produto.idProduto);

                System.Data.DataTable table = new System.Data.DataTable();
                da.Fill(table);

                return table;
            }
            else
            {
                string query = "SELECT * FROM produto WHERE produto.produto ILIKE ANY (ARRAY[@Nome, @Nome2, @Nome3]) ORDER BY idproduto;";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

                c2.Parameters.AddWithValue("Nome", "%" + produto.nome + "%");
                c2.Parameters.AddWithValue("Nome2", produto.nome + "%");
                c2.Parameters.AddWithValue("Nome3", "%" + produto.nome);


                System.Data.DataTable table = new System.Data.DataTable();
                da.Fill(table);

                return table;
            }

        }

        public System.Data.DataTable List()
        {
            string query = "SELECT * FROM produto ORDER BY idproduto;";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);
            return table;
        }

        public void Insert(ProdutoModel produto)
        {
            string query = "INSERT INTO produto (produto, qtdproduto, validade, preco, descricao ) VALUES (@Nome, @QTD, @Validade, @Preco, @Descricao)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", produto.nome);
            c2.Parameters.AddWithValue("QTD", produto.qtd);
            c2.Parameters.AddWithValue("Validade", produto.validade);
            c2.Parameters.AddWithValue("Preco", produto.preco);
            c2.Parameters.AddWithValue("Descricao", produto.descricao);

            c2.ExecuteNonQuery();
        }

        public void Update(ProdutoModel produto)
        {
            string query = "UPDATE produto SET " +
                "produto = @Nome, " +
                "qtdproduto = @QTD, " +
                "validade = @Validade, " +
                "preco = @preco, " +
                "descricao = @Descricao " +
                "WHERE idproduto = @ID;";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", produto.idProduto);
            c2.Parameters.AddWithValue("Nome", produto.nome);
            c2.Parameters.AddWithValue("QTD", produto.qtd);
            c2.Parameters.AddWithValue("Validade", produto.validade);
            c2.Parameters.AddWithValue("Preco", produto.preco);
            c2.Parameters.AddWithValue("Descricao", produto.descricao);

            c2.ExecuteNonQuery();
        }

        public void Delete(ProdutoModel produto)
        {
            string query = "DELETE FROM produto WHERE idproduto = @ID";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", produto.idProduto);

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
