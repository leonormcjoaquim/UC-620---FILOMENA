namespace Projeto_620.FORMS
{
    partial class treino
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(treino));
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_inserir = new ReaLTaiizor.Controls.CyberButton();
            this.pn_opcoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_appoitments = new System.Windows.Forms.Button();
            this.btn_workouts = new System.Windows.Forms.Button();
            this.btn_food = new System.Windows.Forms.Button();
            this.btn_motivacao = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriasQueimadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exercicioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_caloriasQueimadas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_duracaoTreino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeTreino = new System.Windows.Forms.TextBox();
            this.cbb_tipoTreino = new System.Windows.Forms.ComboBox();
            this.lbl_inserirTreino = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_menu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exercicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pn_opcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercicioBindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(639, 373);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(121, 57);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_inserir);
            this.panel1.Controls.Add(this.pn_opcoes);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_caloriasQueimadas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_duracaoTreino);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_nomeTreino);
            this.panel1.Controls.Add(this.cbb_tipoTreino);
            this.panel1.Controls.Add(this.lbl_inserirTreino);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 606);
            this.panel1.TabIndex = 1;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Alpha = 20;
            this.btn_inserir.BackColor = System.Drawing.Color.Transparent;
            this.btn_inserir.Background = true;
            this.btn_inserir.Background_WidthPen = 4F;
            this.btn_inserir.BackgroundPen = true;
            this.btn_inserir.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_inserir.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_inserir.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_inserir.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_inserir.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_inserir.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btn_inserir.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btn_inserir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btn_inserir.Effect_1 = true;
            this.btn_inserir.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.btn_inserir.Effect_1_Transparency = 25;
            this.btn_inserir.Effect_2 = true;
            this.btn_inserir.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.btn_inserir.Effect_2_Transparency = 20;
            this.btn_inserir.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_inserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_inserir.Lighting = false;
            this.btn_inserir.LinearGradient_Background = false;
            this.btn_inserir.LinearGradientPen = false;
            this.btn_inserir.Location = new System.Drawing.Point(719, 233);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.PenWidth = 15;
            this.btn_inserir.Rounding = true;
            this.btn_inserir.RoundingInt = 70;
            this.btn_inserir.Size = new System.Drawing.Size(150, 70);
            this.btn_inserir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_inserir.TabIndex = 45;
            this.btn_inserir.Tag = "Cyber";
            this.btn_inserir.TextButton = "Inserir";
            this.btn_inserir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btn_inserir.Timer_Effect_1 = 5;
            this.btn_inserir.Timer_RGB = 300;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
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
            this.pn_opcoes.Location = new System.Drawing.Point(-1, 50);
            this.pn_opcoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_opcoes.Name = "pn_opcoes";
            this.pn_opcoes.Size = new System.Drawing.Size(53, 416);
            this.pn_opcoes.TabIndex = 7;
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
            this.bt_logout.MouseHover += new System.EventHandler(this.bt_logout_MouseHover);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.duracaoDataGridViewTextBoxColumn,
            this.caloriasQueimadasDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exercicioBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(81, 340);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(903, 245);
            this.dataGridView1.TabIndex = 44;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 73;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // duracaoDataGridViewTextBoxColumn
            // 
            this.duracaoDataGridViewTextBoxColumn.DataPropertyName = "Duracao";
            this.duracaoDataGridViewTextBoxColumn.HeaderText = "Duracao";
            this.duracaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duracaoDataGridViewTextBoxColumn.Name = "duracaoDataGridViewTextBoxColumn";
            this.duracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.duracaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // caloriasQueimadasDataGridViewTextBoxColumn
            // 
            this.caloriasQueimadasDataGridViewTextBoxColumn.DataPropertyName = "CaloriasQueimadas";
            this.caloriasQueimadasDataGridViewTextBoxColumn.HeaderText = "CaloriasQueimadas";
            this.caloriasQueimadasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caloriasQueimadasDataGridViewTextBoxColumn.Name = "caloriasQueimadasDataGridViewTextBoxColumn";
            this.caloriasQueimadasDataGridViewTextBoxColumn.ReadOnly = true;
            this.caloriasQueimadasDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // exercicioBindingSource1
            // 
            this.exercicioBindingSource1.DataSource = typeof(Projeto_620.models.Exercicio);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label8.Location = new System.Drawing.Point(591, 233);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "(em min)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label7.Location = new System.Drawing.Point(591, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "(à escolha)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label6.Location = new System.Drawing.Point(53, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Calorias queimadas:";
            // 
            // tb_caloriasQueimadas
            // 
            this.tb_caloriasQueimadas.BackColor = System.Drawing.Color.LightGray;
            this.tb_caloriasQueimadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_caloriasQueimadas.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tb_caloriasQueimadas.Location = new System.Drawing.Point(301, 267);
            this.tb_caloriasQueimadas.Margin = new System.Windows.Forms.Padding(4);
            this.tb_caloriasQueimadas.Name = "tb_caloriasQueimadas";
            this.tb_caloriasQueimadas.Size = new System.Drawing.Size(281, 39);
            this.tb_caloriasQueimadas.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label5.Location = new System.Drawing.Point(73, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Duração do treino:";
            // 
            // tb_duracaoTreino
            // 
            this.tb_duracaoTreino.BackColor = System.Drawing.Color.LightGray;
            this.tb_duracaoTreino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_duracaoTreino.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tb_duracaoTreino.Location = new System.Drawing.Point(301, 220);
            this.tb_duracaoTreino.Margin = new System.Windows.Forms.Padding(4);
            this.tb_duracaoTreino.Name = "tb_duracaoTreino";
            this.tb_duracaoTreino.Size = new System.Drawing.Size(281, 39);
            this.tb_duracaoTreino.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(99, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome do treino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.Location = new System.Drawing.Point(117, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo de treino:";
            // 
            // tb_nomeTreino
            // 
            this.tb_nomeTreino.BackColor = System.Drawing.Color.LightGray;
            this.tb_nomeTreino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nomeTreino.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tb_nomeTreino.Location = new System.Drawing.Point(301, 172);
            this.tb_nomeTreino.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nomeTreino.Name = "tb_nomeTreino";
            this.tb_nomeTreino.Size = new System.Drawing.Size(281, 39);
            this.tb_nomeTreino.TabIndex = 11;
            // 
            // cbb_tipoTreino
            // 
            this.cbb_tipoTreino.BackColor = System.Drawing.Color.LightGray;
            this.cbb_tipoTreino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_tipoTreino.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbb_tipoTreino.FormattingEnabled = true;
            this.cbb_tipoTreino.Location = new System.Drawing.Point(301, 122);
            this.cbb_tipoTreino.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tipoTreino.Name = "cbb_tipoTreino";
            this.cbb_tipoTreino.Size = new System.Drawing.Size(280, 40);
            this.cbb_tipoTreino.TabIndex = 10;
            // 
            // lbl_inserirTreino
            // 
            this.lbl_inserirTreino.AutoSize = true;
            this.lbl_inserirTreino.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inserirTreino.Location = new System.Drawing.Point(115, 58);
            this.lbl_inserirTreino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inserirTreino.Name = "lbl_inserirTreino";
            this.lbl_inserirTreino.Size = new System.Drawing.Size(233, 46);
            this.lbl_inserirTreino.TabIndex = 9;
            this.lbl_inserirTreino.Text = "Inserir Treino";
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
            this.panel3.Size = new System.Drawing.Size(1007, 50);
            this.panel3.TabIndex = 8;
            // 
            // pb_menu
            // 
            this.pb_menu.Image = ((System.Drawing.Image)(resources.GetObject("pb_menu.Image")));
            this.pb_menu.Location = new System.Drawing.Point(-7, 6);
            this.pb_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.pb_menu.Size = new System.Drawing.Size(51, 34);
            this.pb_menu.TabIndex = 41;
            this.pb_menu.TabStop = false;
            this.pb_menu.Click += new System.EventHandler(this.pb_menu_Click_1);
            this.pb_menu.MouseHover += new System.EventHandler(this.pb_menu_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(57, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Treino";
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Projeto_620.models.User);
            // 
            // alimentacaoBindingSource
            // 
            this.alimentacaoBindingSource.DataSource = typeof(Projeto_620.models.Alimentacao);
            // 
            // exercicioBindingSource
            // 
            this.exercicioBindingSource.DataSource = typeof(Projeto_620.models.Exercicio);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(856, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // treino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sair);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "treino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "treino";
            this.Load += new System.EventHandler(this.form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_opcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercicioBindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pn_opcoes;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_appoitments;
        private System.Windows.Forms.Button btn_workouts;
        private System.Windows.Forms.Button btn_food;
        private System.Windows.Forms.Button btn_motivacao;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.TextBox tb_nomeTreino;
        private System.Windows.Forms.ComboBox cbb_tipoTreino;
        private System.Windows.Forms.Label lbl_inserirTreino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_duracaoTreino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_caloriasQueimadas;
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.BindingSource alimentacaoBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource exercicioBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource exercicioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriasQueimadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private ReaLTaiizor.Controls.CyberButton btn_inserir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}