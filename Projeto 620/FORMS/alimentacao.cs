using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_620.FORMS;
using Projeto_620.models;

namespace Projeto_620
{
    public partial class alimentacao : Form
    {
        public alimentacao()
        {
            InitializeComponent();
        }

        bool sidebarExpand = false;
        private void pb_menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pn_opcoes.Width -= 10;
                // SE O NOME FOR MAIOR QUE AQUELE FODE O RESTO
                if (pn_opcoes.Width <= 45)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                pn_opcoes.Width += 10;
                if (pn_opcoes.Width >= 245)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_logout_MouseClick(object sender, MouseEventArgs e)
        {
            Form formLogin = new login();
            formLogin.Show();
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form inicio = new paginaInicial();
            inicio.Show();
            this.Close();
        }

        private void btn_appoitments_MouseClick(object sender, MouseEventArgs e)
        {
            Form marcacao = new consultas(); 
            marcacao.Show();
            this.Close();
        }
    }
}
