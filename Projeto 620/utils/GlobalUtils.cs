using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_620.models;
using Projeto_620.FORMS;
using System.Runtime.Remoting;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;

namespace Projeto_620.utils
{
    internal class GlobalUtils
    {

        public static List<User> users = new List<User>();


        public static string username = "";
        public static string caminho = @"C:\cometudoperdetudo\users.xml";

        public static void GuardarXML(User utilizador)
        {
            string casofalhe = @"C:\cometudoperdetudo\users_temp.xml";
            XDocument doc = XDocument.Load(caminho);
            var todosDados = doc.Root.Elements("user").FirstOrDefault(u =>(string)u.Element("Dados")?.Element("username") == username);

            doc.Save(casofalhe);
            todosDados?.Remove();

            XElement novoUser = new XElement("user",
            // -- DADOS --
            new XElement("Dados",
            new XElement("username", utilizador.Username),
            new XElement("nome", utilizador.Nome),
            new XElement("password", utilizador.Password),
            new XElement("sexo", utilizador.Sexo),
            new XElement("calorias", utilizador.Calorias),
            new XElement("email", utilizador.Email),
            new XElement("idade", utilizador.Idade),
            new XElement("altura", utilizador.Altura),
            new XElement("peso", utilizador.Peso)
        ),

        // -- CONSULTAS / MARCACOES --
        new XElement("Consultas",
            from m in utilizador.Marcacao
            select new XElement("Consulta",
                new XElement("TipoMarcacao", m.TipoMarcacao),
                new XElement("DataMarcacao", m.DataMarcacao.ToString("yyyy-MM-dd")),
                new XElement("Especialidade", m.EspecialidadeMarcacao)
            )
        ),

        // -- TREINOS --
        new XElement("Treinos",
            from t in utilizador.Exercicios
            select new XElement("Treino",
                new XElement("NomeTreino", t.Nome),
                new XElement("TipoExercicio", t.Tipo.ToString()),
                new XElement("Duracao", t.Duracao),
                new XElement("CaloriasQueimadas", t.CaloriasQueimadas),
                new XElement("Data", t.Data.ToString("s")) 
            )
),

        // -- ALIMENTAÇÃO --
        new XElement("Alimentacoes",
            from a in utilizador.Alimentacao
            select new XElement("refeicao",
                new XElement("NomeComida", a.Nome),
                new XElement("TipoRefeicao", a.TipoRefeicao.ToString()),
                new XElement("Calorias", a.Calorias),
                new XElement("Data", a.Data_Comida.ToString("s"))
            )));

            // Adicionar novo utilizador ao XML
            doc.Root.Add(novoUser);

            // Gravar
            doc.Save(casofalhe);

            // Copiar temp para novo
            File.Copy(casofalhe, caminho, overwrite: true);

            // Apagar Temporario
            File.Delete(casofalhe);


            MessageBox.Show("Dados gravados com sucesso!");

        }
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
