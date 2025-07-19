using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_620.models
{
    internal class TreinoPT : Marcacao
    {
        public TreinoPT(string tipo, DateTime data, string especialidade)
<<<<<<< HEAD
        : base(tipo, data, especialidade) { }
        
=======
         : base(tipo, data, especialidade)
        {
        }

>>>>>>> TestarAntesDeEnviar
        public override void marcarConsulta()
        {
            MessageBox.Show("Consulta com PT Marcada com Sucesso");
        }

        public override string ToString()
        {
            return $"{TipoMarcacao} - {EspecialidadeMarcacao} em {DataMarcacao:dd/MM/yyyy}";
        }
    }
}
