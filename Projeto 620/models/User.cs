using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_620.models
{
    internal class User
    {
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public int Altura { get; set; }
        public double Peso { get; set; }
        public List<Marcacao> Marcacao { get; set; }
        public List<Alimentacao> Alimentacao { get; set; }
        public List<Exercicio> Exercicio { get; set; }



        public bool Login(string username, string password)
        {
            return username == this.Username && password == this.Password;
        }

        public void MarcarConsulta(Marcacao novaMarcacao)
        {
            Marcacao.Add(novaMarcacao);
            Console.WriteLine("Marcação feita com sucesso.");
        }

        public void AdicionarRefeicao(Alimentacao novaRefeicao)
        {
            Alimentacao.Add(novaRefeicao);
            Console.WriteLine("Refeição adicionada.");
        }

        public void AdicionarTreino(Exercicio exercicio)
        {
            Exercicio.Add(exercicio);
            Console.WriteLine("Treino adicionado.");
        }

        // VER COMO FAZER SENDO QUE TEMOS DE ENVIAR PARA UMA LISTBOX??? TODO:
        public string VerHistoricoTreino()
        {
            return "AQUI";
        }
        public string VerHistoricoConsulta()
        {
            return "AQUI";
        }

        public string VerHistoricoAlimentacao()
        {
            return "AQUI";
        }
    }
}
