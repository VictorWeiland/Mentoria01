using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public static class Validacoes
    {
        public static string validaStringVazia(this string texto)
        {
            return string.IsNullOrWhiteSpace(texto) ?
                            throw new Exception("Porpriedade deve estar preenchida.")
                            : texto;
        }
    }
}
