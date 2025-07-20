using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_620.models;
using Projeto_620.FORMS;

namespace Projeto_620.utils
{
    internal class GlobalUtils
    {

        public static List<User> users = new List<User>();


        public static string username = "";
        public static string caminho = @"C:\cometudoperdetudo\users.xml";


    }

    public enum TipoMarcacao
    {
        Especialista,
        Treino_PT
    }

    public enum Especialidade
    {
        PersonalTrainer,
        Nutricionista,
        Fisioterapeuta,
        Endocrinologista,
        Psicologo,
        Cardiologista,
        Ortopedista
    }

    public enum TipoTreino
    {
        Cardio,
        Forca,
        HIIT,
        Flexibilidade,
        Funcional,
        Yoga,
        Pilates
    }

    public enum TipoRefeicao
    {
        PequenoAlmoco,
        Almoco,
        Jantar,
        Snack
    }


}
