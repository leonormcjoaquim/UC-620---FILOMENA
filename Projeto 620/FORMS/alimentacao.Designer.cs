namespace Projeto_620
{
    partial class alimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alimentacao));
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_menu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_opcoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_appoitments = new System.Windows.Forms.Button();
            this.btn_workouts = new System.Windows.Forms.Button();
            this.btn_food = new System.Windows.Forms.Button();
            this.btn_motivacao = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabs_comida = new ReaLTaiizor.Controls.MetroTabControl();
            this.metroTabPage1 = new ReaLTaiizor.Child.Metro.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_inserirRefeicao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_tipoRefeicao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nomeComida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_calorias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_listaRefeicao = new System.Windows.Forms.ListBox();
            this.calculadora = new ReaLTaiizor.Child.Metro.MetroTabPage();
            this.lbl_caloriasIngeridas = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.lbl_objetivo = new System.Windows.Forms.Label();
            this.lbl_objetivo_calorias = new ReaLTaiizor.Controls.BigLabel();
            this.lbl_perder = new System.Windows.Forms.Label();
            this.lbl_ganhar = new System.Windows.Forms.Label();
            this.lbl_normal = new System.Windows.Forms.Label();
            this.lbl_tituloGanhar = new System.Windows.Forms.Label();
            this.lbl_tituloManter = new System.Windows.Forms.Label();
            this.lbl_tituloperder = new System.Windows.Forms.Label();
            this.tb_atualizarCalorias = new System.Windows.Forms.TextBox();
            this.lbl_atualizar = new System.Windows.Forms.Label();
            this.btn_atualizarCaloriasObjetivo = new ReaLTaiizor.Controls.CyberButton();
            this.probar_calorias = new System.Windows.Forms.ProgressBar();
            this.btn_calorias = new ReaLTaiizor.Controls.CyberButton();
            this.cbb_tipo_atividade = new System.Windows.Forms.ComboBox();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_calculadora = new ReaLTaiizor.Controls.BigLabel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            this.pn_opcoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabs_comida.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.calculadora.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pb_menu);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 50);
            this.panel3.TabIndex = 7;
            // 
            // pb_menu
            // 
            this.pb_menu.Image = ((System.Drawing.Image)(resources.GetObject("pb_menu.Image")));
            this.pb_menu.Location = new System.Drawing.Point(-4, 6);
            this.pb_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.pb_menu.Size = new System.Drawing.Size(51, 34);
            this.pb_menu.TabIndex = 40;
            this.pb_menu.TabStop = false;
            this.pb_menu.Click += new System.EventHandler(this.pb_menu_Click_1);
            this.pb_menu.MouseHover += new System.EventHandler(this.pb_menu_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(60, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 38);
            this.label2.TabIndex = 39;
            this.label2.Text = "Refeição";
            // 
            // pn_opcoes
            // 
            this.pn_opcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pn_opcoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_opcoes.Controls.Add(this.btn_home);
            this.pn_opcoes.Controls.Add(this.btn_appoitments);
            this.pn_opcoes.Controls.Add(this.btn_workouts);
            this.pn_opcoes.Controls.Add(this.btn_food);
            this.pn_opcoes.Controls.Add(this.btn_motivacao);
            this.pn_opcoes.Controls.Add(this.bt_logout);
            this.pn_opcoes.Controls.Add(this.btn_exit);
            this.pn_opcoes.Location = new System.Drawing.Point(1, 50);
            this.pn_opcoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_opcoes.Name = "pn_opcoes";
            this.pn_opcoes.Size = new System.Drawing.Size(53, 416);
            this.pn_opcoes.TabIndex = 6;
            this.pn_opcoes.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_opcoes_Paint);
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
            this.btn_home.MouseHover += new System.EventHandler(this.btn_home_MouseHover);
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
            this.btn_appoitments.MouseHover += new System.EventHandler(this.btn_appoitments_MouseHover);
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
            this.btn_workouts.MouseHover += new System.EventHandler(this.btn_workouts_MouseHover);
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
            this.btn_food.MouseHover += new System.EventHandler(this.btn_food_MouseHover);
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
            this.btn_motivacao.MouseHover += new System.EventHandler(this.btn_motivacao_MouseHover);
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
            this.bt_logout.MouseLeave += new System.EventHandler(this.bt_logout_MouseLeave);
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
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.pn_opcoes);
            this.panel1.Controls.Add(this.tabs_comida);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 601);
            this.panel1.TabIndex = 0;
            // 
            // tabs_comida
            // 
            this.tabs_comida.AnimateEasingType = ReaLTaiizor.Enum.Metro.EasingType.CubeOut;
            this.tabs_comida.AnimateTime = 200;
            this.tabs_comida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabs_comida.Controls.Add(this.metroTabPage1);
            this.tabs_comida.Controls.Add(this.calculadora);
            this.tabs_comida.ControlsVisible = true;
            this.tabs_comida.IsDerivedStyle = true;
            this.tabs_comida.ItemSize = new System.Drawing.Size(100, 38);
            this.tabs_comida.Location = new System.Drawing.Point(58, 50);
            this.tabs_comida.MCursor = System.Windows.Forms.Cursors.Hand;
            this.tabs_comida.Name = "tabs_comida";
            this.tabs_comida.SelectedIndex = 1;
            this.tabs_comida.SelectedTextColor = System.Drawing.Color.White;
            this.tabs_comida.Size = new System.Drawing.Size(943, 550);
            this.tabs_comida.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs_comida.Speed = 100;
            this.tabs_comida.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.tabs_comida.StyleManager = null;
            this.tabs_comida.TabIndex = 9;
            this.tabs_comida.ThemeAuthor = "Taiizor";
            this.tabs_comida.ThemeName = "MetroDark";
            this.tabs_comida.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tabs_comida.SelectedIndexChanged += new System.EventHandler(this.tabs_comida_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.Controls.Add(this.btn_inserirRefeicao);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.cbb_tipoRefeicao);
            this.metroTabPage1.Controls.Add(this.label7);
            this.metroTabPage1.Controls.Add(this.tb_nomeComida);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.tb_calorias);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.lb_listaRefeicao);
            this.metroTabPage1.Font = null;
            this.metroTabPage1.ImageIndex = 0;
            this.metroTabPage1.ImageKey = null;
            this.metroTabPage1.IsDerivedStyle = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(935, 504);
            this.metroTabPage1.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.metroTabPage1.StyleManager = null;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Alimentação";
            this.metroTabPage1.ThemeAuthor = "Taiizor";
            this.metroTabPage1.ThemeName = "MetroDark";
            this.metroTabPage1.ToolTipText = null;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(818, -8);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 81);
            this.panel2.TabIndex = 53;
            // 
            // btn_inserirRefeicao
            // 
            this.btn_inserirRefeicao.BackColor = System.Drawing.Color.LightGray;
            this.btn_inserirRefeicao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_inserirRefeicao.FlatAppearance.BorderSize = 5;
            this.btn_inserirRefeicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_inserirRefeicao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirRefeicao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_inserirRefeicao.Location = new System.Drawing.Point(663, 109);
            this.btn_inserirRefeicao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inserirRefeicao.Name = "btn_inserirRefeicao";
            this.btn_inserirRefeicao.Size = new System.Drawing.Size(127, 79);
            this.btn_inserirRefeicao.TabIndex = 51;
            this.btn_inserirRefeicao.Text = "Inserir";
            this.btn_inserirRefeicao.UseVisualStyleBackColor = false;
            this.btn_inserirRefeicao.Click += new System.EventHandler(this.btn_inserirRefeicao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(90, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 35);
            this.label1.TabIndex = 43;
            this.label1.Text = "Inserir Refeição";
            // 
            // cbb_tipoRefeicao
            // 
            this.cbb_tipoRefeicao.BackColor = System.Drawing.Color.LightGray;
            this.cbb_tipoRefeicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_tipoRefeicao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tipoRefeicao.FormattingEnabled = true;
            this.cbb_tipoRefeicao.Location = new System.Drawing.Point(247, 80);
            this.cbb_tipoRefeicao.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tipoRefeicao.Name = "cbb_tipoRefeicao";
            this.cbb_tipoRefeicao.Size = new System.Drawing.Size(280, 40);
            this.cbb_tipoRefeicao.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(536, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "(à escolha)";
            // 
            // tb_nomeComida
            // 
            this.tb_nomeComida.BackColor = System.Drawing.Color.LightGray;
            this.tb_nomeComida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nomeComida.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tb_nomeComida.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_nomeComida.Location = new System.Drawing.Point(247, 131);
            this.tb_nomeComida.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nomeComida.Name = "tb_nomeComida";
            this.tb_nomeComida.Size = new System.Drawing.Size(281, 39);
            this.tb_nomeComida.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(47, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tipo de refeição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(38, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 32);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nome da comida:";
            // 
            // tb_calorias
            // 
            this.tb_calorias.BackColor = System.Drawing.Color.LightGray;
            this.tb_calorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_calorias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_calorias.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_calorias.Location = new System.Drawing.Point(247, 179);
            this.tb_calorias.Margin = new System.Windows.Forms.Padding(4);
            this.tb_calorias.Name = "tb_calorias";
            this.tb_calorias.Size = new System.Drawing.Size(281, 39);
            this.tb_calorias.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(139, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 32);
            this.label5.TabIndex = 49;
            this.label5.Text = "Calorias:";
            // 
            // lb_listaRefeicao
            // 
            this.lb_listaRefeicao.BackColor = System.Drawing.Color.LightGray;
            this.lb_listaRefeicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_listaRefeicao.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_listaRefeicao.FormattingEnabled = true;
            this.lb_listaRefeicao.ItemHeight = 28;
            this.lb_listaRefeicao.Location = new System.Drawing.Point(6, 259);
            this.lb_listaRefeicao.Margin = new System.Windows.Forms.Padding(4);
            this.lb_listaRefeicao.Name = "lb_listaRefeicao";
            this.lb_listaRefeicao.Size = new System.Drawing.Size(922, 254);
            this.lb_listaRefeicao.TabIndex = 52;
            // 
            // calculadora
            // 
            this.calculadora.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.calculadora.Controls.Add(this.lbl_caloriasIngeridas);
            this.calculadora.Controls.Add(this.bigLabel1);
            this.calculadora.Controls.Add(this.lbl_objetivo);
            this.calculadora.Controls.Add(this.lbl_objetivo_calorias);
            this.calculadora.Controls.Add(this.lbl_perder);
            this.calculadora.Controls.Add(this.lbl_ganhar);
            this.calculadora.Controls.Add(this.lbl_normal);
            this.calculadora.Controls.Add(this.lbl_tituloGanhar);
            this.calculadora.Controls.Add(this.lbl_tituloManter);
            this.calculadora.Controls.Add(this.lbl_tituloperder);
            this.calculadora.Controls.Add(this.tb_atualizarCalorias);
            this.calculadora.Controls.Add(this.lbl_atualizar);
            this.calculadora.Controls.Add(this.btn_atualizarCaloriasObjetivo);
            this.calculadora.Controls.Add(this.probar_calorias);
            this.calculadora.Controls.Add(this.btn_calorias);
            this.calculadora.Controls.Add(this.cbb_tipo_atividade);
            this.calculadora.Controls.Add(this.bigLabel3);
            this.calculadora.Controls.Add(this.label6);
            this.calculadora.Controls.Add(this.lbl_calculadora);
            this.calculadora.Font = null;
            this.calculadora.ImageIndex = 0;
            this.calculadora.ImageKey = null;
            this.calculadora.IsDerivedStyle = true;
            this.calculadora.Location = new System.Drawing.Point(4, 42);
            this.calculadora.Name = "calculadora";
            this.calculadora.Size = new System.Drawing.Size(935, 504);
            this.calculadora.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.calculadora.StyleManager = null;
            this.calculadora.TabIndex = 1;
            this.calculadora.Text = "Calculadora Calórica";
            this.calculadora.ThemeAuthor = "Taiizor";
            this.calculadora.ThemeName = "MetroDark";
            this.calculadora.ToolTipText = null;
            // 
            // lbl_caloriasIngeridas
            // 
            this.lbl_caloriasIngeridas.AutoSize = true;
            this.lbl_caloriasIngeridas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_caloriasIngeridas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caloriasIngeridas.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_caloriasIngeridas.Location = new System.Drawing.Point(854, 98);
            this.lbl_caloriasIngeridas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_caloriasIngeridas.Name = "lbl_caloriasIngeridas";
            this.lbl_caloriasIngeridas.Size = new System.Drawing.Size(0, 28);
            this.lbl_caloriasIngeridas.TabIndex = 47;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel1.Location = new System.Drawing.Point(605, 91);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(249, 38);
            this.bigLabel1.TabIndex = 46;
            this.bigLabel1.Text = "Calorias Ingeridas: ";
            // 
            // lbl_objetivo
            // 
            this.lbl_objetivo.AutoSize = true;
            this.lbl_objetivo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_objetivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objetivo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_objetivo.Location = new System.Drawing.Point(854, 173);
            this.lbl_objetivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_objetivo.Name = "lbl_objetivo";
            this.lbl_objetivo.Size = new System.Drawing.Size(0, 28);
            this.lbl_objetivo.TabIndex = 45;
            // 
            // lbl_objetivo_calorias
            // 
            this.lbl_objetivo_calorias.AutoSize = true;
            this.lbl_objetivo_calorias.BackColor = System.Drawing.Color.Transparent;
            this.lbl_objetivo_calorias.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objetivo_calorias.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_objetivo_calorias.Location = new System.Drawing.Point(608, 163);
            this.lbl_objetivo_calorias.Name = "lbl_objetivo_calorias";
            this.lbl_objetivo_calorias.Size = new System.Drawing.Size(232, 38);
            this.lbl_objetivo_calorias.TabIndex = 44;
            this.lbl_objetivo_calorias.Text = "Calorias Objetivo:";
            // 
            // lbl_perder
            // 
            this.lbl_perder.AutoSize = true;
            this.lbl_perder.BackColor = System.Drawing.Color.Transparent;
            this.lbl_perder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perder.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_perder.Location = new System.Drawing.Point(192, 305);
            this.lbl_perder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_perder.Name = "lbl_perder";
            this.lbl_perder.Size = new System.Drawing.Size(0, 28);
            this.lbl_perder.TabIndex = 41;
            this.lbl_perder.Visible = false;
            // 
            // lbl_ganhar
            // 
            this.lbl_ganhar.AutoSize = true;
            this.lbl_ganhar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ganhar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ganhar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ganhar.Location = new System.Drawing.Point(192, 425);
            this.lbl_ganhar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ganhar.Name = "lbl_ganhar";
            this.lbl_ganhar.Size = new System.Drawing.Size(0, 28);
            this.lbl_ganhar.TabIndex = 43;
            this.lbl_ganhar.Visible = false;
            // 
            // lbl_normal
            // 
            this.lbl_normal.AutoSize = true;
            this.lbl_normal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_normal.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_normal.Location = new System.Drawing.Point(192, 364);
            this.lbl_normal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_normal.Name = "lbl_normal";
            this.lbl_normal.Size = new System.Drawing.Size(0, 28);
            this.lbl_normal.TabIndex = 42;
            this.lbl_normal.Visible = false;
            // 
            // lbl_tituloGanhar
            // 
            this.lbl_tituloGanhar.AutoSize = true;
            this.lbl_tituloGanhar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tituloGanhar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloGanhar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tituloGanhar.Location = new System.Drawing.Point(11, 422);
            this.lbl_tituloGanhar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tituloGanhar.Name = "lbl_tituloGanhar";
            this.lbl_tituloGanhar.Size = new System.Drawing.Size(173, 31);
            this.lbl_tituloGanhar.TabIndex = 40;
            this.lbl_tituloGanhar.Text = "Aumentar Peso:";
            this.lbl_tituloGanhar.Visible = false;
            // 
            // lbl_tituloManter
            // 
            this.lbl_tituloManter.AutoSize = true;
            this.lbl_tituloManter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tituloManter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloManter.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tituloManter.Location = new System.Drawing.Point(38, 362);
            this.lbl_tituloManter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tituloManter.Name = "lbl_tituloManter";
            this.lbl_tituloManter.Size = new System.Drawing.Size(146, 31);
            this.lbl_tituloManter.TabIndex = 39;
            this.lbl_tituloManter.Text = "Manter Peso:";
            this.lbl_tituloManter.Visible = false;
            // 
            // lbl_tituloperder
            // 
            this.lbl_tituloperder.AutoSize = true;
            this.lbl_tituloperder.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tituloperder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloperder.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tituloperder.Location = new System.Drawing.Point(46, 302);
            this.lbl_tituloperder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tituloperder.Name = "lbl_tituloperder";
            this.lbl_tituloperder.Size = new System.Drawing.Size(138, 31);
            this.lbl_tituloperder.TabIndex = 38;
            this.lbl_tituloperder.Text = "Perder Peso:";
            this.lbl_tituloperder.Visible = false;
            // 
            // tb_atualizarCalorias
            // 
            this.tb_atualizarCalorias.Location = new System.Drawing.Point(774, 251);
            this.tb_atualizarCalorias.Name = "tb_atualizarCalorias";
            this.tb_atualizarCalorias.Size = new System.Drawing.Size(155, 26);
            this.tb_atualizarCalorias.TabIndex = 37;
            // 
            // lbl_atualizar
            // 
            this.lbl_atualizar.AutoSize = true;
            this.lbl_atualizar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_atualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_atualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_atualizar.Location = new System.Drawing.Point(580, 233);
            this.lbl_atualizar.Name = "lbl_atualizar";
            this.lbl_atualizar.Size = new System.Drawing.Size(174, 56);
            this.lbl_atualizar.TabIndex = 36;
            this.lbl_atualizar.Text = "Atualizar \r\nObjetivo Calorias";
            this.lbl_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_atualizarCaloriasObjetivo
            // 
            this.btn_atualizarCaloriasObjetivo.Alpha = 20;
            this.btn_atualizarCaloriasObjetivo.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizarCaloriasObjetivo.Background = true;
            this.btn_atualizarCaloriasObjetivo.Background_WidthPen = 4F;
            this.btn_atualizarCaloriasObjetivo.BackgroundPen = true;
            this.btn_atualizarCaloriasObjetivo.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_atualizarCaloriasObjetivo.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_atualizarCaloriasObjetivo.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_atualizarCaloriasObjetivo.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_atualizarCaloriasObjetivo.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_atualizarCaloriasObjetivo.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_atualizarCaloriasObjetivo.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_atualizarCaloriasObjetivo.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btn_atualizarCaloriasObjetivo.Effect_1 = true;
            this.btn_atualizarCaloriasObjetivo.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_atualizarCaloriasObjetivo.Effect_1_Transparency = 25;
            this.btn_atualizarCaloriasObjetivo.Effect_2 = true;
            this.btn_atualizarCaloriasObjetivo.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btn_atualizarCaloriasObjetivo.Effect_2_Transparency = 20;
            this.btn_atualizarCaloriasObjetivo.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_atualizarCaloriasObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_atualizarCaloriasObjetivo.Lighting = false;
            this.btn_atualizarCaloriasObjetivo.LinearGradient_Background = false;
            this.btn_atualizarCaloriasObjetivo.LinearGradientPen = false;
            this.btn_atualizarCaloriasObjetivo.Location = new System.Drawing.Point(663, 333);
            this.btn_atualizarCaloriasObjetivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atualizarCaloriasObjetivo.Name = "btn_atualizarCaloriasObjetivo";
            this.btn_atualizarCaloriasObjetivo.PenWidth = 15;
            this.btn_atualizarCaloriasObjetivo.Rounding = true;
            this.btn_atualizarCaloriasObjetivo.RoundingInt = 70;
            this.btn_atualizarCaloriasObjetivo.Size = new System.Drawing.Size(191, 59);
            this.btn_atualizarCaloriasObjetivo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_atualizarCaloriasObjetivo.TabIndex = 35;
            this.btn_atualizarCaloriasObjetivo.Tag = "Cyber";
            this.btn_atualizarCaloriasObjetivo.TextButton = "Atualizar Objetivo";
            this.btn_atualizarCaloriasObjetivo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_atualizarCaloriasObjetivo.Timer_Effect_1 = 5;
            this.btn_atualizarCaloriasObjetivo.Timer_RGB = 300;
            this.btn_atualizarCaloriasObjetivo.Click += new System.EventHandler(this.btn_atualizarCaloriasObjetivo_Click);
            // 
            // probar_calorias
            // 
            this.probar_calorias.Location = new System.Drawing.Point(277, 100);
            this.probar_calorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.probar_calorias.Name = "probar_calorias";
            this.probar_calorias.Size = new System.Drawing.Size(301, 36);
            this.probar_calorias.TabIndex = 31;
            this.probar_calorias.Value = 50;
            // 
            // btn_calorias
            // 
            this.btn_calorias.Alpha = 20;
            this.btn_calorias.BackColor = System.Drawing.Color.Transparent;
            this.btn_calorias.Background = true;
            this.btn_calorias.Background_WidthPen = 4F;
            this.btn_calorias.BackgroundPen = true;
            this.btn_calorias.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_calorias.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_calorias.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_calorias.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_calorias.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_calorias.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_calorias.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_calorias.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btn_calorias.Effect_1 = true;
            this.btn_calorias.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_calorias.Effect_1_Transparency = 25;
            this.btn_calorias.Effect_2 = true;
            this.btn_calorias.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btn_calorias.Effect_2_Transparency = 20;
            this.btn_calorias.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_calorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_calorias.Lighting = false;
            this.btn_calorias.LinearGradient_Background = false;
            this.btn_calorias.LinearGradientPen = false;
            this.btn_calorias.Location = new System.Drawing.Point(146, 230);
            this.btn_calorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_calorias.Name = "btn_calorias";
            this.btn_calorias.PenWidth = 15;
            this.btn_calorias.Rounding = true;
            this.btn_calorias.RoundingInt = 70;
            this.btn_calorias.Size = new System.Drawing.Size(191, 53);
            this.btn_calorias.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_calorias.TabIndex = 30;
            this.btn_calorias.Tag = "Cyber";
            this.btn_calorias.TextButton = "Calcular Calorias";
            this.btn_calorias.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_calorias.Timer_Effect_1 = 5;
            this.btn_calorias.Timer_RGB = 300;
            this.btn_calorias.Click += new System.EventHandler(this.btn_calorias_Click);
            // 
            // cbb_tipo_atividade
            // 
            this.cbb_tipo_atividade.BackColor = System.Drawing.Color.LightGray;
            this.cbb_tipo_atividade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_tipo_atividade.FormattingEnabled = true;
            this.cbb_tipo_atividade.Items.AddRange(new object[] {
            "Pouco ou nenhum exercício",
            "Exercício leve 1–3 dias/semana",
            "Exercício moderado 3–5 dias/semana",
            "Exercício intenso 6–7 dias/semana",
            "Treinos muito intensos ou 2x por dia"});
            this.cbb_tipo_atividade.Location = new System.Drawing.Point(229, 166);
            this.cbb_tipo_atividade.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tipo_atividade.Name = "cbb_tipo_atividade";
            this.cbb_tipo_atividade.Size = new System.Drawing.Size(349, 28);
            this.cbb_tipo_atividade.TabIndex = 28;
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel3.Location = new System.Drawing.Point(20, 98);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(251, 38);
            this.bigLabel3.TabIndex = 27;
            this.bigLabel3.Text = "Calorias Progresso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(21, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tipo de Atividade:";
            // 
            // lbl_calculadora
            // 
            this.lbl_calculadora.AutoSize = true;
            this.lbl_calculadora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_calculadora.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calculadora.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_calculadora.Location = new System.Drawing.Point(8, 23);
            this.lbl_calculadora.Name = "lbl_calculadora";
            this.lbl_calculadora.Size = new System.Drawing.Size(429, 57);
            this.lbl_calculadora.TabIndex = 26;
            this.lbl_calculadora.Text = "Calculadora Calórica";
            // 
            // alimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 601);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "alimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            this.pn_opcoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabs_comida.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.calculadora.ResumeLayout(false);
            this.calculadora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pn_opcoes;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_appoitments;
        private System.Windows.Forms.Button btn_workouts;
        private System.Windows.Forms.Button btn_food;
        private System.Windows.Forms.Button btn_motivacao;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MetroTabControl tabs_comida;
        private ReaLTaiizor.Child.Metro.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_inserirRefeicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_tipoRefeicao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nomeComida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_calorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_listaRefeicao;
        private ReaLTaiizor.Child.Metro.MetroTabPage calculadora;
        private System.Windows.Forms.Label lbl_objetivo;
        protected internal ReaLTaiizor.Controls.BigLabel lbl_objetivo_calorias;
        private System.Windows.Forms.Label lbl_perder;
        private System.Windows.Forms.Label lbl_ganhar;
        private System.Windows.Forms.Label lbl_normal;
        private System.Windows.Forms.Label lbl_tituloGanhar;
        private System.Windows.Forms.Label lbl_tituloManter;
        private System.Windows.Forms.Label lbl_tituloperder;
        private System.Windows.Forms.TextBox tb_atualizarCalorias;
        private System.Windows.Forms.Label lbl_atualizar;
        private ReaLTaiizor.Controls.CyberButton btn_atualizarCaloriasObjetivo;
        private System.Windows.Forms.ProgressBar probar_calorias;
        private ReaLTaiizor.Controls.CyberButton btn_calorias;
        private System.Windows.Forms.ComboBox cbb_tipo_atividade;
        protected internal ReaLTaiizor.Controls.BigLabel bigLabel3;
        private System.Windows.Forms.Label label6;
        private ReaLTaiizor.Controls.BigLabel lbl_calculadora;
        private System.Windows.Forms.Label lbl_caloriasIngeridas;
        protected internal ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}