using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Projeto_620.FORMS;
using Projeto_620.models;
using Projeto_620.utils;
namespace Projeto_620
{
    public partial class registar : Form
    {
        public registar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pb_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_foto.Image = Image.FromFile(openFileDialog.FileName);
            }
            pb_foto.Image = new Bitmap(pb_foto.Image, new Size(150, 150));
        }

        private void nightControlBox1_MouseClick(object sender, MouseEventArgs e)
        {

            // Usar botões com base no seu tamanho

            var controlBox = sender as ReaLTaiizor.Controls.NightControlBox;
            int buttonWidth = controlBox.Width / 3; // 3 botões 

            if (e.X < buttonWidth) //  Minimizar
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (e.X < buttonWidth * 2) // Maximizar
            {
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;
                else
                    this.WindowState = FormWindowState.Maximized;
            }
            else //  fechar
            {
                Application.Exit();
            }
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string username = tb_username.Text;
            string password = tb_password.Text;
            string objetivo = cbb_objectives.SelectedItem.ToString();
            string altura_box = tb_height.Text;
            string peso_box = tb_weight.Text;
            int idade;
            string email = tb_email.Text;
            string sexo = cbb_sexo.SelectedItem.ToString();

            // Tivemos de Criar um ficheiro XML para guardar as informações dos utilizadores
            // XDocument doc = new XDocument(new XElement("users"));
            // doc.Save(caminho);

            // Um género de abrir documento para trabalharmos com ele
            XDocument doc = XDocument.Load(GlobalUtils.caminho);

            if (username.Length <= 0 || username.Length > 20)
            {
                MessageBox.Show("Username só pode ter no máximo 20 caracteres", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool usernameExiste = doc.Descendants("user").Elements("Dados").Elements("username").Any(x => x.Value == username);

            if (usernameExiste)
            {
                MessageBox.Show("Este username já existe. Por favor escolhe outro.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_username.Text = string.Empty;
                return;
            }

            if (!int.TryParse(tb_idade.Text, out idade) && idade <= 0)
            {
                MessageBox.Show("Valor inserido na idade inválida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(tb_weight.Text, out double peso) && peso <= 0)
            {
                MessageBox.Show("Valor inserido no peso inválido! Tente com virgula", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(tb_height.Text, out double altura) && altura <= 0)
            {
                MessageBox.Show("Valor inserido na altura inválido! Tente com virgula", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(objetivo) || altura >= 260 || string.IsNullOrEmpty(sexo))
            {
                MessageBox.Show("Tem de preencher todos os campos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // aqui sim colocamos os dados novos no documento - VER AULA 15 JULHO - PACHECO
            XElement novoUser = new XElement("user",
                                    new XElement("Dados",
                                        new XElement("username", username),
                                        new XElement("nome", nome),
                                        new XElement("password", password),
                                        new XElement("sexo", sexo),
                                        new XElement("idade", idade),
                                        new XElement("email", email),
                                        new XElement("objetivo", objetivo),
                                        new XElement("altura", altura),
                                        new XElement("peso", peso)));

            // adicionar o utilizador novo ao documento XML
            doc.Root.Add(novoUser);

            // guardar o documento XML atualizado
            doc.Save(GlobalUtils.caminho);

            // ALTERAR PARA UMA MENSAGEM MAIS 'NITA
            MessageBox.Show("Utilizador criado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_calculoIMC_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(tb_weight.Text, out double peso) && peso <= 0)
            {
                MessageBox.Show("Valor inserido no peso inválido! Tente com virgula", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(tb_height.Text, out double altura) && altura <= 0)
            {
                MessageBox.Show("Valor inserido na altura inválido! Tente com virgula", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                lbl_resultado_IMC.Text = $"O IMC é: {imc:F2}. Está abaixo do peso normal.";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                lbl_resultado_IMC.Text = $"O IMC é: {imc:F2}. Está no peso perfeito!";
            }
            else if (imc > 24.9 && imc <= 29.9)
            {
                lbl_resultado_IMC.Text = $"O IMC é: {imc:F2}. Está com excesso de peso.";
            }
            else
            {
                lbl_resultado_IMC.Text = $"O IMC é: {imc:F2}. Está obeso.";
            }
        }       
    }
}
