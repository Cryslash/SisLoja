using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLoja
{
    public class modeloCliente
    {
        int id;
        string nome, cpf, fone, whatsapp, email, cep, rua, bairro, cidade, uf;
        DateTime data;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Nome 
        {
            get { return nome; }
            set { nome = value; } 
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }
        public string Whatsapp
        {
            get { return whatsapp; }
            set { whatsapp = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
    }
}
