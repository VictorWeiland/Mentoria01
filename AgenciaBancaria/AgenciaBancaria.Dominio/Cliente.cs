using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public Cliente(string nome, string cpf,string rg, Endereco endereco)
        {

            Nome = nome.validaStringVazia();
            CPF = cpf.validaStringVazia();
            RG = rg.validaStringVazia();
            Endereco = endereco ?? throw new Exception("Endereco deve ser informado.");
      
        }

        

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }

        public Endereco Endereco { get; private set; }

    }
}
