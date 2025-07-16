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
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {
            InitializeComponent();
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
                if (pn_opcoes.Width <= 54)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                pn_opcoes.Width += 8;
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
            Form login = new login();
            login.Show();
            this.Hide();
        }

        private void bt_logout_MouseMove(object sender, MouseEventArgs e)
        {
            btn_logout.Cursor = Cursors.Hand;
        }

        private void btn_exit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_exit.Cursor = Cursors.Hand;
        }

        private void btn_home_MouseMove(object sender, MouseEventArgs e)
        {
            btn_home.Cursor = Cursors.Hand;
        }
    }
}
