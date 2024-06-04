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

        public EnderecoModel SearchEndereco(ClientePFModel cliente)
        {
            EnderecoModel endereco = new EnderecoModel();
            string query = "SELECT cidade, bairro, logradouro, complemento, estado, cep FROM cliente WHERE idcliente = @ID";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);
            c2.Parameters.AddWithValue("ID", cliente.IdCliente);
            
            NpgsqlDataReader reader = c2.ExecuteReader();

            while (reader.Read())
            {
                endereco.Cidade = reader[0].ToString();
                endereco.Bairro = reader[1].ToString();
                endereco.Logradouro = reader[2].ToString();
                endereco.Complemento = reader[3].ToString();
                endereco.Estado = reader[4].ToString();
                endereco.cep = reader[5].ToString();
            }

            reader.Close();


            return endereco;
        }
        
        public void Insert(ClientePFModel cliente)
        {
            string query = "INSERT INTO cliente (nome, CPF, dtNasc, email, telefone, estado, cidade, bairro, logradouro, complemento, cep) VALUES (@Nome, @CPF, @DtNasc, @email, @telefone, @estado, @cidade, @bairro, @logradouro, @complemento, @cep)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", cliente.Nome);
            c2.Parameters.AddWithValue("CPF", cliente.Cpf);
            c2.Parameters.AddWithValue("dtNasc", cliente.DtNasc);
            c2.Parameters.AddWithValue("email", cliente.Email);
            c2.Parameters.AddWithValue("telefone", cliente.Telefone);
            c2.Parameters.AddWithValue("estado", cliente.Endereco.Estado);
            c2.Parameters.AddWithValue("cidade", cliente.Endereco.Cidade);
            c2.Parameters.AddWithValue("bairro", cliente.Endereco.Bairro);
            c2.Parameters.AddWithValue("logradouro", cliente.Endereco.Logradouro);
            c2.Parameters.AddWithValue("complemento", cliente.Endereco.Complemento);
            c2.Parameters.AddWithValue("cep", cliente.Endereco.cep);

            c2.ExecuteNonQuery();
        }

        public void Update(ClientePFModel cliente)
        {
            string query = "UPDATE cliente (nome, CPF, dtNasc, email, telefone, estado, cidade, bairro, logradouro, complemento, cep) VALUES (@Nome, @CPF, @DtNasc, @email, @telefone, @estado, @cidade, @bairro, @logradouro, @complemento, @cep)";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", cliente.Nome);
            c2.Parameters.AddWithValue("CPF", cliente.Cpf);
            c2.Parameters.AddWithValue("dtNasc", cliente.DtNasc);
            c2.Parameters.AddWithValue("email", cliente.Email);
            c2.Parameters.AddWithValue("telefone", cliente.Telefone);
            c2.Parameters.AddWithValue("estado", cliente.Endereco.Estado);
            c2.Parameters.AddWithValue("cidade", cliente.Endereco.Cidade);
            c2.Parameters.AddWithValue("bairro", cliente.Endereco.Bairro);
            c2.Parameters.AddWithValue("logradouro", cliente.Endereco.Logradouro);
            c2.Parameters.AddWithValue("complemento", cliente.Endereco.Complemento);
            c2.Parameters.AddWithValue("cep", cliente.Endereco.cep);

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
            string query = "SELECT idcliente, nome, cpf, dtnascimento, email, telefone FROM cliente C INNER JOIN telefone T ON C.idtelefonecliente = T.idtelefone;";
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
