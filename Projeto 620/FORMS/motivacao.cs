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
        }

        private void btn_appoitments_MouseHover(object sender, EventArgs e)
        {
            btn_appoitments.Cursor = Cursors.Hand;
        }

        private void btn_workouts_Click(object sender, EventArgs e)
        {
            Form workouts = new treino();
        }
    }
}
