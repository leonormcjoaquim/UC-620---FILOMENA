using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_620.utils;

namespace Projeto_620.models
{
    internal class Alimentacao
    {
        public string Nome { get; set; }
        public int Calorias { get; set; }
        public TipoRefeicao TipoRefeicao { get; set; }
        public DateTime Data_Comida { get; set; }

        public Alimentacao(string nome, int calorias, TipoRefeicao tipoRefeicao)
        {
            Nome = nome;
            Calorias = calorias;
            TipoRefeicao = tipoRefeicao;
            Data_Comida = DateTime.Now;
        }

        public void AtualizarCalorias(int novasCalorias)
        {
            Calorias = novasCalorias;
            Console.WriteLine($"Calorias atualizadas para {Calorias} kcal.");
        }

        public override string ToString()
        {
            return $"{this.TipoRefeicao}: {Nome} - {Calorias} kcal em {Data_Comida.ToShortDateString()} às {Data_Comida.ToShortTimeString()}";
        }
    }
}
