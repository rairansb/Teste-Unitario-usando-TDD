using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class ValidacoesStrig
    {
       public int ContarCaracteres(string texto)
         {
        if (texto == null)
        {
            throw new ArgumentNullException(nameof(texto), "O texto não pode ser nulo");
        }

        return texto.Length;
         }

        public int ContarCaracteresVazio(string texto){
            return texto.Length;
        }

        public int ContarCaracteresNulo(string texto) => texto?.Length ?? 0;


    }
}