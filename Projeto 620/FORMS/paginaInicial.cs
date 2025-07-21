using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_620.FORMS;
using Projeto_620.models;
using Projeto_620.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_620.FORMS
{
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {
            InitializeComponent();
            lbl_ola.Text = "Olá @" + GlobalUtils.username;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                if (pn_opcoes.Width >= 245)
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
            Form paginaInicial = new paginaInicial();
            paginaInicial.Show();
            this.Hide();
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

        private void nightControlBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Use buttons base on their size

            var controlBox = sender as ReaLTaiizor.Controls.NightControlBox;
            int buttonWidth = controlBox.Width / 3; // 3 buttons 

            if (e.X < buttonWidth) //  Minimize
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (e.X < buttonWidth * 2) // Maximize
            {
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;
                else
                    this.WindowState = FormWindowState.Maximized;
            }
            else //  Close
            {
                Application.Exit();
            }
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

        private void btn_calorias_Click(object sender, EventArgs e)
        {
            
        }
        private void AtualizarBarraCalorias()
        {
          
        }

        private void btn_atualizarCaloriasObjetivo_Click(object sender, EventArgs e)
        {
            
        }

        private void cyberButton1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Tem de colocar um numero válido na idade");
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
                MessageBox.Show("Tem de colocar uma altura válida!");
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
                MessageBox.Show("Tem de colocar um peso válido!");
                return;
            } else
            {
                utilizador.Peso = pesoV;
            }


            MessageBox.Show("Dados alterados com sucesso!");


        }
    }
}
