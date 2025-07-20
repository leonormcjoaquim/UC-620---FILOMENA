using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< Updated upstream
=======
using System.Windows.Forms;
using Projeto_620.utils;
>>>>>>> Stashed changes

namespace Projeto_620.models
{
    internal class TreinoPT : Marcacao
    {
<<<<<<< Updated upstream
        public TreinoPT(string tipo, DateTime data, string especialidade)
         : base(tipo, data, especialidade)
        {
        }
=======
        public TreinoPT(string tipo, DateTime data, string especialidade): base(tipo, data, especialidade) { }
        
>>>>>>> Stashed changes

        public override void marcarConsulta()
        {
        }

        public override string ToString()
        {
            return $"{TipoMarcacao} - {EspecialidadeMarcacao} em {DataMarcacao:dd/MM/yyyy}";
        }
    }
}
