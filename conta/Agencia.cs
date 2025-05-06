using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleconta
{
    class Agencia
    {
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public Banco Banco { get; set; }

        public Agencia(int numero, string cep, string telefone, Banco banco)
        {
            Numero = numero;
            CEP = cep;
            Telefone = telefone;
            Banco = banco;
        }
    }

}
