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
            this.tb_calorias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeComida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_tipoRefeicao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inserirRefeicao = new System.Windows.Forms.Button();
            this.lb_listaRefeicao = new System.Windows.Forms.ListBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            this.pn_opcoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // tb_calorias
            // 
            this.tb_calorias.BackColor = System.Drawing.Color.LightGray;
            this.tb_calorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_calorias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_calorias.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_calorias.Location = new System.Drawing.Point(231, 198);
            this.tb_calorias.Name = "tb_calorias";
            this.tb_calorias.Size = new System.Drawing.Size(211, 33);
            this.tb_calorias.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(150, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Calorias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(74, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nome da comida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(81, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tipo de refeição:";
            // 
            // tb_nomeComida
            // 
            this.tb_nomeComida.BackColor = System.Drawing.Color.LightGray;
            this.tb_nomeComida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nomeComida.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tb_nomeComida.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_nomeComida.Location = new System.Drawing.Point(231, 159);
            this.tb_nomeComida.Name = "tb_nomeComida";
            this.tb_nomeComida.Size = new System.Drawing.Size(211, 33);
            this.tb_nomeComida.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(448, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "(à escolha)";
            // 
            // cbb_tipoRefeicao
            // 
            this.cbb_tipoRefeicao.BackColor = System.Drawing.Color.LightGray;
            this.cbb_tipoRefeicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_tipoRefeicao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tipoRefeicao.FormattingEnabled = true;
            this.cbb_tipoRefeicao.Location = new System.Drawing.Point(231, 118);
            this.cbb_tipoRefeicao.Name = "cbb_tipoRefeicao";
            this.cbb_tipoRefeicao.Size = new System.Drawing.Size(211, 33);
            this.cbb_tipoRefeicao.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(113, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Inserir Refeição";
            // 
            // btn_inserirRefeicao
            // 
            this.btn_inserirRefeicao.BackColor = System.Drawing.Color.LightGray;
            this.btn_inserirRefeicao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_inserirRefeicao.FlatAppearance.BorderSize = 5;
            this.btn_inserirRefeicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_inserirRefeicao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirRefeicao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_inserirRefeicao.Location = new System.Drawing.Point(543, 141);
            this.btn_inserirRefeicao.Name = "btn_inserirRefeicao";
            this.btn_inserirRefeicao.Size = new System.Drawing.Size(95, 64);
            this.btn_inserirRefeicao.TabIndex = 35;
            this.btn_inserirRefeicao.Text = "Inserir";
            this.btn_inserirRefeicao.UseVisualStyleBackColor = false;
            this.btn_inserirRefeicao.Click += new System.EventHandler(this.btn_inserirRefeicao_Click);
            this.btn_inserirRefeicao.MouseHover += new System.EventHandler(this.btn_inserirRefeicao_MouseHover);
            // 
            // lb_listaRefeicao
            // 
            this.lb_listaRefeicao.BackColor = System.Drawing.Color.LightGray;
            this.lb_listaRefeicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_listaRefeicao.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_listaRefeicao.FormattingEnabled = true;
            this.lb_listaRefeicao.ItemHeight = 21;
            this.lb_listaRefeicao.Location = new System.Drawing.Point(79, 263);
            this.lb_listaRefeicao.Name = "lb_listaRefeicao";
            this.lb_listaRefeicao.Size = new System.Drawing.Size(663, 212);
            this.lb_listaRefeicao.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pb_menu);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 41);
            this.panel3.TabIndex = 7;
            // 
            // pb_menu
            // 
            this.pb_menu.Image = ((System.Drawing.Image)(resources.GetObject("pb_menu.Image")));
            this.pb_menu.Location = new System.Drawing.Point(-3, 5);
            this.pb_menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Padding = new System.Windows.Forms.Padding(11, 4, 0, 0);
            this.pb_menu.Size = new System.Drawing.Size(38, 28);
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
            this.label2.Location = new System.Drawing.Point(59, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
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
            this.pn_opcoes.Location = new System.Drawing.Point(1, 41);
            this.pn_opcoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_opcoes.Name = "pn_opcoes";
            this.pn_opcoes.Size = new System.Drawing.Size(40, 338);
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
            this.btn_home.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(238, 43);
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
            this.btn_appoitments.Location = new System.Drawing.Point(0, 49);
            this.btn_appoitments.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_appoitments.Name = "btn_appoitments";
            this.btn_appoitments.Size = new System.Drawing.Size(238, 41);
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
            this.btn_workouts.Location = new System.Drawing.Point(0, 96);
            this.btn_workouts.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_workouts.Name = "btn_workouts";
            this.btn_workouts.Size = new System.Drawing.Size(238, 43);
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
            this.btn_food.Location = new System.Drawing.Point(0, 145);
            this.btn_food.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_food.Name = "btn_food";
            this.btn_food.Size = new System.Drawing.Size(238, 43);
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
            this.btn_motivacao.Location = new System.Drawing.Point(0, 194);
            this.btn_motivacao.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_motivacao.Name = "btn_motivacao";
            this.btn_motivacao.Size = new System.Drawing.Size(238, 42);
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
            this.bt_logout.Location = new System.Drawing.Point(0, 242);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(238, 43);
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
            this.btn_exit.Location = new System.Drawing.Point(0, 291);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(238, 42);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pn_opcoes);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_inserirRefeicao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbb_tipoRefeicao);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_nomeComida);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_calorias);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lb_listaRefeicao);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 487);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(659, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 66);
            this.panel2.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(118, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 5);
            this.panel4.TabIndex = 42;
            // 
            // alimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "alimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            this.pn_opcoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.TextBox tb_calorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeComida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_tipoRefeicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inserirRefeicao;
        private System.Windows.Forms.ListBox lb_listaRefeicao;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}