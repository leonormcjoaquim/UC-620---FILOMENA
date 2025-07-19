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
using Projeto_620.models;
<<<<<<< Updated upstream
=======
using Projeto_620.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
>>>>>>> Stashed changes

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
        string caminho = @"C:\cometudoperdetudo\users.xml";
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_marcar_consulta_Click(object sender, EventArgs e)
        {
            if (cbb_tipo.SelectedIndex == -1 || cbb_especialidades.SelectedIndex == -1)
            {
                MessageBox.Show("Erros!");
                cbb_especialidades.SelectedIndex = 0;
                cbb_tipo.SelectedIndex = 0;
                return;
            }
            string tipoMarcacao = cbb_tipo.Text;
            if (tipoMarcacao == "Especialista")
            {

            }
            else if (tipoMarcacao == "Personal Trainer")
            {

            }
            else
            {
                MessageBox.Show("Erro!");
            }
<<<<<<< Updated upstream
=======

            string username = "root"; //ALTERAR PRECISAMOS DE UMA GLOBAL VARIABLE
            XDocument doc;
            doc = XDocument.Load(caminho);
            var user = doc.Root.Elements("user")
            .FirstOrDefault(x => (string)x.Element("username") == username); // muito gepeto

            var consultas = user.Element("Consultas");
            if (consultas == null)
            {
                consultas = new XElement("Consultas");
                user.Add(consultas);
            }

            XElement novaConsulta = new XElement("Consulta",
                new XElement("TipoMarcacao", marcacao.TipoMarcacao),
                new XElement("DataMarcacao", marcacao.DataMarcacao.ToString("yyyy-MM-dd")),
                new XElement("Especialidade", marcacao.EspecialidadeMarcacao));

            consultas.Add(novaConsulta);

            doc.Save(caminho);

            MessageBox.Show("Sucesso");
>>>>>>> Stashed changes
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            list_box.Items.Clear();
            XDocument doc;
            doc = XDocument.Load(caminho);

            // AQUI VÊ COMPARA O USER PARA IRBUSCAR CONSULTAR
            string username = "root"; //ALTERAR TUDO 
            var user = doc.Root.Elements("user")
                .FirstOrDefault(x => (string)x.Element("username") == username);

            // Aqui vê se tem consultas já marcadas
            var consultas = user.Element("Consultas");
            if (consultas == null)
            {
                consultas = new XElement("Consultas");
                user.Add(consultas);
                doc.Save(caminho);
            }
            if (!consultas.Elements("Consulta").Any())
            {
                MessageBox.Show("Ainda não marcou nenhuma consulta!");
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
                else if (tipo == "Treino PT")
                    m = new TreinoPT(tipo, data, especialidade);
                else
                    continue;

                list_box.Items.Add(m);
            }
        }
    }
}
