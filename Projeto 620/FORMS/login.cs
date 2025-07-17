using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ReaLTaiizor.Controls;

namespace Projeto_620.FORMS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            this.Hide();
            paginaInicial registar = new paginaInicial();
            registar.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            paginaInicial PaginaInicial = new paginaInicial();
            PaginaInicial.Show();
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {
            if (MinimizeBox)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
                Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender)
        {
            if (checkBox1.Checked)
            {
                tb_password.Password = false;
            }
            else
            {
                tb_password.Password = true;
            }
        }

        private void btn_registar_Click_1(object sender, EventArgs e)
        {
            Form registar = new registar();
            registar.Show();
        }

        private void btn_login_MouseClick(object sender, MouseEventArgs e)
        {
            // PARA TESTES
            //melhorar esta textbox 
            MessageBox.Show("Login efetuado com sucesso!");
            Form paginaInicial = new paginaInicial();
            paginaInicial.Show();
            this.Hide();

            /*
            tb_username.Focus();
            string caminho = @"C:\cometudoperdetudo\users.xml";
            string username = tb_username.TextButton; // textButton devido à framework que estamos a usar não ter a propriedade text para este elemento
            string password = tb_password.TextButton;

            // Verifica se um dos campos está vazio
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                //melhorar esta textbox
                MessageBox.Show("Por favor, preencha todos os campos.");

               // AQUI ERA BOM LIMPAR AS TEXTBOXES MAS NAO DESCOBRI AINDA COMO

                tb_username.TextButton = string.Empty;
                tb_password.TextButton = string.Empty;

                return;
            }

            // vê todos os users no ficheiro xml e compara se existe ou nao aquele login 
            XDocument doc = XDocument.Load(caminho);
            bool userExists = doc.Descendants("user").Where(x =>
                                x.Element("username")?.Value == username &&
                                x.Element("password")?.Value == password).Any();

            // if userexists == true
            if (!userExists)
            {
                //melhorar esta textbox
                MessageBox.Show("Utilizador ou password incorretos. Tente novamente.");
                tb_username.Focus();
                tb_username.TextButton = string.Empty;
                tb_password.TextButton = string.Empty;
                return;
            }
            else
            {
                //melhorar esta textbox 
                MessageBox.Show("Login efetuado com sucesso!");
                Form paginaInicial = new paginaInicial();
                paginaInicial.Show();
                this.Hide();
            }
            */
           
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {

        }
    }
}
