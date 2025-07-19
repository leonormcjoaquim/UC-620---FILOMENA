using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_620.models
{
    internal class User
    {
        public string nome {  get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int idade { get; set; }
        public int altura { get; set; }
        public double peso { get; set; }
        public List<Marcacao> Marcacao { get; set; }
        public List<Alimentacao> Alimentacao { get; set; }
        public List<Exercicio> Exercicio { get; set; }

    }
}
