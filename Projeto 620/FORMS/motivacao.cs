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

namespace Projeto_620.FORMS
{
    public partial class motivacao : Form
    {
        public motivacao()
        {
            InitializeComponent();
            MostrarImagemAleatoria();
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

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form inicio = new paginaInicial();
            inicio.Show();
            this.Close();
        }

        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            btn_home.Cursor = Cursors.Hand;
        }

        private void btn_appoitments_Click(object sender, EventArgs e)
        {
            Form consultaforma = new consultas();
            consultaforma.Show();
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

        private void btn_food_Click(object sender, EventArgs e)
        {
            Form alimentacao = new alimentacao();
            alimentacao.Show();
            this.Close();
        }

        private void btn_motivacao_Click(object sender, EventArgs e)
        {
            Form motivation = new motivacao();
            motivation.Show();
            this.Close();
        }

        private void btn_food_MouseHover(object sender, EventArgs e)
        {
            btn_food.Cursor = Cursors.Hand;
        }

        private void btn_motivacao_MouseHover(object sender, EventArgs e)
        {
            btn_motivacao.Cursor = Cursors.Hand;
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);
            GlobalUtils.GuardarXML(utilizador);
            Form sair = new login();
            sair.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);
            GlobalUtils.GuardarXML(utilizador);
            Application.Exit();
        }

        private void bt_logout_MouseHover(object sender, EventArgs e)
        {
            bt_logout.Cursor = Cursors.Hand;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Cursor = Cursors.Hand;
        }

        private void pb_menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
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
    }
}
