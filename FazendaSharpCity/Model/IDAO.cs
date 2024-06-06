using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FazendaSharpCity.Model
{
    internal interface IDAO
    {

        public void Insert()
        {
            throw new NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable Search()
        {
            throw new NotImplementedException();
        }

        public EnderecoModel SearchEndereco()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable List()
        {
            throw new NotImplementedException();
        }

        private void Connect(string host, string port, string database, string user, string pass)
        {
            throw new NotImplementedException();
        }

        private void Disconnect()
        {
            throw new NotImplementedException();
        }
    }
}