using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_620.models
{
    internal class TreinoPT : Marcacao
    {
        public TreinoPT(string tipo, DateTime data, string especialidade)
         : base(tipo, data, especialidade)
        {
        }

        public override void marcarConsulta()
        {
        }

        public override string ToString()
        {
            return $"{TipoMarcacao} - {EspecialidadeMarcacao} em {DataMarcacao:dd/MM/yyyy}";
        }
    }
}
