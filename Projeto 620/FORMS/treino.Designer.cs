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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(treino));
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_menu = new System.Windows.Forms.PictureBox();
            this.pn_opcoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_appoitments = new System.Windows.Forms.Button();
            this.btn_workouts = new System.Windows.Forms.Button();
            this.btn_food = new System.Windows.Forms.Button();
            this.btn_motivacao = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_tipoTreino = new System.Windows.Forms.ComboBox();
            this.tb_nomeTreino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_duracaoTreino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_inserirTreino = new System.Windows.Forms.Button();
            this.lb_listaTreino = new System.Windows.Forms.ListBox();
            this.pb_metaTreino = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            this.pn_opcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(479, 303);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(91, 46);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pb_metaTreino);
            this.panel1.Controls.Add(this.lb_listaTreino);
            this.panel1.Controls.Add(this.btn_inserirTreino);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_duracaoTreino);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_nomeTreino);
            this.panel1.Controls.Add(this.cbb_tipoTreino);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pn_opcoes);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 487);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pb_menu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 41);
            this.panel3.TabIndex = 8;
            // 
            // pb_menu
            // 
            this.pb_menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_menu.Image = ((System.Drawing.Image)(resources.GetObject("pb_menu.Image")));
            this.pb_menu.Location = new System.Drawing.Point(2, 9);
            this.pb_menu.Margin = new System.Windows.Forms.Padding(2);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Padding = new System.Windows.Forms.Padding(11, 4, 0, 0);
            this.pb_menu.Size = new System.Drawing.Size(38, 28);
            this.pb_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_menu.TabIndex = 8;
            this.pb_menu.TabStop = false;
            this.pb_menu.Click += new System.EventHandler(this.pb_menu_Click);
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
            this.pn_opcoes.Location = new System.Drawing.Point(0, 46);
            this.pn_opcoes.Margin = new System.Windows.Forms.Padding(2);
            this.pn_opcoes.Name = "pn_opcoes";
            this.pn_opcoes.Size = new System.Drawing.Size(38, 443);
            this.pn_opcoes.TabIndex = 7;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.btn_appoitments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.btn_workouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.btn_food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.btn_motivacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.bt_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inserir Treino";
            // 
            // cbb_tipoTreino
            // 
            this.cbb_tipoTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cbb_tipoTreino.FormattingEnabled = true;
            this.cbb_tipoTreino.Location = new System.Drawing.Point(229, 118);
            this.cbb_tipoTreino.Name = "cbb_tipoTreino";
            this.cbb_tipoTreino.Size = new System.Drawing.Size(211, 30);
            this.cbb_tipoTreino.TabIndex = 10;
            // 
            // tb_nomeTreino
            // 
            this.tb_nomeTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.tb_nomeTreino.Location = new System.Drawing.Point(229, 159);
            this.tb_nomeTreino.Name = "tb_nomeTreino";
            this.tb_nomeTreino.Size = new System.Drawing.Size(211, 27);
            this.tb_nomeTreino.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(44, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Treino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.72F);
            this.label3.Location = new System.Drawing.Point(91, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo de treino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.72F);
            this.label4.Location = new System.Drawing.Point(77, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome do treino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.72F);
            this.label5.Location = new System.Drawing.Point(58, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Duração do treino:";
            // 
            // tb_duracaoTreino
            // 
            this.tb_duracaoTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.tb_duracaoTreino.Location = new System.Drawing.Point(229, 198);
            this.tb_duracaoTreino.Name = "tb_duracaoTreino";
            this.tb_duracaoTreino.Size = new System.Drawing.Size(211, 27);
            this.tb_duracaoTreino.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.72F);
            this.label6.Location = new System.Drawing.Point(43, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Calorias queimadas:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBox1.Location = new System.Drawing.Point(229, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 27);
            this.textBox1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.72F);
            this.label7.Location = new System.Drawing.Point(446, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "(à escolha)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.72F);
            this.label8.Location = new System.Drawing.Point(446, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "(em min)";
            // 
            // btn_inserirTreino
            // 
            this.btn_inserirTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_inserirTreino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_inserirTreino.Location = new System.Drawing.Point(559, 143);
            this.btn_inserirTreino.Name = "btn_inserirTreino";
            this.btn_inserirTreino.Size = new System.Drawing.Size(95, 64);
            this.btn_inserirTreino.TabIndex = 20;
            this.btn_inserirTreino.Text = "Inserir";
            this.btn_inserirTreino.UseVisualStyleBackColor = true;
            // 
            // lb_listaTreino
            // 
            this.lb_listaTreino.FormattingEnabled = true;
            this.lb_listaTreino.Location = new System.Drawing.Point(389, 276);
            this.lb_listaTreino.Name = "lb_listaTreino";
            this.lb_listaTreino.Size = new System.Drawing.Size(349, 199);
            this.lb_listaTreino.TabIndex = 21;
            // 
            // pb_metaTreino
            // 
            this.pb_metaTreino.Location = new System.Drawing.Point(116, 389);
            this.pb_metaTreino.Name = "pb_metaTreino";
            this.pb_metaTreino.Size = new System.Drawing.Size(179, 23);
            this.pb_metaTreino.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.72F);
            this.label9.Location = new System.Drawing.Point(91, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Progresso para meta definida:";
            // 
            // treino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sair);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "treino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "treino";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            this.pn_opcoes.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.TextBox tb_nomeTreino;
        private System.Windows.Forms.ComboBox cbb_tipoTreino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_duracaoTreino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar pb_metaTreino;
        private System.Windows.Forms.ListBox lb_listaTreino;
        private System.Windows.Forms.Button btn_inserirTreino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}