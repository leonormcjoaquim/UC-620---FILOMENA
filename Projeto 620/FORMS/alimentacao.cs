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
            this.BackColor = Color.FromArgb(30, 30, 30);
            InitializeComponent();
            AtualizarBarraCalorias();
            lbl_tituloGanhar.Visible = false;
            lbl_tituloperder.Visible = false;
            lbl_tituloManter.Visible = false;
            lbl_ganhar.Visible = false;
            lbl_perder.Visible = false;
            lbl_normal.Visible = false;
            lbl_objetivo.Visible = true;
            lbl_objetivo.Text = GlobalUtils.caloriasObjetivo.ToString("0");

        }
        private void AtualizarBarraCalorias()
        {
            probar_calorias.Maximum = GlobalUtils.caloriasObjetivo;
            int valor = Math.Min(GlobalUtils.caloriasConsumidas, GlobalUtils.caloriasObjetivo);
            probar_calorias.Value = Math.Max(0, valor);
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);
            GlobalUtils.GuardarXML(utilizador);
            Application.Exit();
        }

        private void btn_inserirRefeicao_Click(object sender, EventArgs e)
        {
            if (cbb_tipoRefeicao.SelectedIndex == -1)
            {
                MessageBox.Show("Erro! Tem de ter o tipo de alimentação selecionado");
                cbb_tipoRefeicao.SelectedIndex = -1;
                return;
            }

            string nomeComida = tb_nomeComida.Text;
            if (string.IsNullOrEmpty(nomeComida))
            {
                MessageBox.Show("Erro! O nome da comida não pode estar vazio!");
                return;
            }


            if (!int.TryParse(tb_calorias.Text, out int calorias) || calorias <= 0)
            {
                MessageBox.Show("Erro! Introduza um valor de calorias válido.");
                return;
            }
            TipoRefeicao tipoSelecionado = (TipoRefeicao)cbb_tipoRefeicao.SelectedItem;

            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);

            Alimentacao refeicao = new Alimentacao(nomeComida, calorias, tipoSelecionado);

            utilizador.Alimentacao.Add(refeicao);
            GlobalUtils.caloriasConsumidas += calorias;

            //XDocument doc = XDocument.Load(GlobalUtils.caminho);

            //GlobalUtils.username = "root"; //ALTERAR PRECISAMOS DE UMA GLOBAL VARIABLE

            //XElement user = doc.Descendants("user").FirstOrDefault(x => x.Element("username")?.Value == GlobalUtils.username);

            //if (user == null)
            //{
            //    MessageBox.Show("Utilizador não encontrado!");
            //    return;
            //}

            //XElement alimentacoes = user.Element("Alimentacoes");
            //if (alimentacoes == null)
            //{
            //    alimentacoes = new XElement("Alimentacoes");
            //    user.Add(alimentacoes);
            //}



            //XElement novaRefeicao = new XElement("refeicao",
            //        new XElement("NomeComida", nomeComida),
            //        new XElement("TipoRefeicao", tipoSelecionado.ToString()),
            //        new XElement("Calorias", calorias),
            //        new XElement("Data", DateTime.Now.ToString("s"))
            //    );

            //alimentacoes.Add(novaRefeicao);


            //doc.Save(GlobalUtils.caminho);

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

            User utilizador = GlobalUtils.users.FirstOrDefault(x => x.Username == GlobalUtils.username);

            foreach(Alimentacao refeicao in utilizador.Alimentacao)
            {
                lb_listaRefeicao.Items.Add(refeicao);
            }

            //lb_listaRefeicao.Items.Clear();

            //XDocument doc = XDocument.Load(GlobalUtils.caminho);

            //var user = doc.Root.Elements("user")
            //                  .FirstOrDefault(x => x.Element("username")?.Value == GlobalUtils.username);

            //var refeicao = user.Element("Alimentacoes");

            //if (refeicao == null)
            //{
            //    refeicao = new XElement("Alimentacoes");
            //    user.Add(refeicao);
            //    doc.Save(GlobalUtils.caminho);
            //}
            //if (!refeicao.Elements("refeicao").Any())
            //{
            //    MessageBox.Show("Sem refeições para mostrar, vamos a isso!");
            //    return;
            //}

            //foreach (var alime in refeicao.Elements("refeicao"))
            //{
            //    string nomeComida = (string)alime.Element("NomeComida");
            //    string tipoRefeicao = (string)alime.Element("TipoRefeicao");
            //    string calorias = (string)alime.Element("Calorias");
            //    string data = (string)alime.Element("Data");

            //    string linha = $"{nomeComida} ({tipoRefeicao}) - {calorias} kcal, {data}";

            //    lb_listaRefeicao.Items.Add(linha);
            //}
        }

        private void pb_menu_Click_1(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void pn_opcoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            btn_home.Cursor = Cursors.Hand;
        }

        private void btn_appoitments_MouseHover(object sender, EventArgs e)
        {
            btn_appoitments.Cursor = Cursors.Hand;
        }

        private void btn_workouts_MouseHover(object sender, EventArgs e)
        {
            btn_workouts.Cursor = Cursors.Hand;
        }

        private void btn_food_MouseHover(object sender, EventArgs e)
        {
            btn_food.Cursor = Cursors.Hand;
        }

        private void btn_motivacao_MouseHover(object sender, EventArgs e)
        {
            btn_motivacao.Cursor = Cursors.Hand;
        }

        private void bt_logout_MouseLeave(object sender, EventArgs e)
        {
            bt_logout.Cursor = Cursors.Hand;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Cursor = Cursors.Hand;
        }

        private void btn_inserirRefeicao_MouseHover(object sender, EventArgs e)
        {
            btn_inserirRefeicao.Cursor = Cursors.Hand;
        }

        private void pb_menu_MouseHover(object sender, EventArgs e)
        {
            pb_menu.Cursor = Cursors.Hand;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_calorias_Click(object sender, EventArgs e)
        {
            User utilizador = GlobalUtils.users.FirstOrDefault(u => u.Username == GlobalUtils.username);
            string tipoAtividade = cbb_tipo_atividade.Text;
            string sexo = utilizador.Sexo;
            double peso = utilizador.Peso;
            double altura = utilizador.Altura * 100;
            int idade = utilizador.Idade;
            double taxaMetabolica;
            if (sexo == "Masculino")
            {
                taxaMetabolica = 88.362 + (13.397 * peso) + (4.799 * altura) - (5.677 * idade);
            }
            else if (sexo == "Feminino")
            {
                taxaMetabolica = 447.593 + (9.247 * peso) + (3.098 * altura) - (4.330 * idade);
            }
            else
            {
                MessageBox.Show("Tem de selecionar uma das opções disponíveis");
                return;
            }

            double fatorAtividade;
            switch (tipoAtividade)
            {
                case "Sedentário":
                    fatorAtividade = 1.2;
                    break;
                case "Exercício leve 1–3 dias/semana":
                    fatorAtividade = 1.375;
                    break;
                case "Exercício moderado 3–5 dias/semana":
                    fatorAtividade = 1.55;
                    break;
                case "Exercício intenso 6–7 dias/semana":
                    fatorAtividade = 1.725;
                    break;
                case "Treinos muito intensos ou 2x por dia":
                    fatorAtividade = 1.9;
                    break;
                default:
                    MessageBox.Show("Tem de selecionar uma opção válida no campo 'Tipo de Atividade'.");
                    return;
            }

            double calorias = taxaMetabolica * fatorAtividade;
            GlobalUtils.caloriasObjetivo = (int)Math.Round(calorias);
            probar_calorias.Maximum = GlobalUtils.caloriasObjetivo;
            lbl_normal.Text = calorias.ToString();
            double perder = calorias - 300;
            lbl_normal.Text = GlobalUtils.caloriasObjetivo.ToString();
            lbl_perder.Text = $"{calorias - 500:0} a {calorias - 300:0}";
            lbl_ganhar.Text = $"{calorias + 300:0} a {calorias + 500:0}";
            lbl_perder.Visible = true;
            lbl_ganhar.Visible = true;
            lbl_normal.Visible = true;
            lbl_tituloGanhar.Visible = true;
            lbl_tituloManter.Visible = true;
            lbl_tituloperder.Visible = true;
            lbl_objetivo.Text = GlobalUtils.caloriasObjetivo.ToString();
        }

        private void btn_atualizarCaloriasObjetivo_Click(object sender, EventArgs e)
        {
            int calorias;
            if (int.TryParse(tb_atualizarCalorias.Text, out calorias))
            {
                GlobalUtils.caloriasObjetivo = calorias;
            }
            else
            {
                MessageBox.Show("Valor inválido. Introduz um número inteiro.");
            }
            lbl_objetivo.Text = GlobalUtils.caloriasObjetivo.ToString();
        }
    }
}
