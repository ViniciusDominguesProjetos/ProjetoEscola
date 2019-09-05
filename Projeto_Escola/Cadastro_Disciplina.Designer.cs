namespace Projeto_Escola
{
    partial class Cadastro_Disciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Disciplina));
            this.lbl_info = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtser = new System.Windows.Forms.TextBox();
            this.lblser = new System.Windows.Forms.Label();
            this.txtsig = new System.Windows.Forms.TextBox();
            this.lblsig = new System.Windows.Forms.Label();
            this.pesquisar = new System.Windows.Forms.Label();
            this.btn_primeiro = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.GBmanu = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.GBnav = new System.Windows.Forms.GroupBox();
            this.dgv_disc = new System.Windows.Forms.DataGridView();
            this.tpD = new System.Windows.Forms.ToolTip(this.components);
            this.divisor = new System.Windows.Forms.Label();
            this.GBmanu.SuspendLayout();
            this.GBnav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(9, 11);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(296, 23);
            this.lbl_info.TabIndex = 65;
            this.lbl_info.Text = "Informações da Disciplina:";
            // 
            // txtdes
            // 
            this.txtdes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.Location = new System.Drawing.Point(137, 90);
            this.txtdes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(449, 31);
            this.txtdes.TabIndex = 64;
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod.Location = new System.Drawing.Point(105, 60);
            this.lbl_cod.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(43, 23);
            this.lbl_cod.TabIndex = 63;
            this.lbl_cod.Text = "cod";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(9, 90);
            this.lblDes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(120, 23);
            this.lblDes.TabIndex = 62;
            this.lblDes.Text = "Descrição:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 60);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 23);
            this.lblCodigo.TabIndex = 61;
            this.lblCodigo.Text = "Código:";
            // 
            // txtser
            // 
            this.txtser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtser.Location = new System.Drawing.Point(88, 164);
            this.txtser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtser.Name = "txtser";
            this.txtser.Size = new System.Drawing.Size(100, 31);
            this.txtser.TabIndex = 87;
            // 
            // lblser
            // 
            this.lblser.AutoSize = true;
            this.lblser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblser.Location = new System.Drawing.Point(9, 161);
            this.lblser.Name = "lblser";
            this.lblser.Size = new System.Drawing.Size(76, 23);
            this.lblser.TabIndex = 86;
            this.lblser.Text = "Série:";
            // 
            // txtsig
            // 
            this.txtsig.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsig.Location = new System.Drawing.Point(88, 127);
            this.txtsig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsig.Name = "txtsig";
            this.txtsig.Size = new System.Drawing.Size(132, 31);
            this.txtsig.TabIndex = 85;
            // 
            // lblsig
            // 
            this.lblsig.AutoSize = true;
            this.lblsig.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsig.Location = new System.Drawing.Point(9, 127);
            this.lblsig.Name = "lblsig";
            this.lblsig.Size = new System.Drawing.Size(76, 23);
            this.lblsig.TabIndex = 84;
            this.lblsig.Text = "Sigla:";
            // 
            // pesquisar
            // 
            this.pesquisar.AutoSize = true;
            this.pesquisar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisar.Location = new System.Drawing.Point(12, 549);
            this.pesquisar.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(274, 23);
            this.pesquisar.TabIndex = 94;
            this.pesquisar.Text = "Pesquisar por descrição:";
            // 
            // btn_primeiro
            // 
            this.btn_primeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primeiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_primeiro.Image = ((System.Drawing.Image)(resources.GetObject("btn_primeiro.Image")));
            this.btn_primeiro.Location = new System.Drawing.Point(14, 24);
            this.btn_primeiro.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btn_primeiro.Name = "btn_primeiro";
            this.btn_primeiro.Size = new System.Drawing.Size(121, 54);
            this.btn_primeiro.TabIndex = 19;
            this.btn_primeiro.Tag = "";
            this.tpD.SetToolTip(this.btn_primeiro, "Primeiro");
            this.btn_primeiro.UseVisualStyleBackColor = true;
            this.btn_primeiro.Click += new System.EventHandler(this.btn_primeiro_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ultimo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.Image")));
            this.btn_ultimo.Location = new System.Drawing.Point(411, 22);
            this.btn_ultimo.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(150, 55);
            this.btn_ultimo.TabIndex = 22;
            this.tpD.SetToolTip(this.btn_ultimo, "Último");
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("btn_anterior.Image")));
            this.btn_anterior.Location = new System.Drawing.Point(110, 24);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(142, 57);
            this.btn_anterior.TabIndex = 20;
            this.tpD.SetToolTip(this.btn_anterior, "Anterior");
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proximo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_proximo.Image = ((System.Drawing.Image)(resources.GetObject("btn_proximo.Image")));
            this.btn_proximo.Location = new System.Drawing.Point(311, 23);
            this.btn_proximo.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(148, 55);
            this.btn_proximo.TabIndex = 21;
            this.tpD.SetToolTip(this.btn_proximo, "Próximo");
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisar.Location = new System.Drawing.Point(314, 549);
            this.txt_Pesquisar.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(440, 31);
            this.txt_Pesquisar.TabIndex = 93;
            this.txt_Pesquisar.TextChanged += new System.EventHandler(this.txt_Pesquisar_TextChanged);
            // 
            // GBmanu
            // 
            this.GBmanu.Controls.Add(this.btn_limpar);
            this.GBmanu.Controls.Add(this.btnNovo);
            this.GBmanu.Controls.Add(this.btn_alterar);
            this.GBmanu.Controls.Add(this.btn_excluir);
            this.GBmanu.Controls.Add(this.btn_incluir);
            this.GBmanu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBmanu.Location = new System.Drawing.Point(597, 11);
            this.GBmanu.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.GBmanu.Name = "GBmanu";
            this.GBmanu.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.GBmanu.Size = new System.Drawing.Size(157, 410);
            this.GBmanu.TabIndex = 91;
            this.GBmanu.TabStop = false;
            this.GBmanu.Text = "Manutenção";
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar.Image")));
            this.btn_limpar.Location = new System.Drawing.Point(7, 256);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(143, 69);
            this.btn_limpar.TabIndex = 10;
            this.tpD.SetToolTip(this.btn_limpar, "Limpar");
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(9, 334);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(143, 58);
            this.btnNovo.TabIndex = 24;
            this.tpD.SetToolTip(this.btnNovo, "Novo Cadastro");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.Location = new System.Drawing.Point(13, 183);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(129, 69);
            this.btn_alterar.TabIndex = 9;
            this.tpD.SetToolTip(this.btn_alterar, "Alterar");
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.Location = new System.Drawing.Point(11, 111);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(140, 69);
            this.btn_excluir.TabIndex = 8;
            this.tpD.SetToolTip(this.btn_excluir, "Excluir");
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_incluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_incluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluir.Image")));
            this.btn_incluir.Location = new System.Drawing.Point(9, 37);
            this.btn_incluir.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(143, 69);
            this.btn_incluir.TabIndex = 7;
            this.tpD.SetToolTip(this.btn_incluir, "Cadastrar");
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // GBnav
            // 
            this.GBnav.Controls.Add(this.divisor);
            this.GBnav.Controls.Add(this.btn_primeiro);
            this.GBnav.Controls.Add(this.btn_ultimo);
            this.GBnav.Controls.Add(this.btn_anterior);
            this.GBnav.Controls.Add(this.btn_proximo);
            this.GBnav.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBnav.Location = new System.Drawing.Point(13, 438);
            this.GBnav.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.GBnav.Name = "GBnav";
            this.GBnav.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.GBnav.Size = new System.Drawing.Size(575, 92);
            this.GBnav.TabIndex = 92;
            this.GBnav.TabStop = false;
            this.GBnav.Text = "Navegação";
            this.tpD.SetToolTip(this.GBnav, "Anterior");
            // 
            // dgv_disc
            // 
            this.dgv_disc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disc.Location = new System.Drawing.Point(15, 204);
            this.dgv_disc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgv_disc.Name = "dgv_disc";
            this.dgv_disc.Size = new System.Drawing.Size(573, 217);
            this.dgv_disc.TabIndex = 90;
            this.dgv_disc.Click += new System.EventHandler(this.dgv_disc_Click);
            this.dgv_disc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_disc_KeyUp);
            // 
            // divisor
            // 
            this.divisor.AutoSize = true;
            this.divisor.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisor.Location = new System.Drawing.Point(271, 30);
            this.divisor.Name = "divisor";
            this.divisor.Size = new System.Drawing.Size(30, 45);
            this.divisor.TabIndex = 95;
            this.divisor.Text = "I";
            // 
            // Cadastro_Disciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(767, 596);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.txt_Pesquisar);
            this.Controls.Add(this.GBmanu);
            this.Controls.Add(this.GBnav);
            this.Controls.Add(this.dgv_disc);
            this.Controls.Add(this.txtser);
            this.Controls.Add(this.lblser);
            this.Controls.Add(this.txtsig);
            this.Controls.Add(this.lblsig);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cadastro_Disciplina";
            this.Text = "Cadastro de Disciplina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Disciplina_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_Disciplina_Load);
            this.GBmanu.ResumeLayout(false);
            this.GBnav.ResumeLayout(false);
            this.GBnav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtser;
        private System.Windows.Forms.Label lblser;
        private System.Windows.Forms.TextBox txtsig;
        private System.Windows.Forms.Label lblsig;
        private System.Windows.Forms.Label pesquisar;
        private System.Windows.Forms.Button btn_primeiro;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.GroupBox GBmanu;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.GroupBox GBnav;
        private System.Windows.Forms.DataGridView dgv_disc;
        private System.Windows.Forms.ToolTip tpD;
        private System.Windows.Forms.Label divisor;
    }
}