using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class FuncionarioDAO : IDAO
    {
        public NpgsqlConnection Connection { get; set; } = null;
        public FuncionarioDAO(string host, string port, string database, string user, string pass)
        {
            Connect(host, port, database, user, pass);
        }

        public System.Data.DataTable List()
        {
            string query = "SELECT idfuncionario, nome, cpf, dtnascimento, email, telefone FROM funcionario F INNER JOIN telefone T ON F.idtelefonefuncionario = T.idtelefone ORDER BY idfuncionario;";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);
            return table;
        }
        public System.Data.DataTable Search(FuncionarioModel funci)
        {
            if (funci.Nome == null)
            {
                string query = "SELECT idfuncionario, nome, cpf, dtnascimento, email, telefone FROM funcionario F INNER JOIN telefone T ON F.idtelefonefuncionario = T.idtelefone ORDER BY idfuncionario ;";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

                c2.Parameters.AddWithValue("ID", funci.idFuncionario);

                System.Data.DataTable table = new System.Data.DataTable();
                da.Fill(table);

                return table;
            }
            else
            {
                string query = "SELECT idcliente, nome, cpf, dtnascimento, email, telefone FROM funcionario F INNER JOIN telefone T ON F.idtelefonefuncionario = T.idtelefone WHERE F.nome ILIKE ANY (ARRAY[@Nome, @Nome2, @Nome3]) ORDER BY F.idfuncionario;";

                NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

                c2.Parameters.AddWithValue("Nome", "%" + funci.Nome + "%");
                c2.Parameters.AddWithValue("Nome2", funci.Nome + "%");
                c2.Parameters.AddWithValue("Nome3", "%" + funci.Nome);


                System.Data.DataTable table = new System.Data.DataTable();
                da.Fill(table);

                return table;
            }
        }

        public FuncionarioModel SearchCompleto(FuncionarioModel funcionario)
        {
            FuncionarioModel f = new FuncionarioModel();

            string query = "SELECT idfuncionario, nome, cpf, dtnascimento, email, login, senha, gerente, telefone FROM funcionario F INNER JOIN telefone T ON F.idtelefonefunicionario = T.idtelefone WHERE F.idfuncionario = @ID;";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            c2.Parameters.AddWithValue("ID", funcionario.idFuncionario);

            NpgsqlDataReader reader = c2.ExecuteReader();

            while (reader.Read())
            {
                f.idFuncionario = (int)reader[0];
                f.Nome = (string)reader[1];
                f.cpf = (string)reader[2];
                f.dtNasc = (DateTime)reader[3];
                
                if (!string.IsNullOrEmpty((string)reader[4]))
                    f.Email = (string)reader[4];
                else
                    f.Email = "";
                
                f.login = (string)reader[5];
                f.senha = (string)reader[6];
                f.gerente = (bool)reader[7];
                
                if (!string.IsNullOrEmpty((string)reader[8]))
                    f.Telefone = (string)reader[8];
                else
                    f.Telefone = "";
            }

            reader.Close();

            return f;
        }

        public EnderecoModel SearchEndereco(FuncionarioModel funci)
        {
            EnderecoModel endereco = new EnderecoModel();
            string query = "SELECT cidade, bairro, logradouro, complemento, estado, cep FROM funcionario WHERE idfuncionario = @ID";

            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);
            c2.Parameters.AddWithValue("ID", funci.idFuncionario);

            NpgsqlDataReader reader = c2.ExecuteReader();

            while (reader.Read())
            {
                endereco.Cidade = (string)reader[0];
                endereco.bairro = (string)reader[1];
                endereco.Logradouro = (string)reader[2];
                endereco.Complemento = (string)reader[3];
                endereco.Estado = (string)reader[4];
                endereco.cep = (string)reader[5];
            }

            reader.Close();


            return endereco;
        }

        public void Insert(FuncionarioModel funcionario)
        {
            string query = "INSERT INTO telefone (telefone) VALUES (@telefone);" +
                            "INSERT INTO funcionario (nome, CPF, dtnascimento, email, estado, cidade, bairro, logradouro, complemento, numero, cep, idtelefonefuncionario) " +
                            "VALUES (@Nome, @CPF, @DtNasc, @email, @estado, @cidade, @bairro, @logradouro, @complemento, @numero, @cep, (SELECT idtelefone FROM telefone T WHERE T.telefone = @telefone));";
            
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", funcionario.Nome);
            c2.Parameters.AddWithValue("CPF", funcionario.cpf);
            c2.Parameters.AddWithValue("dtNasc", funcionario.dtNasc);
            c2.Parameters.AddWithValue("email", funcionario.Email);
            c2.Parameters.AddWithValue("telefone", funcionario.Telefone);
            c2.Parameters.AddWithValue("cargo", funcionario.gerente);
            c2.Parameters.AddWithValue("login", funcionario.login);
            c2.Parameters.AddWithValue("senha", funcionario.senha);
            
            c2.Parameters.AddWithValue("estado", funcionario.Endereco.Estado);
            c2.Parameters.AddWithValue("cidade", funcionario.Endereco.Cidade);
            c2.Parameters.AddWithValue("bairro", funcionario.Endereco.bairro);
            c2.Parameters.AddWithValue("logradouro", funcionario.Endereco.Logradouro);
            c2.Parameters.AddWithValue("complemento", funcionario.Endereco.Complemento);
            c2.Parameters.AddWithValue("numero", funcionario.Endereco.Numero);
            c2.Parameters.AddWithValue("cep", funcionario.Endereco.cep);

            c2.ExecuteNonQuery();
        }

        public void Update(FuncionarioModel funcionario)
        {
            string query = "UPDATE funcionario SET " +
                            "nome = @Nome, " +
                            "cpf = @CPF, " +
                            "dtnascimento = @dtNasc, " +
                            "email = @email, " +
                            "estado = @estado, " +
                            "cidade = @cidade, " +
                            "bairro = @bairro, " +
                            "logradouro = @logradouro, " +
                            "complemento = @complemento, " +
                            "cep = @cep " +
                            "WHERE idfuncionario = @ID;" +

                            "UPDATE telefone T SET " +
                            "telefone = @telefone " +
                            "WHERE T.idtelefone = (SELECT idtelefonefuncionario FROM funcionario F WHERE F.idfuncionario = @ID);";


            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("Nome", funcionario.Nome);
            c2.Parameters.AddWithValue("CPF", funcionario.cpf);
            c2.Parameters.AddWithValue("dtNasc", funcionario.dtNasc);
            c2.Parameters.AddWithValue("email", funcionario.Email);
            c2.Parameters.AddWithValue("telefone", funcionario.Telefone);
            c2.Parameters.AddWithValue("cargo", funcionario.gerente);
            c2.Parameters.AddWithValue("login", funcionario.login);
            c2.Parameters.AddWithValue("senha", funcionario.senha);

            c2.Parameters.AddWithValue("estado", funcionario.Endereco.Estado);
            c2.Parameters.AddWithValue("cidade", funcionario.Endereco.Cidade);
            c2.Parameters.AddWithValue("bairro", funcionario.Endereco.bairro);
            c2.Parameters.AddWithValue("logradouro", funcionario.Endereco.Logradouro);
            c2.Parameters.AddWithValue("complemento", funcionario.Endereco.Complemento);
            c2.Parameters.AddWithValue("cep", funcionario.Endereco.cep);

            c2.ExecuteNonQuery();
        }

        public void Delete(FuncionarioModel funcionario)
        {
            string query = "DELETE FROM Pessoas WHERE ID = @ID";
            NpgsqlCommand c2 = new NpgsqlCommand(query, Connection);

            c2.Parameters.AddWithValue("ID", funcionario.idFuncionario);

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
