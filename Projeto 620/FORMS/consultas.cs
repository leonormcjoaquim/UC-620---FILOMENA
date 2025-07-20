using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Projeto_620.FORMS;
using Projeto_620.models;
using Projeto_620.utils;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


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
            Form log = new login();
            log.Show();
            this.Close();
        }
        //string caminho = @"C:\cometudoperdetudo\users.xml";
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_marcar_consulta_Click(object sender, EventArgs e)
        {
            if (cbb_tipo.SelectedIndex == -1 || cbb_especialidades.SelectedIndex == -1)
            {
                MessageBox.Show("Erros!");
                cbb_especialidades.SelectedIndex = -1;
                cbb_tipo.SelectedIndex = -1;
                return;
            }
            string tipoMarcacao = cbb_tipo.Text;

            GlobalUtils.username = "root"; //ALTERAR PRECISAMOS DE UMA GLOBAL VARIABLE
            XDocument doc;
            doc = XDocument.Load(GlobalUtils.caminho);
            var user = doc.Root.Elements("user")
            .FirstOrDefault(x => (string)x.Element("username") == GlobalUtils.username);

            var consultas = user.Element("Consultas");
            if (consultas == null)
            {
                consultas = new XElement("Consultas");
                user.Add(consultas);
            }
            Marcacao marcacao;
            string tipo_Marcacao = cbb_tipo.Text;
            DateTime dataMarcacao = data_caixa.SelectionStart;
            string especialidade = cbb_especialidades.Text;

            if (tipoMarcacao == "Especialista")
                marcacao = new Appointment(tipo_Marcacao, dataMarcacao, especialidade);
            else if (tipoMarcacao == "Treino_PT")
                marcacao = new TreinoPT(tipoMarcacao, dataMarcacao, especialidade);
            else
            {
                MessageBox.Show("Tipo de marcação inválido!");
                return;
            }
            XElement novaConsulta = new XElement("Consulta",
                new XElement("TipoMarcacao", marcacao.TipoMarcacao),
                new XElement("DataMarcacao", marcacao.DataMarcacao.ToString("yyyy-MM-dd")),
                new XElement("Especialidade", marcacao.EspecialidadeMarcacao));

            consultas.Add(novaConsulta);

            doc.Save(GlobalUtils.caminho);

            MessageBox.Show("Sucesso");

            cbb_especialidades.Enabled = false;

        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            list_box.Items.Clear();
            XDocument doc;
            doc = XDocument.Load(GlobalUtils.caminho);

            

            // AQUI VÊ COMPARA O USER PARA IRBUSCAR CONSULTAR
            // PARA jÁ FICA ASSIM DEPOIS ALTERA-SE E JA SE FICA COM UMA IDEA DE COMO ALTERAR A VARIAVEL E USAR
            //ALTERAR TUDO 
            var user = doc.Root.Elements("user")
                .FirstOrDefault(x => (string)x.Element("username") == GlobalUtils.username);

            // Aqui vê se tem consultas já marcadas
            var consultas = user.Element("Consultas");
            if (consultas == null)
            {
                consultas = new XElement("Consultas");
                user.Add(consultas);
                doc.Save(GlobalUtils.caminho);
            }
            if (!consultas.Elements("Consulta").Any())
            {
                MessageBox.Show("Ainda não marcou nenhuma consulta!");
                return;
            }


            if (cbb_tipo_consulta.SelectedItem == null)
            {
                MessageBox.Show("Erro! Para filtrar tem de escolher um tipo de consulta!");
                return;
            }

            string filtroTipo = cbb_tipo_consulta.SelectedItem.ToString();

            foreach (var consulta in consultas.Elements("Consulta"))
            {
                string tipo = (string)consulta.Element("TipoMarcacao");
                string especialidade = (string)consulta.Element("Especialidade");
                DateTime data = DateTime.Parse((string)consulta.Element("DataMarcacao"));

                if (filtroTipo != "Todas" && tipo != filtroTipo)
                    continue;

                Marcacao m;
                if (tipo == "Especialista")
                    m = new Appointment(tipo, data, especialidade);
                else if (tipo == "Treino_PT")
                    m = new TreinoPT(tipo, data, especialidade);
                else
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
                lbl_tipo_treino.Visible = true;
                cbb_especialidades.DataSource = Enum.GetValues(typeof(TipoTreino));
            } else
            {
                lbl_tipo_treino.Visible = false;
                lbl_especialidade.Visible = true;
                cbb_especialidades.Enabled = true;
<<<<<<< Updated upstream
                lbl_tipo_treino.Visible = false;
                lbl_especialidade.Visible = true;
=======
>>>>>>> Stashed changes
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
