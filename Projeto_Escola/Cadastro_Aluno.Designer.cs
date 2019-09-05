namespace Projeto_Escola
{
    partial class Cadastro_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Aluno));
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.cbsexo = new System.Windows.Forms.ComboBox();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.dtpnasc = new System.Windows.Forms.DateTimePicker();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_primeiro = new System.Windows.Forms.Button();
            this.GBmanu = new System.Windows.Forms.GroupBox();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.GBnav = new System.Windows.Forms.GroupBox();
            this.divisor = new System.Windows.Forms.Label();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.dgv_aluno = new System.Windows.Forms.DataGridView();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.lblcid = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.tpA = new System.Windows.Forms.ToolTip(this.components);
            this.GBmanu.SuspendLayout();
            this.GBnav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(483, 169);
            this.txtnum.Margin = new System.Windows.Forms.Padding(2);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(76, 26);
            this.txtnum.TabIndex = 74;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(416, 169);
            this.lblnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(72, 19);
            this.lblnum.TabIndex = 73;
            this.lblnum.Text = "Número:";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(416, 140);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtcpf.Mask = "000,000,000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(143, 26);
            this.txtcpf.TabIndex = 72;
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(422, 230);
            this.txttel.Margin = new System.Windows.Forms.Padding(2);
            this.txttel.Mask = "(00) 0000-0000";
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(137, 26);
            this.txttel.TabIndex = 71;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(332, 230);
            this.lbltel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(90, 19);
            this.lbltel.TabIndex = 70;
            this.lbltel.Text = "Telefone:";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.Location = new System.Drawing.Point(6, 169);
            this.lblend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(90, 19);
            this.lblend.TabIndex = 69;
            this.lblend.Text = "Endereço:";
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(105, 165);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(292, 26);
            this.txtendereco.TabIndex = 68;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(375, 137);
            this.lblcpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(45, 19);
            this.lblcpf.TabIndex = 67;
            this.lblcpf.Text = "CPF:";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrg.Location = new System.Drawing.Point(9, 140);
            this.lblrg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(36, 19);
            this.lblrg.TabIndex = 65;
            this.lblrg.Text = "RG:";
            // 
            // cbsexo
            // 
            this.cbsexo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsexo.FormattingEnabled = true;
            this.cbsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbsexo.Location = new System.Drawing.Point(467, 108);
            this.cbsexo.Margin = new System.Windows.Forms.Padding(2);
            this.cbsexo.Name = "cbsexo";
            this.cbsexo.Size = new System.Drawing.Size(92, 27);
            this.cbsexo.TabIndex = 62;
            this.cbsexo.Text = "Escolha";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(412, 111);
            this.lblsexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(54, 19);
            this.lblsexo.TabIndex = 61;
            this.lblsexo.Text = "Sexo:";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(9, 9);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(198, 19);
            this.lbl_info.TabIndex = 60;
            this.lbl_info.Text = "Informações do Aluno:";
            // 
            // txtbairro
            // 
            this.txtbairro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.Location = new System.Drawing.Point(79, 196);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(296, 26);
            this.txtbairro.TabIndex = 59;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.Location = new System.Drawing.Point(8, 196);
            this.lblbairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(72, 19);
            this.lblbairro.TabIndex = 58;
            this.lblbairro.Text = "Bairro:";
            // 
            // dtpnasc
            // 
            this.dtpnasc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpnasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnasc.Location = new System.Drawing.Point(110, 106);
            this.dtpnasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpnasc.Name = "dtpnasc";
            this.dtpnasc.Size = new System.Drawing.Size(120, 26);
            this.dtpnasc.TabIndex = 57;
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(65, 75);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(494, 26);
            this.txt_nome.TabIndex = 56;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(9, 106);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(99, 19);
            this.lblData.TabIndex = 55;
            this.lblData.Text = "Data Nasc.";
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod.Location = new System.Drawing.Point(102, 51);
            this.lbl_cod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(36, 19);
            this.lbl_cod.TabIndex = 54;
            this.lbl_cod.Text = "cod";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 78);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 19);
            this.lblNome.TabIndex = 53;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 51);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(99, 19);
            this.lblCodigo.TabIndex = 52;
            this.lblCodigo.Text = "Matrícula:";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(418, 200);
            this.lblcep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(45, 19);
            this.lblcep.TabIndex = 75;
            this.lblcep.Text = "CEP:";
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(7, 271);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(107, 47);
            this.btnNovo.TabIndex = 24;
            this.tpA.SetToolTip(this.btnNovo, "Novo Cadastro");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.Location = new System.Drawing.Point(10, 149);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(97, 56);
            this.btn_alterar.TabIndex = 9;
            this.tpA.SetToolTip(this.btn_alterar, "Alterar");
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // pesquisar
            // 
            this.pesquisar.AutoSize = true;
            this.pesquisar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisar.Location = new System.Drawing.Point(16, 487);
            this.pesquisar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(180, 19);
            this.pesquisar.TabIndex = 81;
            this.pesquisar.Text = "Pesquisar por nome:";
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.Location = new System.Drawing.Point(8, 90);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(105, 56);
            this.btn_excluir.TabIndex = 8;
            this.tpA.SetToolTip(this.btn_excluir, "Excluir");
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisar.Location = new System.Drawing.Point(198, 487);
            this.txt_Pesquisar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(510, 26);
            this.txt_Pesquisar.TabIndex = 80;
            this.txt_Pesquisar.TextChanged += new System.EventHandler(this.txt_Pesquisar_TextChanged);
            // 
            // btn_incluir
            // 
            this.btn_incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_incluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_incluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluir.Image")));
            this.btn_incluir.Location = new System.Drawing.Point(7, 30);
            this.btn_incluir.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(107, 56);
            this.btn_incluir.TabIndex = 7;
            this.tpA.SetToolTip(this.btn_incluir, "Cadastrar");
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar.Image")));
            this.btn_limpar.Location = new System.Drawing.Point(5, 208);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(107, 56);
            this.btn_limpar.TabIndex = 10;
            this.tpA.SetToolTip(this.btn_limpar, "Limpar");
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_primeiro
            // 
            this.btn_primeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primeiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_primeiro.Image = ((System.Drawing.Image)(resources.GetObject("btn_primeiro.Image")));
            this.btn_primeiro.Location = new System.Drawing.Point(13, 28);
            this.btn_primeiro.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_primeiro.Name = "btn_primeiro";
            this.btn_primeiro.Size = new System.Drawing.Size(115, 36);
            this.btn_primeiro.TabIndex = 19;
            this.btn_primeiro.Tag = "";
            this.tpA.SetToolTip(this.btn_primeiro, "Primeiro");
            this.btn_primeiro.UseVisualStyleBackColor = true;
            this.btn_primeiro.Click += new System.EventHandler(this.btn_primeiro_Click);
            // 
            // GBmanu
            // 
            this.GBmanu.Controls.Add(this.btn_limpar);
            this.GBmanu.Controls.Add(this.btnNovo);
            this.GBmanu.Controls.Add(this.btn_alterar);
            this.GBmanu.Controls.Add(this.btn_excluir);
            this.GBmanu.Controls.Add(this.btn_incluir);
            this.GBmanu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBmanu.Location = new System.Drawing.Point(587, 51);
            this.GBmanu.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.GBmanu.Name = "GBmanu";
            this.GBmanu.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.GBmanu.Size = new System.Drawing.Size(119, 326);
            this.GBmanu.TabIndex = 78;
            this.GBmanu.TabStop = false;
            this.GBmanu.Text = "Manutenção";
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ultimo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.Image")));
            this.btn_ultimo.Location = new System.Drawing.Point(408, 30);
            this.btn_ultimo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(131, 36);
            this.btn_ultimo.TabIndex = 22;
            this.tpA.SetToolTip(this.btn_ultimo, "Último");
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // GBnav
            // 
            this.GBnav.Controls.Add(this.divisor);
            this.GBnav.Controls.Add(this.btn_primeiro);
            this.GBnav.Controls.Add(this.btn_ultimo);
            this.GBnav.Controls.Add(this.btn_anterior);
            this.GBnav.Controls.Add(this.btn_proximo);
            this.GBnav.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBnav.Location = new System.Drawing.Point(10, 389);
            this.GBnav.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.GBnav.Name = "GBnav";
            this.GBnav.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.GBnav.Size = new System.Drawing.Size(549, 80);
            this.GBnav.TabIndex = 79;
            this.GBnav.TabStop = false;
            this.GBnav.Text = "Navegação";
            // 
            // divisor
            // 
            this.divisor.AutoSize = true;
            this.divisor.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisor.Location = new System.Drawing.Point(265, 30);
            this.divisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.divisor.Name = "divisor";
            this.divisor.Size = new System.Drawing.Size(24, 36);
            this.divisor.TabIndex = 25;
            this.divisor.Text = "I";
            // 
            // btn_anterior
            // 
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("btn_anterior.Image")));
            this.btn_anterior.Location = new System.Drawing.Point(123, 28);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(110, 36);
            this.btn_anterior.TabIndex = 20;
            this.tpA.SetToolTip(this.btn_anterior, "Anterior");
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proximo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_proximo.Image = ((System.Drawing.Image)(resources.GetObject("btn_proximo.Image")));
            this.btn_proximo.Location = new System.Drawing.Point(307, 30);
            this.btn_proximo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(115, 36);
            this.btn_proximo.TabIndex = 21;
            this.tpA.SetToolTip(this.btn_proximo, "Próximo");
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // dgv_aluno
            // 
            this.dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aluno.Location = new System.Drawing.Point(10, 263);
            this.dgv_aluno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_aluno.Name = "dgv_aluno";
            this.dgv_aluno.Size = new System.Drawing.Size(549, 114);
            this.dgv_aluno.TabIndex = 77;
            this.dgv_aluno.Click += new System.EventHandler(this.dgv_aluno_Click);
            this.dgv_aluno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_aluno_KeyUp);
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(79, 226);
            this.txtcid.Margin = new System.Windows.Forms.Padding(2);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(247, 26);
            this.txtcid.TabIndex = 82;
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcid.Location = new System.Drawing.Point(6, 224);
            this.lblcid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(72, 19);
            this.lblcid.TabIndex = 83;
            this.lblcid.Text = "Cidade:";
            // 
            // txtrg
            // 
            this.txtrg.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(40, 135);
            this.txtrg.Mask = "00,000,000-0";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(122, 26);
            this.txtrg.TabIndex = 84;
            // 
            // txtcep
            // 
            this.txtcep.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.Location = new System.Drawing.Point(467, 200);
            this.txtcep.Mask = "00000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(92, 26);
            this.txtcep.TabIndex = 85;
            // 
            // Cadastro_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(714, 535);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.lblcid);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.txt_Pesquisar);
            this.Controls.Add(this.GBmanu);
            this.Controls.Add(this.GBnav);
            this.Controls.Add(this.dgv_aluno);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.cbsexo);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.dtpnasc);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cadastro_Aluno";
            this.Text = "Cadastro de Aluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Aluno_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_Aluno_Load);
            this.GBmanu.ResumeLayout(false);
            this.GBnav.ResumeLayout(false);
            this.GBnav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txttel;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.ComboBox cbsexo;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.DateTimePicker dtpnasc;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label pesquisar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_primeiro;
        private System.Windows.Forms.GroupBox GBmanu;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.GroupBox GBnav;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.DataGridView dgv_aluno;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.ToolTip tpA;
        private System.Windows.Forms.Label divisor;
    }
}