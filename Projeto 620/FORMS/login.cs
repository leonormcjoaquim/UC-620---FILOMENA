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
    }
}
