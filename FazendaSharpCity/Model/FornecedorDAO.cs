using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FazendaSharpCity.Model
{
    internal class FornecedorDAO : IDAO
    {
        public NpgsqlConnection Connection { get; set; } = null;
        public FornecedorDAO(string host, string port, string database, string user, string pass)
        {
            Connect(host, port, database, user, pass);
        }

        public System.Data.DataTable List()
        {
            string query = "SELECT idfornecedor, nomefantasia, cnpj, email FROM fornecedor F INNER JOIN telefone T ON F.idtelefonefornecedor = T.idtelefone ORDER BY F.idfornecedor;";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);
            return table;
        }
        
        public System.Data.DataTable Search(FornecedorModel fornecedor)
        {
            if (fornecedor.Nome == null)
            {
                string query = "SELECT idfornecedor, nomefantasia, cnpj, email FROM fornecedor F INNER JOIN telefone T ON F.idtelefonefornecedor = T.idtelefone WHERE F.idfornecedor = @ID ORDER BY F.idfornecedor";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

                c2.Parameters.AddWithValue("ID", fornecedor.idFornecedor);

                System.Data.DataTable table = new System.Data.DataTable();
                da.Fill(table);

                return table;
            }
            else
            {
                string query = "SELECT idfornecedor, nomefantasia, cnpj, email FROM fornecedor F INNER JOIN telefone T ON F.idtelefonefornecedor = T.idtelefone WHERE nomefantasia ILIKE ANY (ARRAY[@Nome, @Nome2, @Nome3]) AND razaosocial ILIKE ANY (ARRAY[@Nome, @Nome2, @Nome3]);";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

                c2.Parameters.AddWithValue("Nome", "%" + fornecedor.NomeFantasia + "%");
                c2.Parameters.AddWithValue("Nome2", fornecedor.NomeFantasia + "%");
                c2.Parameters.AddWithValue("Nome3", "%" + fornecedor.NomeFantasia);


                System.Data.DataTable table = new System.Data.DataTable();
                da.Fill(table);

                return table;
            }

        }

        public EnderecoModel SearchEndereco(FornecedorModel fornecedor)
        {
            EnderecoModel endereco = new EnderecoModel();
            string query = "SELECT cidade, bairro, logradouro, complemento, estado, cep FROM fornecedor WHERE idfornecedor = @ID";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);
            c2.Parameters.AddWithValue("ID", fornecedor.idFornecedor);

            NpgsqlDataReader reader = c2.ExecuteReader();

            while (reader.Read())
            {
                endereco.Cidade = reader[0].ToString();
                endereco.bairro = reader[1].ToString();
                endereco.Logradouro = reader[2].ToString();
                endereco.Complemento = reader[3].ToString();
                endereco.Estado = reader[4].ToString();
                endereco.cep = reader[5].ToString();
            }

            reader.Close();


            return endereco;
        }

        public void Insert(FornecedorModel fornecedor)
        {
            string query = "INSERT INTO telefone (telefone) VALUES (@telefone);" +
                            "INSERT INTO fornecedor (nomefantasia, razaosocial, cnpj, email, estado, cidade, bairro, logradouro, complemento, cep, idtelefonefornecedor) " +
                            "VALUES (@Nome, @RazaoSocial, @CNPJ, @email, @estado, @cidade, @bairro, @logradouro, @complemento, @cep, (SELECT idtelefone FROM telefone T WHERE T.telefone = @telefone));";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", fornecedor.NomeFantasia);
            c2.Parameters.AddWithValue("RazaoSocial", fornecedor.razaoSocial);
            c2.Parameters.AddWithValue("CNPJ", fornecedor.cnpj);
            c2.Parameters.AddWithValue("email", fornecedor.Email);
            c2.Parameters.AddWithValue("telefone", fornecedor.Telefone);
            c2.Parameters.AddWithValue("estado", fornecedor.Endereco.Estado);
            c2.Parameters.AddWithValue("cidade", fornecedor.Endereco.Cidade);
            c2.Parameters.AddWithValue("bairro", fornecedor.Endereco.bairro);
            c2.Parameters.AddWithValue("logradouro", fornecedor.Endereco.Logradouro);
            c2.Parameters.AddWithValue("complemento", fornecedor.Endereco.Complemento);
            c2.Parameters.AddWithValue("cep", fornecedor.Endereco.cep);

            c2.ExecuteNonQuery();
        }

        public void Update(FornecedorModel fornecedor)
        {
            string query = "UPDATE fornecedor F SET " +
                            "nomefantasia = @Nome, " +
                            "cnpj = @CNPJ, " +
                            "raazosocial = @RazaoSocial, " +
                            "email = @email, " +
                            "estado = @estado, " +
                            "cidade = @cidade, " +
                            "bairro = @bairro, " +
                            "logradouro = @logradouro, " +
                            "complemento = @complemento, " +
                            "cep = @cep " +
                            "WHERE idfornecedor = @ID;" +

                            "UPDATE telefone T SET " +
                            "telefone = @telefone " +
                            "WHERE T.idtelefone = (SELECT F.idtelefonefornecedor FROM fornecedor F WHERE F.idfornecedor = @ID);";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", fornecedor.NomeFantasia);
            c2.Parameters.AddWithValue("RazaoSocial", fornecedor.razaoSocial);
            c2.Parameters.AddWithValue("CNPJ", fornecedor.cnpj);
            c2.Parameters.AddWithValue("email", fornecedor.Email);
            c2.Parameters.AddWithValue("telefone", fornecedor.Telefone);
            c2.Parameters.AddWithValue("estado", fornecedor.Endereco.Estado);
            c2.Parameters.AddWithValue("cidade", fornecedor.Endereco.Cidade);
            c2.Parameters.AddWithValue("bairro", fornecedor.Endereco.bairro);
            c2.Parameters.AddWithValue("logradouro", fornecedor.Endereco.Logradouro);
            c2.Parameters.AddWithValue("complemento", fornecedor.Endereco.Complemento);
            c2.Parameters.AddWithValue("cep", fornecedor.Endereco.cep);

            c2.ExecuteNonQuery();
        }


        public void Delete(FornecedorModel fornecedor)
        {
            string query = "DELETE FROM fornecedor WHERE idfornecedor = @ID";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", fornecedor.idFornecedor);

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