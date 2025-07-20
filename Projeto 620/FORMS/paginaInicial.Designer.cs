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
            this.pb_menu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.pan_color = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.lbl_ola = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.pn_opcoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_appoitments = new System.Windows.Forms.Button();
            this.btn_workouts = new System.Windows.Forms.Button();
            this.btn_food = new System.Windows.Forms.Button();
            this.btn_motivacao = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ficheiro = new System.Windows.Forms.OpenFileDialog();
            this.cbb_sexo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_tipo_atividade = new System.Windows.Forms.ComboBox();
            this.btn_calorias = new ReaLTaiizor.Controls.CyberButton();
            this.probar_calorias = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn_opcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_menu
            // 
            this.pb_menu.Image = ((System.Drawing.Image)(resources.GetObject("pb_menu.Image")));
            this.pb_menu.Location = new System.Drawing.Point(-5, 6);
            this.pb_menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Padding = new System.Windows.Forms.Padding(11, 4, 0, 0);
            this.pb_menu.Size = new System.Drawing.Size(38, 28);
            this.pb_menu.TabIndex = 3;
            this.pb_menu.TabStop = false;
            this.pb_menu.Click += new System.EventHandler(this.pb_menu_Click);
            this.pb_menu.MouseHover += new System.EventHandler(this.pb_menu_MouseHover_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.pan_color);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 41);
            this.panel1.TabIndex = 4;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = false;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(646, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 17;
            this.nightControlBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nightControlBox1_MouseClick);
            // 
            // pan_color
            // 
            this.pan_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pan_color.Location = new System.Drawing.Point(45, 43);
            this.pan_color.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pan_color.Name = "pan_color";
            this.pan_color.Size = new System.Drawing.Size(705, 448);
            this.pan_color.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Perfil";
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel1.Location = new System.Drawing.Point(541, 72);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(167, 45);
            this.bigLabel1.TabIndex = 7;
            this.bigLabel1.Text = "Objetivos";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel2.Location = new System.Drawing.Point(377, 146);
            this.bigLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(156, 30);
            this.bigLabel2.TabIndex = 9;
            this.bigLabel2.Text = "Exercicio Feito:";
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel3.Location = new System.Drawing.Point(439, 219);
            this.bigLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(94, 30);
            this.bigLabel3.TabIndex = 10;
            this.bigLabel3.Text = "Calorias:";
            // 
            // lbl_ola
            // 
            this.lbl_ola.AutoSize = true;
            this.lbl_ola.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ola.Location = new System.Drawing.Point(61, 50);
            this.lbl_ola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ola.Name = "lbl_ola";
            this.lbl_ola.Size = new System.Drawing.Size(71, 39);
            this.lbl_ola.TabIndex = 14;
            this.lbl_ola.Text = "Olá";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome.Location = new System.Drawing.Point(133, 53);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(0, 37);
            this.lbl_nome.TabIndex = 15;
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
            this.pn_opcoes.Location = new System.Drawing.Point(0, 43);
            this.pn_opcoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_opcoes.Name = "pn_opcoes";
            this.pn_opcoes.Size = new System.Drawing.Size(38, 338);
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
            this.btn_home.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(238, 43);
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
            this.btn_appoitments.Location = new System.Drawing.Point(0, 49);
            this.btn_appoitments.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_appoitments.Name = "btn_appoitments";
            this.btn_appoitments.Size = new System.Drawing.Size(238, 41);
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
            this.btn_workouts.Location = new System.Drawing.Point(0, 96);
            this.btn_workouts.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_workouts.Name = "btn_workouts";
            this.btn_workouts.Size = new System.Drawing.Size(238, 43);
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
            this.btn_food.Location = new System.Drawing.Point(0, 145);
            this.btn_food.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_food.Name = "btn_food";
            this.btn_food.Size = new System.Drawing.Size(238, 43);
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
            this.btn_motivacao.Location = new System.Drawing.Point(0, 194);
            this.btn_motivacao.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_motivacao.Name = "btn_motivacao";
            this.btn_motivacao.Size = new System.Drawing.Size(238, 42);
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
            this.bt_logout.Location = new System.Drawing.Point(0, 242);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(238, 43);
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
            this.btn_exit.Location = new System.Drawing.Point(0, 291);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(238, 42);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 109);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 186);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ficheiro
            // 
            this.ficheiro.FileName = "openFileDialog1";
            // 
            // cbb_sexo
            // 
            this.cbb_sexo.BackColor = System.Drawing.Color.LightGray;
            this.cbb_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_sexo.FormattingEnabled = true;
            this.cbb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
