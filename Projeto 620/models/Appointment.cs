using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_620.models
{
    internal class Appointment : Marcacao
    {

        public Appointment(string tipo, DateTime data, string especialidade)
        : base(tipo, data, especialidade) { }

        public override void marcarConsulta()
        {
            MessageBox.Show("Consulta com Especialista Marcada com Sucesso");
        }
        public override string ToString()
        {
            return $"{TipoMarcacao} - {EspecialidadeMarcacao} em {DataMarcacao:dd/MM/yyyy}";
        }
    }
}
