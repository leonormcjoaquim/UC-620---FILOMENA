using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_620.utils;

namespace Projeto_620.models
{
    internal class User
    {
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public List<Marcacao> Marcacao { get; set; } = new List<Marcacao>();
        public List<Alimentacao> Alimentacao { get; set; } = new List<Alimentacao>();
        public List<Exercicio> Exercicios { get; set; } = new List<Exercicio>();

        public User(string nome, string username, string password, string email, string sexo, int idade, double altura, double peso, List<Marcacao> marcacao, List<Alimentacao> alimentacao, List<Exercicio> exercicios)
        {
            Nome = nome;
            Username = username;
            Password = password;
            Email = email;
            Sexo = sexo;
            Idade = idade;
            Altura = altura;
            Peso = peso;
            Marcacao = marcacao;
            Alimentacao = alimentacao;
            Exercicios = exercicios;
        }

        public User(string nome, string username, string password, string email, string sexo, int idade, double altura, double peso)
        {
            Nome = nome;
            Username = username;
            Password = password;
            Email = email;
            Sexo = sexo;
            Idade = idade;
            Altura = altura;
            Peso = peso;
        }

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
            Exercicios.Add(exercicio);
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
