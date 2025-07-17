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

        private void btn_registar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string username = tb_username.Text;
            string password = tb_password.Text;
            string caminho = @"C:\cometudoperdetudo\users.xml";

            // Tivemos de Criar um ficheiro XML para guardar as informações dos utilizadores
            //XDocument doc = new XDocument(new XElement("users"));
            //doc.Save(caminho);

            // Um género de abrir documento para trabalharmos com ele
            XDocument doc = XDocument.Load(caminho);

            // aqui sim colocamos os dados novos no documento - VER AULA 15 JULHO - PACHECO
            XElement novoUser = new XElement("user",
                                new XElement("username", username),
                                new XElement("nome", nome),
                                new XElement("password", password));

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
    }
}
