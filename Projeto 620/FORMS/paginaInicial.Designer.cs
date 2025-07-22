namespace Projeto_620.FORMS
{
    partial class paginaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paginaInicial));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pb_menu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pan_color = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.lbl_ola = new System.Windows.Forms.Label();
            this.pn_opcoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_appoitments = new System.Windows.Forms.Button();
            this.btn_workouts = new System.Windows.Forms.Button();
            this.btn_food = new System.Windows.Forms.Button();
            this.btn_motivacao = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.ficheiro = new System.Windows.Forms.OpenFileDialog();
            this.lbl_atualizarPeso = new System.Windows.Forms.Label();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_altura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_atualizarDados = new ReaLTaiizor.Controls.CyberButton();
            this.chartTreinos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn_opcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTreinos)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_menu
            // 
            this.pb_menu.Image = ((System.Drawing.Image)(resources.GetObject("pb_menu.Image")));
            this.pb_menu.Location = new System.Drawing.Point(-7, 7);
            this.pb_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.pb_menu.Size = new System.Drawing.Size(51, 34);
            this.pb_menu.TabIndex = 3;
            this.pb_menu.TabStop = false;
            this.pb_menu.Click += new System.EventHandler(this.pb_menu_Click);
            this.pb_menu.MouseHover += new System.EventHandler(this.pb_menu_MouseHover_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pan_color);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 4;
            // 
            // pan_color
            // 
            this.pan_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pan_color.Location = new System.Drawing.Point(60, 53);
            this.pan_color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_color.Name = "pan_color";
            this.pan_color.Size = new System.Drawing.Size(940, 551);
            this.pan_color.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Perfil";
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // lbl_ola
            // 
            this.lbl_ola.AutoSize = true;
            this.lbl_ola.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ola.Location = new System.Drawing.Point(61, 59);
            this.lbl_ola.Name = "lbl_ola";
            this.lbl_ola.Size = new System.Drawing.Size(92, 51);
            this.lbl_ola.TabIndex = 14;
            this.lbl_ola.Text = "Olá";
            // 
            // pn_opcoes
            // 
            this.pn_opcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pn_opcoes.Controls.Add(this.btn_home);
            this.pn_opcoes.Controls.Add(this.btn_appoitments);
            this.pn_opcoes.Controls.Add(this.btn_workouts);
            this.pn_opcoes.Controls.Add(this.btn_food);
            this.pn_opcoes.Controls.Add(this.btn_motivacao);
            this.pn_opcoes.Controls.Add(this.bt_logout);
            this.pn_opcoes.Controls.Add(this.btn_exit);
            this.pn_opcoes.Location = new System.Drawing.Point(0, 53);
            this.pn_opcoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_opcoes.Name = "pn_opcoes";
            this.pn_opcoes.Size = new System.Drawing.Size(51, 416);
            this.pn_opcoes.TabIndex = 16;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_home.FlatAppearance.BorderSize = 2;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(317, 53);
            this.btn_home.TabIndex = 7;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_appoitments
            // 
            this.btn_appoitments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_appoitments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_appoitments.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_appoitments.FlatAppearance.BorderSize = 2;
            this.btn_appoitments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appoitments.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_appoitments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_appoitments.Image = ((System.Drawing.Image)(resources.GetObject("btn_appoitments.Image")));
            this.btn_appoitments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_appoitments.Location = new System.Drawing.Point(0, 60);
            this.btn_appoitments.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_appoitments.Name = "btn_appoitments";
            this.btn_appoitments.Size = new System.Drawing.Size(317, 50);
            this.btn_appoitments.TabIndex = 7;
            this.btn_appoitments.Text = "Especialista";
            this.btn_appoitments.UseVisualStyleBackColor = false;
            this.btn_appoitments.Click += new System.EventHandler(this.btn_appoitments_Click);
            // 
            // btn_workouts
            // 
            this.btn_workouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_workouts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_workouts.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_workouts.FlatAppearance.BorderSize = 2;
            this.btn_workouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_workouts.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_workouts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_workouts.Image = ((System.Drawing.Image)(resources.GetObject("btn_workouts.Image")));
            this.btn_workouts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_workouts.Location = new System.Drawing.Point(0, 117);
            this.btn_workouts.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_workouts.Name = "btn_workouts";
            this.btn_workouts.Size = new System.Drawing.Size(317, 53);
            this.btn_workouts.TabIndex = 7;
            this.btn_workouts.Text = "Exercicios";
            this.btn_workouts.UseVisualStyleBackColor = false;
            this.btn_workouts.Click += new System.EventHandler(this.btn_workouts_Click);
            // 
            // btn_food
            // 
            this.btn_food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_food.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_food.FlatAppearance.BorderSize = 2;
            this.btn_food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_food.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_food.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_food.Image = ((System.Drawing.Image)(resources.GetObject("btn_food.Image")));
            this.btn_food.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_food.Location = new System.Drawing.Point(0, 177);
            this.btn_food.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_food.Name = "btn_food";
            this.btn_food.Size = new System.Drawing.Size(317, 53);
            this.btn_food.TabIndex = 7;
            this.btn_food.Text = "Comida";
            this.btn_food.UseVisualStyleBackColor = false;
            this.btn_food.Click += new System.EventHandler(this.btn_food_Click);
            // 
            // btn_motivacao
            // 
            this.btn_motivacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_motivacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_motivacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_motivacao.FlatAppearance.BorderSize = 2;
            this.btn_motivacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_motivacao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_motivacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_motivacao.Image = ((System.Drawing.Image)(resources.GetObject("btn_motivacao.Image")));
            this.btn_motivacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_motivacao.Location = new System.Drawing.Point(0, 237);
            this.btn_motivacao.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_motivacao.Name = "btn_motivacao";
            this.btn_motivacao.Size = new System.Drawing.Size(317, 52);
            this.btn_motivacao.TabIndex = 7;
            this.btn_motivacao.Text = "Motivação";
            this.btn_motivacao.UseVisualStyleBackColor = false;
            this.btn_motivacao.Click += new System.EventHandler(this.btn_motivacao_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.bt_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_logout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_logout.FlatAppearance.BorderSize = 2;
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_logout.Image = ((System.Drawing.Image)(resources.GetObject("bt_logout.Image")));
            this.bt_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_logout.Location = new System.Drawing.Point(0, 296);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(317, 53);
            this.bt_logout.TabIndex = 7;
            this.bt_logout.Text = "Logout";
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_exit.FlatAppearance.BorderSize = 2;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(0, 356);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(317, 52);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ficheiro
            // 
            this.ficheiro.FileName = "openFileDialog1";
            // 
            // lbl_atualizarPeso
            // 
            this.lbl_atualizarPeso.AutoSize = true;
            this.lbl_atualizarPeso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_atualizarPeso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_atualizarPeso.Location = new System.Drawing.Point(715, 240);
            this.lbl_atualizarPeso.Name = "lbl_atualizarPeso";
            this.lbl_atualizarPeso.Size = new System.Drawing.Size(65, 28);
            this.lbl_atualizarPeso.TabIndex = 37;
            this.lbl_atualizarPeso.Text = "Idade:";
            // 
            // tb_idade
            // 
            this.tb_idade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_idade.Location = new System.Drawing.Point(782, 237);
            this.tb_idade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(196, 34);
            this.tb_idade.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(735, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 37);
            this.label2.TabIndex = 39;
            this.label2.Text = "Atualizar dados:";
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_nome.Location = new System.Drawing.Point(782, 180);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(196, 34);
            this.tb_nome.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(708, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nome:";
            // 
            // tb_altura
            // 
            this.tb_altura.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_altura.Location = new System.Drawing.Point(782, 291);
            this.tb_altura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_altura.Name = "tb_altura";
            this.tb_altura.Size = new System.Drawing.Size(196, 34);
            this.tb_altura.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(711, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "Altura:";
            // 
            // tb_peso
            // 
            this.tb_peso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_peso.Location = new System.Drawing.Point(782, 343);
            this.tb_peso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(196, 34);
            this.tb_peso.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(723, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Peso:";
            // 
            // btn_atualizarDados
            // 
            this.btn_atualizarDados.Alpha = 20;
            this.btn_atualizarDados.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizarDados.Background = true;
            this.btn_atualizarDados.Background_WidthPen = 4F;
            this.btn_atualizarDados.BackgroundPen = true;
            this.btn_atualizarDados.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_atualizarDados.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_atualizarDados.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_atualizarDados.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_atualizarDados.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_atualizarDados.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_atualizarDados.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_atualizarDados.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btn_atualizarDados.Effect_1 = true;
            this.btn_atualizarDados.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_atualizarDados.Effect_1_Transparency = 25;
            this.btn_atualizarDados.Effect_2 = true;
            this.btn_atualizarDados.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btn_atualizarDados.Effect_2_Transparency = 20;
            this.btn_atualizarDados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizarDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_atualizarDados.Lighting = false;
            this.btn_atualizarDados.LinearGradient_Background = false;
            this.btn_atualizarDados.LinearGradientPen = false;
            this.btn_atualizarDados.Location = new System.Drawing.Point(800, 416);
            this.btn_atualizarDados.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizarDados.Name = "btn_atualizarDados";
            this.btn_atualizarDados.PenWidth = 15;
            this.btn_atualizarDados.Rounding = true;
            this.btn_atualizarDados.RoundingInt = 70;
            this.btn_atualizarDados.Size = new System.Drawing.Size(159, 53);
            this.btn_atualizarDados.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_atualizarDados.TabIndex = 46;
            this.btn_atualizarDados.Tag = "Cyber";
            this.btn_atualizarDados.TextButton = "Atualizar";
            this.btn_atualizarDados.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_atualizarDados.Timer_Effect_1 = 5;
            this.btn_atualizarDados.Timer_RGB = 300;
            this.btn_atualizarDados.Click += new System.EventHandler(this.btn_atualizarDados_Click);
            // 
            // chartTreinos
            // 
            this.chartTreinos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chartTreinos.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartTreinos.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartTreinos.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartTreinos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTreinos.Legends.Add(legend2);
            this.chartTreinos.Location = new System.Drawing.Point(79, 111);
            this.chartTreinos.Margin = new System.Windows.Forms.Padding(4);
            this.chartTreinos.Name = "chartTreinos";
            this.chartTreinos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTreinos.Series.Add(series2);
            this.chartTreinos.Size = new System.Drawing.Size(611, 486);
            this.chartTreinos.TabIndex = 47;
            this.chartTreinos.Text = "chart1";
            // 
            // paginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1000, 601);
            this.Controls.Add(this.btn_atualizarDados);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_altura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_idade);
            this.Controls.Add(this.pn_opcoes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_ola);
            this.Controls.Add(this.lbl_atualizarPeso);
            this.Controls.Add(this.chartTreinos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 601);
            this.MinimumSize = new System.Drawing.Size(1000, 601);
            this.Name = "paginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paginaInicial";
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_opcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTreinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pan_color;
        private System.Windows.Forms.Label lbl_ola;
        private System.Windows.Forms.FlowLayoutPanel pn_opcoes;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_appoitments;
        private System.Windows.Forms.Button btn_workouts;
        private System.Windows.Forms.Button btn_food;
        private System.Windows.Forms.Button btn_motivacao;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.OpenFileDialog ficheiro;
        private System.Windows.Forms.Label lbl_atualizarPeso;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_altura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_peso;
        private System.Windows.Forms.Label label5;
        private ReaLTaiizor.Controls.CyberButton btn_atualizarDados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTreinos;
    }
}