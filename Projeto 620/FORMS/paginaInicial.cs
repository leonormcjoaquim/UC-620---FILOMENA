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

namespace Projeto_620.FORMS
{
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {
            InitializeComponent();
            MostrarImagemAleatoria();
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
        bool menuExpand = false;

 

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pn_opcoes.Width -= 8;
                lbl_ola.Location = new Point(lbl_ola.Location.X - 8, lbl_ola.Location.Y);
                lbl_nome.Location = new Point(lbl_nome.Location.X - 8, lbl_nome.Location.Y);
                if (pn_opcoes.Width <= 54)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                pn_opcoes.Width += 8;
                lbl_ola.Location = new Point(lbl_ola.Location.X + 8, lbl_ola.Location.Y);
                lbl_nome.Location = new Point(lbl_nome.Location.X + 8, lbl_nome.Location.Y);
                if (pn_opcoes.Width >= 165)
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
            btn_logout.Cursor = Cursors.Hand;
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            // NÃO ESTÁ A FECHAR AQUI TAMBEM
            Form login = new login();
            login.Show();
            this.Close();
        }

        private void bt_logout_MouseMove(object sender, MouseEventArgs e)
        {
            btn_logout.Cursor = Cursors.Hand;
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

        private void btn_pt_MouseHover(object sender, EventArgs e)
        {
            btn_pt.Cursor = Cursors.Hand;
        }

        Random rnd = new Random();
        private void MostrarImagemAleatoria()
        {
            string pastaImagens = @"C:\cometudoperdetudo\imgs";
            int numeroEscolhido = rnd.Next(1, 4); // temos 3 imagens agora, adicionar mais

            string caminhoImagem = Path.Combine(pastaImagens, $"{numeroEscolhido}.jpeg");
            if (File.Exists(caminhoImagem))
            {
                pb_foto.Image = Image.FromFile(caminhoImagem);
                pb_foto.SizeMode = PictureBoxSizeMode.StretchImage; 
            }
            else
            {
                MessageBox.Show("Imagem não encontrada: " + caminhoImagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btn_workouts_Click(object sender, EventArgs e)
        {
            Form exercicios = new treino();
            exercicios.Show();
            this.Close();
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            Form alimentacao = new alimentacao();
            alimentacao.Show();
            this.Close();
        }
    }
}
