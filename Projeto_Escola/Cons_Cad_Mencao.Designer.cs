namespace Projeto_Escola
{
    partial class Cons_Cad_Mencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cons_Cad_Mencao));
            this.btnquant = new System.Windows.Forms.Button();
            this.btnvisu = new System.Windows.Forms.Button();
            this.btnimp = new System.Windows.Forms.Button();
            this.dgv_men = new System.Windows.Forms.DataGridView();
            this.txt_pesq = new System.Windows.Forms.TextBox();
            this.cmb_escolha = new System.Windows.Forms.ComboBox();
            this.lbes = new System.Windows.Forms.Label();
            this.tpMen = new System.Windows.Forms.ToolTip(this.components);
            this.pDocMen = new System.Drawing.Printing.PrintDocument();
            this.ptPPMen = new System.Windows.Forms.PrintPreviewDialog();
            this.ptDiaMen = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_men)).BeginInit();
            this.SuspendLayout();
            // 
            // btnquant
            // 
            this.btnquant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquant.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquant.Image = ((System.Drawing.Image)(resources.GetObject("btnquant.Image")));
            this.btnquant.Location = new System.Drawing.Point(250, 306);
            this.btnquant.Name = "btnquant";
            this.btnquant.Size = new System.Drawing.Size(50, 43);
            this.btnquant.TabIndex = 9;
            this.tpMen.SetToolTip(this.btnquant, "Quantidade de Selecionados");
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
            this.btnvisu.Location = new System.Drawing.Point(60, 306);
            this.btnvisu.Name = "btnvisu";
            this.btnvisu.Size = new System.Drawing.Size(49, 43);
            this.btnvisu.TabIndex = 8;
            this.tpMen.SetToolTip(this.btnvisu, "Visualizar");
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
            this.tpMen.SetToolTip(this.btnimp, "Imprimir");
            this.btnimp.UseVisualStyleBackColor = false;
            this.btnimp.Click += new System.EventHandler(this.btnimp_Click);
            // 
            // dgv_men
            // 
            this.dgv_men.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_men.Location = new System.Drawing.Point(10, 84);
            this.dgv_men.Name = "dgv_men";
            this.dgv_men.Size = new System.Drawing.Size(290, 215);
            this.dgv_men.TabIndex = 12;
            // 
            // txt_pesq
            // 
            this.txt_pesq.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesq.Location = new System.Drawing.Point(169, 44);
            this.txt_pesq.Name = "txt_pesq";
            this.txt_pesq.Size = new System.Drawing.Size(131, 26);
            this.txt_pesq.TabIndex = 11;
            this.txt_pesq.TextChanged += new System.EventHandler(this.txt_pesq_TextChanged);
            // 
            // cmb_escolha
            // 
            this.cmb_escolha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_escolha.FormattingEnabled = true;
            this.cmb_escolha.Items.AddRange(new object[] {
            "Código da Menção",
            "Menção"});
            this.cmb_escolha.Location = new System.Drawing.Point(10, 44);
            this.cmb_escolha.Name = "cmb_escolha";
            this.cmb_escolha.Size = new System.Drawing.Size(153, 27);
            this.cmb_escolha.TabIndex = 10;
            this.cmb_escolha.Text = "Escolha";
            // 
            // lbes
            // 
            this.lbes.AutoSize = true;
            this.lbes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbes.Location = new System.Drawing.Point(7, 13);
            this.lbes.Name = "lbes";
            this.lbes.Size = new System.Drawing.Size(306, 19);
            this.lbes.TabIndex = 13;
            this.lbes.Text = "Escolha o campo a ser pesquisado:";
            // 
            // pDocMen
            // 
            this.pDocMen.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDocMen_PrintPage);
            // 
            // ptPPMen
            // 
            this.ptPPMen.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ptPPMen.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ptPPMen.ClientSize = new System.Drawing.Size(400, 300);
            this.ptPPMen.Document = this.pDocMen;
            this.ptPPMen.Enabled = true;
            this.ptPPMen.Icon = ((System.Drawing.Icon)(resources.GetObject("ptPPMen.Icon")));
            this.ptPPMen.Name = "ptPPMen";
            this.ptPPMen.Visible = false;
            // 
            // ptDiaMen
            // 
            this.ptDiaMen.Document = this.pDocMen;
            this.ptDiaMen.UseEXDialog = true;
            // 
            // Cons_Cad_Mencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(312, 359);
            this.Controls.Add(this.lbes);
            this.Controls.Add(this.dgv_men);
            this.Controls.Add(this.txt_pesq);
            this.Controls.Add(this.cmb_escolha);
            this.Controls.Add(this.btnquant);
            this.Controls.Add(this.btnvisu);
            this.Controls.Add(this.btnimp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cons_Cad_Mencao";
            this.Text = "Consulta Cadastral de Menção";
            this.Load += new System.EventHandler(this.Cons_Cad_Mencao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_men)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquant;
        private System.Windows.Forms.Button btnvisu;
        private System.Windows.Forms.Button btnimp;
        private System.Windows.Forms.DataGridView dgv_men;
        private System.Windows.Forms.TextBox txt_pesq;
        private System.Windows.Forms.ComboBox cmb_escolha;
        private System.Windows.Forms.Label lbes;
        private System.Windows.Forms.ToolTip tpMen;
        private System.Drawing.Printing.PrintDocument pDocMen;
        private System.Windows.Forms.PrintPreviewDialog ptPPMen;
        private System.Windows.Forms.PrintDialog ptDiaMen;
    }
}