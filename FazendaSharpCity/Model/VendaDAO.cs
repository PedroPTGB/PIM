using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FazendaSharpCity.Model
{
    internal class VendaDAO : IDAO
    {
        public NpgsqlConnection Connection { get; set; } = null;

        public VendaDAO(string host, string port, string database, string user, string pass)
        {
            Connect(host, port, database, user, pass);
        }


        public System.Data.DataTable Search(VendaModel venda)
        {
            string query = "SELECT * FROM venda WHERE idvenda = @ID ORDER BY idvenda;";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            c2.Parameters.AddWithValue("ID", venda.IdVenda);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);

            return table;

        }

        public System.Data.DataTable List()
        {
            string query = "SELECT * FROM venda ORDER BY idvenda;";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);
            return table;
        }

        public void Insert(VendaModel venda)
        {
            string query = "INSERT INTO venda (precounitario, dtvenda, formapagamento, quantidade) VALUES (@PrecoU, @DtVenda, @FormPag, @QTD)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("PrecoU", venda.PrecoUnit);
            c2.Parameters.AddWithValue("DtVenda", venda.DtVenda);
            c2.Parameters.AddWithValue("FormPag", venda.FormaPag);
            c2.Parameters.AddWithValue("QTD", venda.Qtd);

            c2.ExecuteNonQuery();
        }

        public void Update(VendaModel venda)
        {
            string query = "UPDATE venda SET " +
                "precounitario = @PrecoU, " +
                "dtvenda = @DtVenda, " +
                "formapagamento = @FormPag, " +
                "quantidade = @QTD " +
                "WHERE idvenda = @ID;";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", venda.IdVenda);
            c2.Parameters.AddWithValue("PrecoU", venda.PrecoUnit);
            c2.Parameters.AddWithValue("DtVenda", venda.DtVenda);
            c2.Parameters.AddWithValue("FormPag", venda.FormaPag);
            c2.Parameters.AddWithValue("QTD", venda.Qtd);

            c2.ExecuteNonQuery();
        }

        public void Delete(VendaModel venda)
        {
            string query = "DELETE FROM venda WHERE idvenda = @ID";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", venda.IdVenda);

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