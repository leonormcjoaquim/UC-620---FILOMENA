using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_620.models
{
    internal class Exercicio
    {

        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Duracao { get; set; }
        public int CaloriasQueimadas { get; set; }
        public DateTime Data {  get; set; }

        public Exercicio(string nomeTreino, string tipoExercicio, int duracaoExercicio, int caloriasQueimadas, DateTime dataTreino) 
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
            return $"{Nome} - {Tipo} | {Duracao} min | {CaloriasQueimadas} kcal quemimadas na data {Data.ToString()}";
        }

    }
}
