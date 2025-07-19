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
using System.Xml.Linq;
using Projeto_620.FORMS;

namespace Projeto_620
{
    public partial class registar : Form
    {
        public registar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pb_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_foto.Image = Image.FromFile(openFileDialog.FileName);
            }
            pb_foto.Image = new Bitmap(pb_foto.Image, new Size(150, 150));
        }

        private void nightControlBox1_MouseClick(object sender, MouseEventArgs e)
        {

            // Usar botões com base no seu tamanho

            var controlBox = sender as ReaLTaiizor.Controls.NightControlBox;
            int buttonWidth = controlBox.Width / 3; // 3 botões 

            if (e.X < buttonWidth) //  Minimizar
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (e.X < buttonWidth * 2) // Maximizar
            {
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;
                else
                    this.WindowState = FormWindowState.Maximized;
            }
            else //  fechar
            {
                Application.Exit();
            }
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string username = tb_username.Text;
            string password = tb_password.Text;
            string objetivo = cbb_objectives.SelectedItem.ToString();
            string altura_box = tb_height.Text;
            string peso_box = tb_weight.Text;
            string caminho = @"C:\cometudoperdetudo\users.xml";

            if(!int.TryParse(altura_box, out int altura))
            {
                MessageBox.Show("Número inserido na altura é inválido");
                return;
            }
            if (!int.TryParse(peso_box, out int peso))
            {
                MessageBox.Show("Número inserido no peso é inválido");
                return;
            }

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(objetivo) || altura >= 260)
            {
                MessageBox.Show($"nome: {nome}\nusername: {username}\npass: {password}\nobje: {objetivo}\naltura: {altura}\npeso: {peso}");
                MessageBox.Show("Erro! Tem de preencher todos os campos.");
                return;
            }
            // Tivemos de Criar um ficheiro XML para guardar as informações dos utilizadores
            // XDocument doc = new XDocument(new XElement("users"));
            // doc.Save(caminho);

            // Um género de abrir documento para trabalharmos com ele
            XDocument doc = XDocument.Load(caminho);

            // aqui sim colocamos os dados novos no documento - VER AULA 15 JULHO - PACHECO
            XElement novoUser = new XElement("user",
                                new XElement("username", username),
                                new XElement("nome", nome),
                                new XElement("password", password),
                                new XElement("objetivo", objetivo),
                                new XElement("altura", altura),
                                new XElement("peso", peso));

            // adicionar o utilizador novo ao documento XML
            doc.Root.Add(novoUser);

            // guardar o documento XML atualizado
            doc.Save(caminho);

            // ALTERAR PARA UMA MENSAGEM MAIS 'NITA
            MessageBox.Show("Utilizador criado com sucesso!");


            Form loginPagina = new login();
            loginPagina.Show();
            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
