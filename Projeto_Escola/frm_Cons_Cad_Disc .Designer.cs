namespace Projeto_Escola
{
    partial class frm_Cons_Cad_Disc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cons_Cad_Disc));
            this.lbes = new System.Windows.Forms.Label();
            this.cmb_escolha = new System.Windows.Forms.ComboBox();
            this.txt_pesq = new System.Windows.Forms.TextBox();
            this.dgv_disc = new System.Windows.Forms.DataGridView();
            this.btnimp = new System.Windows.Forms.Button();
            this.btnvisu = new System.Windows.Forms.Button();
            this.btnquant = new System.Windows.Forms.Button();
            this.ttDiscCadC = new System.Windows.Forms.ToolTip(this.components);
            this.ptDiaDisc = new System.Windows.Forms.PrintDialog();
            this.pDoc = new System.Drawing.Printing.PrintDocument();
            this.ptPPDisc = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbes
            // 
            this.lbes.AutoSize = true;
            this.lbes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbes.Location = new System.Drawing.Point(6, 12);
            this.lbes.Name = "lbes";
            this.lbes.Size = new System.Drawing.Size(306, 19);
            this.lbes.TabIndex = 0;
            this.lbes.Text = "Escolha o campo a ser pesquisado:";
            // 
            // cmb_escolha
            // 
            this.cmb_escolha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_escolha.FormattingEnabled = true;
            this.cmb_escolha.Items.AddRange(new object[] {
            "Código da Disciplina",
            "Descrição",
            "Sigla",
            "Série"});
            this.cmb_escolha.Location = new System.Drawing.Point(9, 42);
            this.cmb_escolha.Name = "cmb_escolha";
            this.cmb_escolha.Size = new System.Drawing.Size(174, 27);
            this.cmb_escolha.TabIndex = 1;
            this.cmb_escolha.Text = "Escolha";
            // 
            // txt_pesq
            // 
            this.txt_pesq.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesq.Location = new System.Drawing.Point(188, 43);
            this.txt_pesq.Name = "txt_pesq";
            this.txt_pesq.Size = new System.Drawing.Size(233, 26);
            this.txt_pesq.TabIndex = 2;
            this.txt_pesq.TextChanged += new System.EventHandler(this.txt_pesq_TextChanged);
            // 
            // dgv_disc
            // 
            this.dgv_disc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disc.Location = new System.Drawing.Point(10, 86);
            this.dgv_disc.Name = "dgv_disc";
            this.dgv_disc.Size = new System.Drawing.Size(410, 215);
            this.dgv_disc.TabIndex = 3;
            // 
            // btnimp
            // 
            this.btnimp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnimp.Image = ((System.Drawing.Image)(resources.GetObject("btnimp.Image")));
            this.btnimp.Location = new System.Drawing.Point(10, 308);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(44, 43);
            this.btnimp.TabIndex = 4;
            this.ttDiscCadC.SetToolTip(this.btnimp, "Imprimir");
            this.btnimp.UseVisualStyleBackColor = false;
            this.btnimp.Click += new System.EventHandler(this.btnimp_Click);
            // 
            // btnvisu
            // 
            this.btnvisu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvisu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvisu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvisu.Image = ((System.Drawing.Image)(resources.GetObject("btnvisu.Image")));
            this.btnvisu.Location = new System.Drawing.Point(60, 308);
            this.btnvisu.Name = "btnvisu";
            this.btnvisu.Size = new System.Drawing.Size(49, 43);
            this.btnvisu.TabIndex = 5;
            this.ttDiscCadC.SetToolTip(this.btnvisu, "Visualizar");
            this.btnvisu.UseVisualStyleBackColor = false;
            this.btnvisu.Click += new System.EventHandler(this.btnvisu_Click);
            // 
            // btnquant
            // 
            this.btnquant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquant.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnquant.Image = ((System.Drawing.Image)(resources.GetObject("btnquant.Image")));
            this.btnquant.Location = new System.Drawing.Point(370, 308);
            this.btnquant.Name = "btnquant";
            this.btnquant.Size = new System.Drawing.Size(50, 43);
            this.btnquant.TabIndex = 6;
            this.ttDiscCadC.SetToolTip(this.btnquant, "Quantidade de Selecionados");
            this.btnquant.UseVisualStyleBackColor = false;
            this.btnquant.Click += new System.EventHandler(this.btnquant_Click);
            // 
            // ptDiaDisc
            // 
            this.ptDiaDisc.Document = this.pDoc;
            this.ptDiaDisc.UseEXDialog = true;
            // 
            // pDoc
            // 
            this.pDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDoc_PrintPage);
            // 
            // ptPPDisc
            // 
            this.ptPPDisc.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ptPPDisc.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ptPPDisc.ClientSize = new System.Drawing.Size(400, 300);
            this.ptPPDisc.Document = this.pDoc;
            this.ptPPDisc.Enabled = true;
            this.ptPPDisc.Icon = ((System.Drawing.Icon)(resources.GetObject("ptPPDisc.Icon")));
            this.ptPPDisc.Name = "ptPPDisc";
            this.ptPPDisc.Visible = false;
            // 
            // frm_Cons_Cad_Disc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(435, 356);
            this.Controls.Add(this.btnquant);
            this.Controls.Add(this.btnvisu);
            this.Controls.Add(this.btnimp);
            this.Controls.Add(this.dgv_disc);
            this.Controls.Add(this.txt_pesq);
            this.Controls.Add(this.cmb_escolha);
            this.Controls.Add(this.lbes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Cons_Cad_Disc";
            this.Text = "Consulta Cadastral de Disciplina";
            this.Load += new System.EventHandler(this.frm_Cons_Cad_Disc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbes;
        private System.Windows.Forms.ComboBox cmb_escolha;
        private System.Windows.Forms.TextBox txt_pesq;
        private System.Windows.Forms.DataGridView dgv_disc;
        private System.Windows.Forms.Button btnimp;
        private System.Windows.Forms.Button btnvisu;
        private System.Windows.Forms.Button btnquant;
        private System.Windows.Forms.ToolTip ttDiscCadC;
        private System.Windows.Forms.PrintDialog ptDiaDisc;
        private System.Windows.Forms.PrintPreviewDialog ptPPDisc;
        private System.Drawing.Printing.PrintDocument pDoc;
    }
}