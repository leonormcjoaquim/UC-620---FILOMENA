using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_620.utils;
using Projeto_620.models;
using Projeto_620.FORMS;

namespace Projeto_620.models
{
    internal class Exercicio
    {

        public string Nome { get; set; }
        public TipoTreino Tipo { get; set; }
        public int Duracao { get; set; }
        public int CaloriasQueimadas { get; set; }
        public DateTime Data {  get; set; }

        public Exercicio(string nomeTreino, TipoTreino tipoExercicio, int duracaoExercicio, int caloriasQueimadas, DateTime dataTreino) 
        { 
            Nome = nomeTreino;
            Tipo = tipoExercicio;
            Duracao = duracaoExercicio;
            CaloriasQueimadas = caloriasQueimadas;
            Data = dataTreino;
        }

        public bool MetaCalorias (int metaCalorias)
        {
            int calorias = this.CaloriasQueimadas;
            if (metaCalorias <= calorias)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Nome} - {Tipo} | {Duracao} min | {CaloriasQueimadas} kcal quemimadas na data {Data.ToShortDateString().ToString()}";
        }

    }
}
