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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            Form paginaInicial = new paginaInicial();
            paginaInicial.Show();
            this.Hide();
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
    }
}
