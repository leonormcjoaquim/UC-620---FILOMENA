using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form home = new paginaInicial();
            home.Show();
            this.Close();
        }

        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            btn_home.Cursor = Cursors.Hand;
        }

        private void btn_appoitments_Click(object sender, EventArgs e)
        {
            Form appointments = new consultas();
            appointments.Show();
            this.Close();
        }

        private void btn_appoitments_MouseHover(object sender, EventArgs e)
        {
            btn_appoitments.Cursor = Cursors.Hand;
        }

        private void btn_workouts_Click(object sender, EventArgs e)
        {
            Form workouts = new treino();
            workouts.Show();
            this.Close();
        }

        private void btn_workouts_MouseHover(object sender, EventArgs e)
        {
            btn_workouts.Cursor = Cursors.Hand;
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            Form alimentacao = new alimentacao();
            alimentacao.Show();
            this.Close();
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

        private void btn_motivacao_Click(object sender, EventArgs e)
        {
            Form motivacaoForm = new motivacao();
            motivacaoForm.Show();
            this.Close();
        }

        private void btn_motivacao_MouseHover(object sender, EventArgs e)
        {
            btn_motivacao.Cursor = Cursors.Hand;
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Form form = new login();
            form.Show();
            this.Close();
        }
    }
}
