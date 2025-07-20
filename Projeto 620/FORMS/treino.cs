using Projeto_620.FORMS;
using Projeto_620.models;
using Projeto_620.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_620.FORMS
{
    public partial class treino : Form
    {
        public treino()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            login Login = new login();
            Login.Show();
        }

        bool sidebarExpand = false;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pn_opcoes.Width -= 10;
                if (pn_opcoes.Width <= 45)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                pn_opcoes.Width += 10;
                if (pn_opcoes.Width >= 240)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Cursor = Cursors.Hand;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form inicio = new paginaInicial();
            inicio.Show();
            this.Close();
        }

        private void btn_appoitments_Click(object sender, EventArgs e)
        {
            Form consulta = new consultas();
            consulta.Show();
            this.Close();
        }

        private void btn_workouts_Click(object sender, EventArgs e)
        {
            Form workout = new treino();
            workout.Show();
            this.Close();
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            Form comida = new alimentacao();
            comida.Show();
            this.Close();
        }

        private void btn_motivacao_Click(object sender, EventArgs e)
        {
            Form motiva = new motivacao();
            motiva.Show();
            this.Close();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);
            GlobalUtils.GuardarXML(utilizador);
            Form log = new login();
            log.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);
            GlobalUtils.GuardarXML(utilizador);
            Application.Exit();
        }

        private void form_Load(object sender, EventArgs e)
        {
            cbb_tipoTreino.DataSource = Enum.GetValues(typeof(TipoTreino));
            AtualizarListaTreinos();

        }

        private void btn_inserirTreino_Click(object sender, EventArgs e)
        {
            if (cbb_tipoTreino.SelectedIndex == -1 )
            {
                MessageBox.Show("Erro! Tem de ter o tipo de treino selecionado");
                cbb_tipoTreino.SelectedIndex = -1;
                return;
            }

            string nomeTreino = tb_nomeTreino.Text;
            if (string.IsNullOrEmpty(nomeTreino))
            {
                MessageBox.Show("Erro! O nome de treino não pode estar vazio!");
                return;
            }


            if (!int.TryParse(tb_duracaoTreino.Text, out int duracaoTreino) || duracaoTreino <= 0)
            {
                MessageBox.Show("Erro! Introduza uma duração válida.");
                return;
            }

            if (!int.TryParse(tb_caloriasQueimadas.Text, out int caloriasQueimadas) || caloriasQueimadas <= 0)
            {
                MessageBox.Show("Erro! Introduza um valor de calorias válido.");
                return;
            }

            TipoTreino tipoSelecionado = (TipoTreino)cbb_tipoTreino.SelectedItem;

            Exercicio treino = new Exercicio(nomeTreino, tipoSelecionado, duracaoTreino, caloriasQueimadas, DateTime.Now);

            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);

            utilizador.Exercicios.Add(treino);

            lb_listaTreino.Items.Clear();
            lb_listaTreino.Items.Add(treino);


            // -- Metodo Inicial sem utilização das classes --
            //XDocument doc = XDocument.Load(GlobalUtils.caminho);

            //GlobalUtils.username = "root"; //ALTERAR PRECISAMOS DE UMA GLOBAL VARIABLE

            //XElement user = doc.Descendants("user").FirstOrDefault(x => x.Element("username")?.Value == GlobalUtils.username);

            //if (user == null)
            //{
            //    MessageBox.Show("Utilizador não encontrado!");
            //    return;
            //}

            //XElement treinos = user.Element("Treinos");
            //if (treinos == null)
            //{
            //    treinos = new XElement("Treinos");
            //    user.Add(treinos);
            //}



            //XElement novoTreino = new XElement("Treino",
            //        new XElement("NomeTreino", nomeTreino),
            //        new XElement("TipoExercicio", tipoSelecionado.ToString()),
            //        new XElement("Duracao", duracaoTreino),
            //        new XElement("CaloriasQueimadas", caloriasQueimadas),
            //        new XElement("Data", DateTime.Now.ToString("s"))
            //    );

            //treinos.Add(novoTreino);


            //doc.Save(GlobalUtils.caminho);

            MessageBox.Show("Treino inserido com sucesso!");

            AtualizarListaTreinos();

            tb_nomeTreino.Clear();
            tb_duracaoTreino.Clear();
            tb_caloriasQueimadas.Clear();
            cbb_tipoTreino.SelectedIndex = -1;
            pb_metaTreino.Increment(duracaoTreino);
        }

        private void AtualizarListaTreinos()
        {

            // -- Metodo Inicial sem utilização das classes --
            //lb_listaTreino.Items.Clear();

            //GlobalUtils.username = "root";

            //XDocument doc = XDocument.Load(GlobalUtils.caminho);

            //var user = doc.Root.Elements("user")
            //                  .FirstOrDefault(x => x.Element("username")?.Value == GlobalUtils.username);

            //var treinos = user.Element("Treinos");

            //if (treinos == null)
            //{
            //    treinos = new XElement("Treinos");
            //    user.Add(treinos);
            //    doc.Save(GlobalUtils.caminho); 
            //}
            //if (!treinos.Elements("Treino").Any())
            //{
            //    MessageBox.Show("Sem treinos para mostrar, vamos a isso!");
            //    return;
            //}

            //foreach (var trei in treinos.Elements("Treino"))
            //{
            //    string nomeTreino = (string)trei.Element("NomeTreino");
            //    string tipoExercicio = (string)trei.Element("TipoExercicio");
            //    string duracao = (string)trei.Element("Duracao");
            //    string calorias = (string)trei.Element("CaloriasQueimadas");
            //    string data = (string)trei.Element("Data");

            //    string linha = $"{nomeTreino} ({tipoExercicio}) - {calorias} kcal queimadas em {duracao} min, às {data}h";

            //    lb_listaTreino.Items.Add(linha);

            //}

            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);

            lb_listaTreino.Items.Clear();

            foreach (Exercicio treino in utilizador.Exercicios)
            {
                lb_listaTreino.Items.Add(treino);
            }
        }

        private void pb_menu_Click_1(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btn_inserirTreino_MouseHover(object sender, EventArgs e)
        {
            btn_inserirTreino.Cursor = Cursors.Hand;
        }

        private void pb_menu_MouseHover(object sender, EventArgs e)
        {
            pb_menu.Cursor = Cursors.Hand;
        }

        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            btn_home.Cursor = Cursors.Hand;
        }

        private void btn_appoitments_MouseHover(object sender, EventArgs e)
        {
            btn_appoitments.Cursor = Cursors.Hand;
        }

        private void btn_workouts_MouseHover(object sender, EventArgs e)
        {
            btn_workouts.Cursor = Cursors.Hand;
        }

        private void btn_food_MouseHover(object sender, EventArgs e)
        {
            btn_food.Cursor = Cursors.Hand;
        }

        private void btn_motivacao_MouseHover(object sender, EventArgs e)
        {
            btn_motivacao.Cursor = Cursors.Hand;
        }

        private void bt_logout_MouseHover(object sender, EventArgs e)
        {
            bt_logout.Cursor = Cursors.Hand;
        }
    }

}
