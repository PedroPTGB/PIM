﻿using Npgsql;
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
                string query = "SELECT idcliente, nome, cpf, dtnascimento, email, telefone FROM cliente C INNER JOIN telefone T ON C.idtelefonecliente = T.idtelefone WHERE C.idcliente = @ID ORDER BY C.idcliente ;";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

                c2.Parameters.AddWithValue("ID", cliente.IdCliente);

                System.Data.DataTable table = new System.Data.DataTable();
                da.Fill(table);

                return table;
            }
            else
            {
                string query = "SELECT idcliente, nome, cpf, dtnascimento, email, telefone FROM cliente C INNER JOIN telefone T ON C.idtelefonecliente = T.idtelefone WHERE C.nome ILIKE ANY (ARRAY[@Nome, @Nome2, @Nome3]) ORDER BY C.idcliente;";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

                c2.Parameters.AddWithValue("Nome", "%"+cliente.Nome+"%");
                c2.Parameters.AddWithValue("Nome2", cliente.Nome + "%");
                c2.Parameters.AddWithValue("Nome3", "%" + cliente.Nome);


                System.Data.DataTable table = new System.Data.DataTable();
                da.Fill(table);

                return table;
            }


        }
        public ClientePFModel SearchCompleto(ClientePFModel cliente)
        {
            ClientePFModel c = new ClientePFModel();

            string query = "SELECT idcliente, nome, cpf, cnpj, dtnascimento, email, tipopessoa, sexo, telefone FROM cliente C INNER JOIN telefone T ON C.idtelefonecliente = T.idtelefone WHERE C.idcliente = @ID;";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            c2.Parameters.AddWithValue("ID", cliente.IdCliente);

            NpgsqlDataReader reader = c2.ExecuteReader();

            while (reader.Read())
            {
                c.IdCliente = (int)reader[0];
                c.Nome = (string)reader[1];
                if (!string.IsNullOrEmpty((string)reader[2]))
                    c.Cpf = (string)reader[2];
                else
                    c.Cpf = "";
                //if (!string.IsNullOrEmpty((string)reader[3]))
                if (reader[3] != null && reader[3] != DBNull.Value)
                    c.Cnpj = (string)reader[3];
                else
                    c.Cnpj = "";

                c.DtNasc = (DateTime)reader[4];

                if (!string.IsNullOrEmpty((string)reader[5]))
                    c.Email = (string)reader[5];
                else
                    c.Email = "";
                c.TipoPessoa = (bool)reader[6];
                c.Sexo = (string)reader[7];

                if (!string.IsNullOrEmpty((string)reader[8]))
                    c.Telefone = (string)reader[8];
                else
                    c.Telefone = "";
            }

            reader.Close();

            return c;
        }

        public EnderecoModel SearchEndereco(ClientePFModel cliente)
        {
            EnderecoModel endereco = new EnderecoModel();
            string query = "SELECT cidade, bairro, logradouro, complemento, estado, cep, numero FROM cliente WHERE idcliente = @ID";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);
            c2.Parameters.AddWithValue("ID", cliente.IdCliente);
            
            NpgsqlDataReader reader = c2.ExecuteReader();

            while (reader.Read())
            {
                endereco.Cidade = (string)reader[0];
                endereco.bairro = (string)reader[1];
                endereco.Logradouro = (string)reader[2];
                endereco.Complemento = (string)reader[3];
                endereco.Estado = (string)reader[4];
                endereco.cep = (string)reader[5];
                endereco.num = (int)reader[6];
            }

            reader.Close();


            return endereco;
        }
        
        public void Insert(ClientePFModel cliente)
        {
            string query =  "INSERT INTO telefone (telefone) VALUES (@telefone);" +
                            "INSERT INTO cliente (nome, CPF, dtnascimento, email, estado, cidade, bairro, logradouro, complemento, cep, numero, sexo, tipopessoa, idtelefonecliente) " +
                            "VALUES (@Nome, @CPF, @DtNasc, @email, @estado, @cidade, @bairro, @logradouro, @complemento, @cep, @numero, @sexo, @tipopessoa, (SELECT idtelefone FROM telefone T WHERE T.telefone = @telefone));";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", cliente.Nome);
            c2.Parameters.AddWithValue("CPF", cliente.Cpf);
            c2.Parameters.AddWithValue("dtNasc", cliente.DtNasc);
            c2.Parameters.AddWithValue("email", cliente.Email);
            c2.Parameters.AddWithValue("telefone", cliente.Telefone);
            c2.Parameters.AddWithValue("estado", cliente.Endereco.Estado);
            c2.Parameters.AddWithValue("cidade", cliente.Endereco.Cidade);
            c2.Parameters.AddWithValue("bairro", cliente.Endereco.bairro);
            c2.Parameters.AddWithValue("logradouro", cliente.Endereco.Logradouro);
            c2.Parameters.AddWithValue("complemento", cliente.Endereco.Complemento);
            c2.Parameters.AddWithValue("cep", cliente.Endereco.cep);
            c2.Parameters.AddWithValue("numero", cliente.Endereco.num);
            c2.Parameters.AddWithValue("sexo", cliente.Sexo);
            c2.Parameters.AddWithValue("tipopessoa", cliente.TipoPessoa);

            c2.ExecuteNonQuery();
        }

        public void Update(ClientePFModel cliente)
        {
            string query =  "UPDATE cliente SET " +
                            "nome = @Nome, " +
                            "cpf = @CPF, " +
                            "cnpj = @cnpj, " +
                            "dtnascimento = @dtNasc, " +
                            "email = @email, " +
                            "estado = @estado, " +
                            "cidade = @cidade, " +
                            "bairro = @bairro, " +
                            "logradouro = @logradouro, " +
                            "complemento = @complemento, " +
                            "numero = @numero, " +
                            "cep = @cep, " +
                            "tipopessoa = @tipopessoa, " +
                            "sexo = @sexo " +
                            "WHERE idcliente = @ID;" +

                            "UPDATE telefone T SET " +
                            "telefone = @telefone " +
                            "WHERE T.idtelefone = (SELECT idtelefonecliente FROM cliente C WHERE C.idcliente = @ID);";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", cliente.IdCliente);
            c2.Parameters.AddWithValue("Nome", (string)cliente.Nome);
            c2.Parameters.AddWithValue("CPF", (string)cliente.Cpf);
            c2.Parameters.AddWithValue("cnpj", (string)cliente.Cnpj);
            c2.Parameters.AddWithValue("dtNasc", cliente.DtNasc);
            c2.Parameters.AddWithValue("email", cliente.Email);
            c2.Parameters.AddWithValue("telefone", cliente.Telefone);
            c2.Parameters.AddWithValue("estado", cliente.Endereco.Estado);
            c2.Parameters.AddWithValue("cidade", cliente.Endereco.Cidade);
            c2.Parameters.AddWithValue("bairro", cliente.Endereco.bairro);
            c2.Parameters.AddWithValue("logradouro", cliente.Endereco.Logradouro);
            c2.Parameters.AddWithValue("complemento", cliente.Endereco.Complemento);
            c2.Parameters.AddWithValue("cep", cliente.Endereco.cep);
            c2.Parameters.AddWithValue("numero", cliente.Endereco.num);
            c2.Parameters.AddWithValue("sexo", cliente.Sexo);
            c2.Parameters.AddWithValue("tipopessoa", cliente.TipoPessoa);

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
            string query = "SELECT idcliente, nome, cpf, cnpj, dtnascimento, email, telefone FROM cliente C INNER JOIN telefone T ON C.idtelefonecliente = T.idtelefone ORDER BY idcliente;";
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
