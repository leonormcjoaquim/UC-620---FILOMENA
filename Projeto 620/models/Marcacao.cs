using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Projeto_620.utils;

namespace Projeto_620.models
{
    internal abstract class Marcacao
    {
        public string TipoMarcacao { get; set; }
        public DateTime DataMarcacao { get; set; }
        public string EspecialidadeMarcacao { get; set; }

        public Marcacao() { }

        public Marcacao(string tipoMarcacao, DateTime dataMarcacao, string especialidade)
        {
            TipoMarcacao = tipoMarcacao;
            DataMarcacao = dataMarcacao;
            EspecialidadeMarcacao = especialidade;
        }

        public abstract void marcarConsulta();
    }
}
