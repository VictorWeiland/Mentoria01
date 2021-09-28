using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Endereco
    {
        public Endereco(string logradouro, string cep, string cidade, string estado)
        {

            Logradouro = logradouro.validaStringVazia();
            CEP = cep.validaStringVazia();
            Cidade = cidade.validaStringVazia();
            Estado = estado.validaStringVazia();
        }

        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

    }
}
