using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_620.models;

namespace Projeto_620.utils
{
    internal class GlobalUtils
    {

        public static List<User> users = new List<User>();
        public static List<Alimentacao> alimentos = new List<Alimentacao>();
        public static List<Exercicio> exercicios = new List<Exercicio>();
        public static List<Appointment> consultas = new List<Appointment>();
        public static List<TreinoPT> treinoPTs = new List<TreinoPT>();

    }

    public enum TipoMarcacao
    {

    }

    public enum Especialidade
    {

    }

    public enum TipoTreino
    {

    }

    public enum TipoRefeicao
    {
        
    }


}
