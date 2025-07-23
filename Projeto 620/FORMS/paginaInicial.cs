using Projeto_620.FORMS;
using Projeto_620.models;
using Projeto_620.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_620.FORMS
{
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {
            InitializeComponent();
            CarregarGraficoTreinos();
            EstilizarGrafico();
            lbl_ola.Text = "Olá " + GlobalUtils.username;
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);

            tb_nome.Text = utilizador.Nome;
            tb_idade.Text = utilizador.Idade.ToString();
            tb_altura.Text = utilizador.Altura.ToString();
            tb_peso.Text = utilizador.Peso.ToString();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            login Login = new login();
            Login.Show();
        }
        private void nightControlBox1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void pb_menu_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pb_menu_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pb_menu_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

        }

        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pn_opcoes.Width -= 10;
                lbl_ola.Location = new Point(lbl_ola.Location.X - 10, lbl_ola.Location.Y);
                if (pn_opcoes.Width <= 45)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                pn_opcoes.Width += 10;
                lbl_ola.Location = new Point(lbl_ola.Location.X + 10, lbl_ola.Location.Y);
                if (pn_opcoes.Width >= 240)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void pb_menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit_MouseHover_1(object sender, EventArgs e)
        {
            btn_exit.Cursor = Cursors.Hand;
        }
   
        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Cursor = Cursors.WaitCursor;
            Task.Delay(500);
            this.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            btn_home.Cursor = Cursors.Hand;
        }

        private void bt_logout_MouseHover(object sender, EventArgs e)
        {
            bt_logout.Cursor = Cursors.Hand;
        }

        private void bt_logout_MouseMove(object sender, MouseEventArgs e)
        {
            bt_logout.Cursor = Cursors.Hand;
        }

        private void btn_exit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_exit.Cursor = Cursors.Hand;
        }

        private void pb_menu_MouseHover_1(object sender, EventArgs e)
        {
            pb_menu.Cursor = Cursors.Hand;
        }

        private void btn_workouts_MouseHover(object sender, EventArgs e)
        {
            btn_workouts.Cursor = Cursors.Hand;
        }

        private void btn_food_MouseHover(object sender, EventArgs e)
        {
            btn_food.Cursor = Cursors.Hand;
        }

        private void btn_appoitments_MouseHover(object sender, EventArgs e)
        {
            btn_appoitments.Cursor = Cursors.Hand;
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
            GlobalUtils.soundPlayer.Play();
            GlobalUtils.GuardarXML(utilizador);
            Form log = new login();
            log.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);
            GlobalUtils.sairSemGuardar();
        }

        public void CarregarGraficoTreinos()
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);

            chartTreinos.Series.Clear();
            chartTreinos.ChartAreas.Clear();

            chartTreinos.ChartAreas.Add("MainArea");
            Series serie = new Series("Calorias")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            foreach (var treino in utilizador.Exercicios)
            {
                serie.Points.AddXY(treino.Nome, treino.CaloriasQueimadas);
            }

            chartTreinos.Titles.Add("Calorias Queimadas por Treino");
            chartTreinos.ChartAreas[0].AxisX.Title = "Treino";
            chartTreinos.ChartAreas[0].AxisY.Title = "Kcal";

            chartTreinos.Series.Add(serie);
        }

        public void EstilizarGrafico()
        {

            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);

            //Data de hoje
            DateTime hoje = DateTime.Today;

            // calcula o início da semana (segunda-feira)
            int diferencaDias = (int)hoje.DayOfWeek - 1;
            if (diferencaDias < 0) diferencaDias = 6; // caso seja domingo
            DateTime inicioSemana = hoje.AddDays(-diferencaDias);

            // fim da semana (domingo)
            DateTime fimSemana = inicioSemana.AddDays(6);

            var treinosDaSemana = utilizador.Exercicios.Where(x => x.Data.Date >= inicioSemana && x.Data.Date <= fimSemana);

            // Limpa estilos anteriores
            chartTreinos.Series.Clear();
            chartTreinos.ChartAreas.Clear();
            chartTreinos.Titles.Clear();
            chartTreinos.Legends.Clear();


            // Area grafico
            var area = new ChartArea("MainArea");
            area.BackColor = Color.Transparent;
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisX.MajorGrid.LineColor = Color.White;
            area.AxisY.MajorGrid.LineColor = Color.White;
            area.AxisX.LineColor = Color.White;
            area.AxisY.LineColor = Color.White;
            
            chartTreinos.ChartAreas.Add(area);

            var serie = new Series("Calorias")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.DeepSkyBlue,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White
            };

            foreach (var treino in treinosDaSemana)
            {
                
                serie.Points.AddXY(treino.Nome, treino.CaloriasQueimadas);
            }

            chartTreinos.Series.Add(serie);

            // Legenda
            var legenda = new Legend();
            legenda.ForeColor = Color.White;
            legenda.BackColor = Color.Transparent;
            chartTreinos.Legends.Add(legenda);

            // Título
            var titulo1 = new Title($"Calorias da Semana: {inicioSemana:dd/MM} a {fimSemana:dd/MM}");
            var titulo2 = new Title("Calorias Queimadas por Treino");
            titulo1.ForeColor = Color.White;
            titulo2.ForeColor = Color.White;
            chartTreinos.Titles.Add(titulo1);
            chartTreinos.Titles.Add(titulo2);

            // Fundo do gráfico
            chartTreinos.BackColor = Color.Transparent;
            chartTreinos.BorderlineColor = Color.White;
        }

        private void btn_atualizarDados_Click(object sender, EventArgs e)
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);

            string nome = tb_nome.Text;
            int idade = 0;
            double altura = 0;
            double peso = 0;

            if (string.IsNullOrEmpty(nome))
            {
                nome = utilizador.Nome;
            }
            else
            {
                utilizador.Nome = nome;
            }

            if (string.IsNullOrEmpty(tb_idade.Text))
            {
                idade = utilizador.Idade;
            }
            else if (!int.TryParse(tb_idade.Text, out int idadeV) || idadeV <= 0 || idadeV >= 140)
            {
                MessageBox.Show("Tem de colocar um numero válido na idade", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                return;
            }
            else
            {
                utilizador.Idade = idadeV;
            }

            if (string.IsNullOrEmpty(tb_altura.Text))
            {
                altura = utilizador.Altura;
            }
            else if (!double.TryParse(tb_altura.Text, out double alturaV) || alturaV < 0)
            {
                MessageBox.Show("Tem de colocar uma altura válida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                utilizador.Altura = alturaV;
            }

            if (string.IsNullOrEmpty(tb_peso.Text))
            {
                peso = utilizador.Peso;
            }
            else if (!double.TryParse(tb_peso.Text, out double pesoV) || pesoV <= 0)
            {
                MessageBox.Show("Tem de colocar um peso válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                utilizador.Peso = pesoV;
            }


            MessageBox.Show("Dados alterados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
