using Projeto_620.FORMS;
using Projeto_620.models;
using Projeto_620.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_inserirRefeicao_Click(object sender, EventArgs e)
        {
            if (cbb_tipoRefeicao.SelectedIndex == -1)
            {
                MessageBox.Show("Erro! Tem de ter o tipo de treino selecionado");
                cbb_tipoRefeicao.SelectedIndex = -1;
                return;
            }

            string nomeComida = tb_nomeComida.Text;
            if (string.IsNullOrEmpty(nomeComida))
            {
                MessageBox.Show("Erro! O nome de treino não pode estar vazio!");
                return;
            }


            if (!int.TryParse(tb_calorias.Text, out int calorias) || calorias <= 0)
            {
                MessageBox.Show("Erro! Introduza um valor de calorias válido.");
                return;
            }
            TipoRefeicao tipoSelecionado = (TipoRefeicao)cbb_tipoRefeicao.SelectedItem;

            XDocument doc = XDocument.Load(GlobalUtils.caminho);

            GlobalUtils.username = "root"; //ALTERAR PRECISAMOS DE UMA GLOBAL VARIABLE

            XElement user = doc.Descendants("user").FirstOrDefault(x => x.Element("username")?.Value == GlobalUtils.username);

            if (user == null)
            {
                MessageBox.Show("Utilizador não encontrado!");
                return;
            }

            XElement alimentacoes = user.Element("Alimentacoes");
            if (alimentacoes == null)
            {
                alimentacoes = new XElement("Alimentacoes");
                user.Add(alimentacoes);
            }



            XElement novaRefeicao = new XElement("refeicao",
                    new XElement("NomeComida", nomeComida),
                    new XElement("TipoRefeicao", tipoSelecionado.ToString()),
                    new XElement("Calorias", calorias),
                    new XElement("Data", DateTime.Now.ToString("s"))
                );

            alimentacoes.Add(novaRefeicao);


            doc.Save(GlobalUtils.caminho);

            MessageBox.Show("Refeição inserida com sucesso!");

            tb_calorias.Clear();
            tb_nomeComida.Clear();
            cbb_tipoRefeicao.SelectedIndex = -1;

            AtualizarListaRefeicoes();
        
        }

        private void Form_load(object sender, EventArgs e)
        {
            cbb_tipoRefeicao.DataSource = Enum.GetValues(typeof(TipoRefeicao));
            AtualizarListaRefeicoes();
        }

        private void AtualizarListaRefeicoes()
        {
            lb_listaRefeicao.Items.Clear();

            GlobalUtils.username = "root";

            XDocument doc = XDocument.Load(GlobalUtils.caminho);

            var user = doc.Root.Elements("user")
                              .FirstOrDefault(x => x.Element("username")?.Value == GlobalUtils.username);

            var refeicao = user.Element("Alimentacoes");

            if (refeicao == null)
            {
                refeicao = new XElement("Alimentacoes");
                user.Add(refeicao);
                doc.Save(GlobalUtils.caminho);
            }
            if (!refeicao.Elements("refeicao").Any())
            {
                MessageBox.Show("Sem refeições para mostrar, vamos a isso!");
                return;
            }

            foreach (var alime in refeicao.Elements("refeicao"))
            {
                string nomeComida = (string)alime.Element("NomeComida");
                string tipoRefeicao = (string)alime.Element("TipoRefeicao");
                string calorias = (string)alime.Element("Calorias");
                string data = (string)alime.Element("Data");

                string linha = $"{nomeComida} ({tipoRefeicao}) - {calorias} kcal, {data}";

                lb_listaRefeicao.Items.Add(linha);
            }
            
        }
        
    }
}
