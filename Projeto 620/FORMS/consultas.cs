using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Projeto_620.models;
using Projeto_620.utils;


namespace Projeto_620.FORMS
{
    public partial class consultas : Form
    {
        public consultas()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login Login = new login();
            Login.Show();
        }

        private void tab_marcar_consultas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            btn_home.Cursor = Cursors.Hand;
        }



        private void btn_appoitments_MouseHover(object sender, EventArgs e)
        {
            btn_appointment.Cursor = Cursors.Hand;
        }


        private void btn_workouts_MouseHover(object sender, EventArgs e)
        {
            btn_workouts.Cursor = Cursors.Hand;
        }

        private void btn_food_MouseHover(object sender, EventArgs e)
        {
            btn_food.Cursor = Cursors.Hand;
        }

        private void btn_pt_Click(object sender, EventArgs e)
        {
            Form pt = new consultas();
            pt.Show();
            this.Close();
        }

        private void btn_motivacao_MouseHover(object sender, EventArgs e)
        {
            btn_motivacao.Cursor = Cursors.Hand;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form inicio = new paginaInicial();
            inicio.Show();
            this.Close();
        }

        private void btn_appoitments_Click(object sender, EventArgs e)
        {
            Form consulta = new consultas();
            consulta.Show();
            this.Close();
        }

        private void btn_workouts_Click(object sender, EventArgs e)
        {
            Form workout = new treino();
            workout.Show();
            this.Close();
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            Form comida = new alimentacao();
            comida.Show();
            this.Close();
        }

        private void btn_motivacao_Click(object sender, EventArgs e)
        {
            Form motiva = new motivacao();
            motiva.Show();
            this.Close();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);
            GlobalUtils.GuardarXML(utilizador);
            Form log = new login();
            log.Show();
            this.Close();
        }
        //string caminho = @"C:\cometudoperdetudo\users.xml";
        private void btn_exit_Click(object sender, EventArgs e)
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);
            GlobalUtils.GuardarXML(utilizador);
            Application.Exit();
        }

        private void btn_marcar_consulta_Click(object sender, EventArgs e)
        {
            if (cbb_tipo.SelectedIndex == -1 || cbb_especialidades.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor escolha valores nas ComboBoxes!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbb_especialidades.SelectedIndex = -1;
                cbb_tipo.SelectedIndex = -1;
                return;
            }
            var user = GlobalUtils.users.FirstOrDefault(x => x.Username == GlobalUtils.username);
            string tipoMarcacao = cbb_tipo.Text;
            DateTime dataMarcacao = data_caixa.SelectionStart;
            string especialidade = cbb_especialidades.Text;
            Marcacao novaMarcacao;
            List<Marcacao> marcacoes = user.Marcacao;
            if (tipoMarcacao == "Treino_PT")
            {
                novaMarcacao = new TreinoPT(tipoMarcacao, dataMarcacao, especialidade);
            }
            else
            {
                novaMarcacao = new Appointment(tipoMarcacao, dataMarcacao, especialidade);
            }
            user.Marcacao.Add(novaMarcacao);

            MessageBox.Show("Marcação feita com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            list_box.Items.Clear();

            var user = GlobalUtils.users.FirstOrDefault(x => x.Username == GlobalUtils.username);
            // Aqui vê se tem consultas já marcadas
            
            if (user.Marcacao == null || !user.Marcacao.Any())
            {
                MessageBox.Show("Ainda não marcou nenhuma consulta!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbb_tipo_consulta.SelectedIndex == -1)
            {
                MessageBox.Show("Tem de selecionar uma opção!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string filtroTipo = cbb_tipo_consulta.SelectedItem.ToString();

            list_box.Items.Clear(); // Limpar lista antes de adicionar novos itens

            foreach (var m in user.Marcacao)
            {
                if (filtroTipo != "Todas" && m.TipoMarcacao != filtroTipo)
                    continue;

                list_box.Items.Add(m);
            }

            cbb_tipo_consulta.SelectedIndex = -1;
        }

        private void form_Load(object sender, EventArgs e)
        {
            cbb_tipo.DataSource = Enum.GetValues(typeof(TipoMarcacao));
        }

        private void cbb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_tipo.SelectedItem.ToString() == "Treino_PT")
            {
                cbb_especialidades.Enabled = true;
                lbl_especialidade.Visible = false;
                lbl_tipo.Visible = true;
                cbb_especialidades.DataSource = Enum.GetValues(typeof(TipoTreino));
            } 
            else
            {
                cbb_especialidades.Enabled = true;
                lbl_especialidade.Visible = true;
                lbl_tipo.Visible = false;
                cbb_especialidades.DataSource = Enum.GetValues(typeof(Especialidade));
            }
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
                if (pn_opcoes.Width >= 245)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }
    }

}
