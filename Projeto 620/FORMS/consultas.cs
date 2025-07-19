using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_620.models;

namespace Projeto_620.FORMS
{
    public partial class consultas : Form
    {
        public consultas()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login Login = new login();
            Login.Show();
        }

        private void tab_marcar_consultas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            btn_home.Cursor = Cursors.Hand;
        }



        private void btn_appoitments_MouseHover(object sender, EventArgs e)
        {
            btn_appointment.Cursor = Cursors.Hand;
        }


        private void btn_workouts_MouseHover(object sender, EventArgs e)
        {
            btn_workouts.Cursor = Cursors.Hand;
        }

        private void btn_food_MouseHover(object sender, EventArgs e)
        {
            btn_food.Cursor = Cursors.Hand;
        }

        private void btn_pt_Click(object sender, EventArgs e)
        {
            Form pt = new consultas();
            pt.Show();
            this.Close();
        }

        private void btn_motivacao_MouseHover(object sender, EventArgs e)
        {
            btn_motivacao.Cursor = Cursors.Hand;
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
            Form log = new login();
            log.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_marcar_consulta_Click(object sender, EventArgs e)
        {
            if (cbb_tipo.SelectedIndex == -1 || cbb_especialidades.SelectedIndex == -1)
            {
                MessageBox.Show("Erros!");
                cbb_especialidades.SelectedIndex = 0;
                cbb_tipo.SelectedIndex = 0;
                return;
            }
            string tipoMarcacao = cbb_tipo.Text;
            if (tipoMarcacao == "Especialista")
            {

            }
            else if (tipoMarcacao == "Personal Trainer")
            {

            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}
