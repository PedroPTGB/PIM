using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class ClientePFDAO : IDAO
    {

        public NpgsqlConnection Connection { get; set; } = null;
        public ClientePFDAO(string host, string port, string database, string user, string pass)
        {
            Connect(host, port, database, user, pass);
        }
        public System.Data.DataTable Search(ClientePFModel cliente)
        {
            if(cliente.Nome == null) 
            {
                string query = "SELECT * FROM cliente WHERE idcliente = @ID";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

                c2.Parameters.AddWithValue("ID", cliente.IdCliente);

                System.Data.DataTable table = new System.Data.DataTable();
                da.Fill(table);

                return table;
            }
            else
            {
                string query = "SELECT * FROM cliente WHERE nome LIKE @Nome";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

                c2.Parameters.AddWithValue("Nome", "%"+cliente.Nome+"%");

                System.Data.DataTable table = new System.Data.DataTable();
                da.Fill(table);

                return table;
            }


        }
        public void Insert(ClientePFModel cliente)
        {
            string query = "INSERT INTO cliente (nome, CPF, RG, dtNasc, email, telefone) VALUES (@Nome, @CPF, @RG, @DtNasc, @email, @telefone)";

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
            string query = "UPDATE cliente (nome, sexo, CPF, RG, dtNasc, email, telefone) VALUES (@Nome, @Sexo, @CPF, @RG, @DtNasc, @email, @telefone)";

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
            string query = "DELETE FROM cliente WHERE idcliente = @ID;";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", cliente.IdCliente);

            c2.ExecuteNonQuery();
        }
        public System.Data.DataTable List()
        {
            string query = "SELECT * FROM cliente;";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);
            return table;
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
