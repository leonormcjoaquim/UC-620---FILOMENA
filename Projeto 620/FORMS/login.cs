using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ReaLTaiizor.Controls;
using Projeto_620.FORMS;
using Projeto_620.models;
using Projeto_620.utils;
using System.IO;
using System.Media;

namespace Projeto_620.FORMS
{
    public partial class login : Form
    {
        public SoundPlayer player = new SoundPlayer(Properties.Resources.dry_fart);
        public login()
        {
            InitializeComponent();
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            this.Hide();
            paginaInicial registar = new paginaInicial();
            registar.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            paginaInicial PaginaInicial = new paginaInicial();
            PaginaInicial.Show();
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {
            if (MinimizeBox)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
                Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender)
        {
            if (checkBox1.Checked)
            {
                tb_password.Password = false;
            }
            else
            {
                tb_password.Password = true;
            }
        }

        private void btn_registar_Click_1(object sender, EventArgs e)
        {
            Form registar = new registar();
            registar.Show();
        }

        private void btn_login_MouseClick(object sender, MouseEventArgs e)
        {
            //// PARA TESTES
            ////melhorar esta textbox
            //MessageBox.Show("Login efetuado com sucesso!");
            //Form paginaInicial = new paginaInicial();
            //paginaInicial.Show();
            //this.Hide();

            tb_username.Focus();
            string username = tb_username.TextButton; // textButton devido à framework que estamos a usar não ter a propriedade text para este elemento
            string password = tb_password.TextButton;

            // Verifica se um dos campos está vazio
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                //melhorar esta textbox
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                tb_username.TextButton = string.Empty;
                tb_password.TextButton = string.Empty;

                return;
            }

            XDocument doc;

            if (!File.Exists(GlobalUtils.caminho))
            {
                doc = new XDocument(new XElement("users"));
                // grava o novo ficheiro com raiz válida
                doc.Save(GlobalUtils.caminho); 
            }
            else
            {
                // vê todos os users no ficheiro xml e compara se existe ou nao aquele login 
                doc = XDocument.Load(GlobalUtils.caminho); 
            }

            
            bool userExists = doc.Root.Elements("user").Descendants("Dados").Any(x =>x.Element("username")?.Value == username &&x.Element("password")?.Value == password);

            GlobalUtils.username = username;

            // if userexists == true
            if (!userExists)
            {
                MessageBox.Show("Utilizador ou password incorretos. Tente novamente.", "Erro!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tb_username.Focus();
                tb_username.TextButton = string.Empty;
                tb_password.TextButton = string.Empty;
                return;
            }
            else
            {
                player.Play();
                MessageBox.Show("Login efetuado com sucesso!", "Eureka", MessageBoxButtons.OK, MessageBoxIcon.None);
                XmlToList();
                Form paginaInicial = new paginaInicial();
                paginaInicial.Show();
                this.Hide();
            }


        }

        public void XmlToList()
        {
            XDocument doc = XDocument.Load(GlobalUtils.caminho);

            var dados = doc.Root.Elements("user").Select(x => x.Element("Dados")).FirstOrDefault(d => d != null && (string)d.Element("username") == GlobalUtils.username);

            var user = doc.Root.Elements("user").FirstOrDefault(x => (string)x.Element("Dados")?.Element("username") == GlobalUtils.username);



            string username = (string)dados.Element("username");
            string nome = (string)dados.Element("nome");
            string password = (string)dados.Element("password");
            string email = (string)dados.Element("email");
            string sexo = (string)dados.Element("sexo");
            int caloriasObjetivo = (int)dados.Element("calorias");
            int idade = (int)dados.Element("idade");
            double altura = (double)dados.Element("altura");
            double peso = (double)dados.Element("peso");

            // -- Consultas --
            List<Marcacao> marcacoes = new List<Marcacao>();
            var consultas = user.Element("Consultas")?.Elements("Consulta");

            if (consultas != null)
            {
                foreach (var consulta in consultas)
                {
                    string tipo = (string)consulta.Element("TipoMarcacao");
                    DateTime data = DateTime.Parse((string)consulta.Element("DataMarcacao"));
                    string especialidade = (string)consulta.Element("Especialidade");

                    Marcacao novaMarcacao = null;

                    switch (tipo)
                    {
                        case "Especialista":
                            novaMarcacao = new Appointment(tipo, data, especialidade);
                            break;

                        case "Treino_PT":  // para prevenir variantes
                            novaMarcacao = new TreinoPT(tipo, data, especialidade);
                            break;

                        default:
                            MessageBox.Show($"Tipo de marcação desconhecido: {tipo}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                    }

                    marcacoes.Add(novaMarcacao);
                }
            }

            // -- Alimentação --
            List<Alimentacao> alimentacoes = new List<Alimentacao>();
            var alimentos = user.Element("Alimentacoes")?.Elements();
            if (alimentos != null)
            {
                foreach (var refeicao in alimentos)
                {
                    string nomeComida = (string)refeicao.Element("NomeComida");
                    int calorias = int.Parse(refeicao.Element("Calorias").Value);
                    string tipoRefeicaoStr = (string)refeicao.Element("TipoRefeicao");
                    DateTime data = DateTime.Parse((string)refeicao.Element("Data"));

                    if (!Enum.TryParse(tipoRefeicaoStr, true, out TipoRefeicao tipoRefeicao))
                    {
                        MessageBox.Show($"Tipo de refeição desconhecido: {tipoRefeicaoStr}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    var ali = new Alimentacao(nomeComida, calorias, tipoRefeicao)
                    {
                        Data_Comida = data
                    };

                    alimentacoes.Add(ali);
                }
            }

            // ---------- Treinos ----------
            List<Exercicio> exercicios = new List<Exercicio>();
            var treinos = user.Element("Treinos")?.Elements("Treino");
            if (treinos != null)
            {
                foreach (var exercicio in treinos)
                {
                    string nomeTreino = (string)exercicio.Element("NomeTreino");
                    string tipoStr = (string)exercicio.Element("TipoExercicio");
                    int duracao = int.Parse(exercicio.Element("Duracao").Value);
                    int calorias = int.Parse(exercicio.Element("CaloriasQueimadas").Value);
                    DateTime data = DateTime.Parse((string)exercicio.Element("Data"));

                    if (!Enum.TryParse(tipoStr, true, out TipoTreino tipoTreino))
                    {
                        MessageBox.Show($"Tipo de treino desconhecido: {tipoStr}", "Erros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    exercicios.Add(new Exercicio(nomeTreino, tipoTreino, duracao, calorias, data));
                }
            }

            // CRIAR OBJETO USER

            User utilizador = new User(nome, username, password, email, sexo, caloriasObjetivo, idade, altura, peso, marcacoes, alimentacoes, exercicios);
            GlobalUtils.users.Add(utilizador);
        }

    }
}