<<<<<<< Updated upstream
            this.cbb_sexo.Location = new System.Drawing.Point(724, 362);
            this.cbb_sexo.Name = "cbb_sexo";
            this.cbb_sexo.Size = new System.Drawing.Size(246, 24);
=======
            this.cbb_sexo.Location = new System.Drawing.Point(530, 294);
            this.cbb_sexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_sexo.Name = "cbb_sexo";
            this.cbb_sexo.Size = new System.Drawing.Size(199, 21);
>>>>>>> Stashed changes
            this.cbb_sexo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(476, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
<<<<<<< Updated upstream
            this.label3.Location = new System.Drawing.Point(485, 427);
=======
            this.label3.Location = new System.Drawing.Point(370, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
>>>>>>> Stashed changes
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tipo de Atividade:";
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
<<<<<<< Updated upstream
            this.cbb_tipo_atividade.Location = new System.Drawing.Point(724, 434);
            this.cbb_tipo_atividade.Name = "cbb_tipo_atividade";
            this.cbb_tipo_atividade.Size = new System.Drawing.Size(246, 24);
=======
            this.cbb_tipo_atividade.Location = new System.Drawing.Point(530, 353);
            this.cbb_tipo_atividade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_tipo_atividade.Name = "cbb_tipo_atividade";
            this.cbb_tipo_atividade.Size = new System.Drawing.Size(199, 21);
>>>>>>> Stashed changes
            this.cbb_tipo_atividade.TabIndex = 20;
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
            this.btn_calorias.Location = new System.Drawing.Point(560, 425);
            this.btn_calorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_calorias.Name = "btn_calorias";
            this.btn_calorias.PenWidth = 15;
            this.btn_calorias.Rounding = true;
            this.btn_calorias.RoundingInt = 70;
            this.btn_calorias.Size = new System.Drawing.Size(143, 43);
            this.btn_calorias.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_calorias.TabIndex = 22;
            this.btn_calorias.Tag = "Cyber";
            this.btn_calorias.TextButton = "Calcular Calorias";
            this.btn_calorias.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_calorias.Timer_Effect_1 = 5;
            this.btn_calorias.Timer_RGB = 300;
            this.btn_calorias.Click += new System.EventHandler(this.btn_calorias_Click);
            // 
            // probar_calorias
            // 
            this.probar_calorias.Location = new System.Drawing.Point(530, 219);
            this.probar_calorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.probar_calorias.Name = "probar_calorias";
            this.probar_calorias.Size = new System.Drawing.Size(198, 32);
            this.probar_calorias.TabIndex = 23;
            this.probar_calorias.Value = 50;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(530, 144);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(198, 35);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Value = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(518, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "afafaf";
            // 
            // paginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(1000, 601);
            this.Controls.Add(this.label4);
=======
            this.ClientSize = new System.Drawing.Size(750, 488);
>>>>>>> Stashed changes
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.probar_calorias);
            this.Controls.Add(this.btn_calorias);
            this.Controls.Add(this.cbb_tipo_atividade);
            this.Controls.Add(this.cbb_sexo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pn_opcoes);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_ola);
            this.Controls.Add(this.bigLabel3);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(750, 488);
            this.MinimumSize = new System.Drawing.Size(750, 488);
            this.Name = "paginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paginaInicial";
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_opcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pan_color;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        protected internal ReaLTaiizor.Controls.BigLabel bigLabel2;
        protected internal ReaLTaiizor.Controls.BigLabel bigLabel3;
        private System.Windows.Forms.Label lbl_ola;
        private System.Windows.Forms.Label lbl_nome;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel pn_opcoes;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_appoitments;
        private System.Windows.Forms.Button btn_workouts;
        private System.Windows.Forms.Button btn_food;
        private System.Windows.Forms.Button btn_motivacao;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog ficheiro;
        private System.Windows.Forms.ComboBox cbb_sexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_tipo_atividade;
        private ReaLTaiizor.Controls.CyberButton btn_calorias;
        private System.Windows.Forms.ProgressBar probar_calorias;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
    }
}