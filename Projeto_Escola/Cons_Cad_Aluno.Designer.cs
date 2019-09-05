namespace Projeto_Escola
{
    partial class Cons_Cad_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cons_Cad_Aluno));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_escolha = new System.Windows.Forms.ComboBox();
            this.txt_pesq = new System.Windows.Forms.TextBox();
            this.dgv_aluno = new System.Windows.Forms.DataGridView();
            this.btnquant = new System.Windows.Forms.Button();
            this.btnvisu = new System.Windows.Forms.Button();
            this.btnimp = new System.Windows.Forms.Button();
            this.tpAlu = new System.Windows.Forms.ToolTip(this.components);
            this.pDocAluno = new System.Drawing.Printing.PrintDocument();
            this.ptPPAluno = new System.Windows.Forms.PrintPreviewDialog();
            this.ptDiaAluno = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha o campo a ser pesquisado:";
            // 
            // cmb_escolha
            // 
            this.cmb_escolha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_escolha.FormattingEnabled = true;
            this.cmb_escolha.Items.AddRange(new object[] {
            "Matrícula",
            "Nome",
            "Bairro",
            "Data de Nascimento",
            "Sexo",
            "RG",
            "CPF",
            "Endereço",
            "Telefone",
            "CEP",
            "Número da Residência",
            "Cidade"});
            this.cmb_escolha.Location = new System.Drawing.Point(10, 49);
            this.cmb_escolha.Name = "cmb_escolha";
            this.cmb_escolha.Size = new System.Drawing.Size(174, 27);
            this.cmb_escolha.TabIndex = 3;
            this.cmb_escolha.Text = "Escolha";
            // 
            // txt_pesq
            // 
            this.txt_pesq.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesq.Location = new System.Drawing.Point(191, 49);
            this.txt_pesq.Name = "txt_pesq";
            this.txt_pesq.Size = new System.Drawing.Size(290, 26);
            this.txt_pesq.TabIndex = 4;
            this.txt_pesq.TextChanged += new System.EventHandler(this.txt_pesq_TextChanged);
            // 
            // dgv_aluno
            // 
            this.dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aluno.Location = new System.Drawing.Point(10, 84);
            this.dgv_aluno.Name = "dgv_aluno";
            this.dgv_aluno.Size = new System.Drawing.Size(471, 215);
            this.dgv_aluno.TabIndex = 5;
            // 
            // btnquant
            // 
            this.btnquant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquant.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquant.Image = ((System.Drawing.Image)(resources.GetObject("btnquant.Image")));
            this.btnquant.Location = new System.Drawing.Point(431, 303);
            this.btnquant.Name = "btnquant";
            this.btnquant.Size = new System.Drawing.Size(50, 43);
            this.btnquant.TabIndex = 9;
            this.tpAlu.SetToolTip(this.btnquant, "Quantidade de Selecionados");
            this.btnquant.UseVisualStyleBackColor = false;
            this.btnquant.Click += new System.EventHandler(this.btnquant_Click);
            // 
            // btnvisu
            // 
            this.btnvisu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvisu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvisu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvisu.Image = ((System.Drawing.Image)(resources.GetObject("btnvisu.Image")));
            this.btnvisu.Location = new System.Drawing.Point(64, 306);
            this.btnvisu.Name = "btnvisu";
            this.btnvisu.Size = new System.Drawing.Size(49, 43);
            this.btnvisu.TabIndex = 8;
            this.tpAlu.SetToolTip(this.btnvisu, "Visualizar");
            this.btnvisu.UseVisualStyleBackColor = false;
            this.btnvisu.Click += new System.EventHandler(this.btnvisu_Click);
            // 
            // btnimp
            // 
            this.btnimp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnimp.Image = ((System.Drawing.Image)(resources.GetObject("btnimp.Image")));
            this.btnimp.Location = new System.Drawing.Point(10, 306);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(44, 43);
            this.btnimp.TabIndex = 7;
            this.tpAlu.SetToolTip(this.btnimp, "Imprimir");
            this.btnimp.UseVisualStyleBackColor = false;
            this.btnimp.Click += new System.EventHandler(this.btnimp_Click);
            // 
            // pDocAluno
            // 
            this.pDocAluno.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDocAluno_PrintPage);
            // 
            // ptPPAluno
            // 
            this.ptPPAluno.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ptPPAluno.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ptPPAluno.ClientSize = new System.Drawing.Size(400, 300);
            this.ptPPAluno.Document = this.pDocAluno;
            this.ptPPAluno.Enabled = true;
            this.ptPPAluno.Icon = ((System.Drawing.Icon)(resources.GetObject("ptPPAluno.Icon")));
            this.ptPPAluno.Name = "ptPPAluno";
            this.ptPPAluno.Visible = false;
            // 
            // ptDiaAluno
            // 
            this.ptDiaAluno.Document = this.pDocAluno;
            this.ptDiaAluno.UseEXDialog = true;
            // 
            // Cons_Cad_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(490, 357);
            this.Controls.Add(this.btnquant);
            this.Controls.Add(this.btnvisu);
            this.Controls.Add(this.btnimp);
            this.Controls.Add(this.dgv_aluno);
            this.Controls.Add(this.txt_pesq);
            this.Controls.Add(this.cmb_escolha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cons_Cad_Aluno";
            this.Text = "Consulta Cadastral de Aluno";
            this.Load += new System.EventHandler(this.Cons_Cad_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_escolha;
        private System.Windows.Forms.TextBox txt_pesq;
        private System.Windows.Forms.DataGridView dgv_aluno;
        private System.Windows.Forms.Button btnquant;
        private System.Windows.Forms.Button btnvisu;
        private System.Windows.Forms.Button btnimp;
        private System.Windows.Forms.ToolTip tpAlu;
        private System.Drawing.Printing.PrintDocument pDocAluno;
        private System.Windows.Forms.PrintPreviewDialog ptPPAluno;
        private System.Windows.Forms.PrintDialog ptDiaAluno;

    }
}