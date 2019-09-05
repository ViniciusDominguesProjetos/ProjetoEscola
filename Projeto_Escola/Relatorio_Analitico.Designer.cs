namespace Projeto_Escola
{
    partial class Relatorio_Analitico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_Analitico));
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_reg = new System.Windows.Forms.DataGridView();
            this.cmb_esc = new System.Windows.Forms.ComboBox();
            this.btnvisu = new System.Windows.Forms.Button();
            this.btnimp = new System.Windows.Forms.Button();
            this.pDoc = new System.Drawing.Printing.PrintDocument();
            this.ptPP = new System.Windows.Forms.PrintPreviewDialog();
            this.ptDia = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Selecione o agrupamento:";
            // 
            // dgv_reg
            // 
            this.dgv_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reg.Location = new System.Drawing.Point(8, 45);
            this.dgv_reg.Name = "dgv_reg";
            this.dgv_reg.Size = new System.Drawing.Size(473, 188);
            this.dgv_reg.TabIndex = 21;
            // 
            // cmb_esc
            // 
            this.cmb_esc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_esc.FormattingEnabled = true;
            this.cmb_esc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_esc.Items.AddRange(new object[] {
            "Agrupado por Menção",
            "Agrupado por Disciplina",
            "Boletim"});
            this.cmb_esc.Location = new System.Drawing.Point(238, 12);
            this.cmb_esc.Name = "cmb_esc";
            this.cmb_esc.Size = new System.Drawing.Size(243, 27);
            this.cmb_esc.TabIndex = 20;
            this.cmb_esc.SelectedIndexChanged += new System.EventHandler(this.cmb_esc_SelectedIndexChanged);
            // 
            // btnvisu
            // 
            this.btnvisu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvisu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvisu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvisu.Image = ((System.Drawing.Image)(resources.GetObject("btnvisu.Image")));
            this.btnvisu.Location = new System.Drawing.Point(432, 239);
            this.btnvisu.Name = "btnvisu";
            this.btnvisu.Size = new System.Drawing.Size(49, 43);
            this.btnvisu.TabIndex = 24;
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
            this.btnimp.Location = new System.Drawing.Point(382, 239);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(44, 43);
            this.btnimp.TabIndex = 23;
            this.btnimp.UseVisualStyleBackColor = false;
            this.btnimp.Click += new System.EventHandler(this.btnimp_Click);
            // 
            // pDoc
            // 
            this.pDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDoc_PrintPage);
            // 
            // ptPP
            // 
            this.ptPP.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ptPP.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ptPP.ClientSize = new System.Drawing.Size(400, 300);
            this.ptPP.Document = this.pDoc;
            this.ptPP.Enabled = true;
            this.ptPP.Icon = ((System.Drawing.Icon)(resources.GetObject("ptPP.Icon")));
            this.ptPP.Name = "ptPPAluno";
            this.ptPP.Visible = false;
            // 
            // ptDia
            // 
            this.ptDia.Document = this.pDoc;
            this.ptDia.UseEXDialog = true;
            // 
            // Relatorio_Analitico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(485, 288);
            this.Controls.Add(this.btnvisu);
            this.Controls.Add(this.btnimp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_reg);
            this.Controls.Add(this.cmb_esc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio_Analitico";
            this.Text = "Relatório Geral";
            this.Load += new System.EventHandler(this.Relatorio_Analitico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_reg;
        private System.Windows.Forms.ComboBox cmb_esc;
        private System.Windows.Forms.Button btnvisu;
        private System.Windows.Forms.Button btnimp;
        private System.Drawing.Printing.PrintDocument pDoc;
        private System.Windows.Forms.PrintPreviewDialog ptPP;
        private System.Windows.Forms.PrintDialog ptDia;
    }
}