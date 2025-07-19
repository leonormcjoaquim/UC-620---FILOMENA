using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_620.utils;

namespace Projeto_620.models
{
    internal abstract class Marcacao
    {
        private string Tipo_marcacao;
        private DateTime Data_marcacao;
        private string Especialidade;

        public Marcacao() { }
        public Marcacao(string Tipo_marcacao, DateTime Data_marcacao)
        {
            this.Tipo_marcacao = Tipo_marcacao;
            this.Data_marcacao = Data_marcacao;
        }

        public Marcacao(string Tipo_marcacao, DateTime Data_marcacao, string Especialidade) { 
            this.Tipo_marcacao = Tipo_marcacao;
            this.Data_marcacao = Data_marcacao;
            this.Especialidade = Especialidade;
        }

        public abstract void marcarConsulta();
    }
}
