using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio26_Vetores
{
    internal class Estudante
    {
        public string Nome;
        public string Email;

        public Estudante(string nome, string email) 
        { 
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
