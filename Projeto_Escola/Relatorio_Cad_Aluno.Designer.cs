namespace Projeto_Escola
{
    partial class Relatorio_Cad_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_Cad_Aluno));
            this.btnvisu = new System.Windows.Forms.Button();
            this.btnimp = new System.Windows.Forms.Button();
            this.dgv_disc = new System.Windows.Forms.DataGridView();
            this.ptDiaAlu = new System.Windows.Forms.PrintDialog();
            this.pDoc = new System.Drawing.Printing.PrintDocument();
            this.ptPPAlu = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvisu
            // 
            this.btnvisu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvisu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvisu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvisu.Image = ((System.Drawing.Image)(resources.GetObject("btnvisu.Image")));
            this.btnvisu.Location = new System.Drawing.Point(381, 232);
            this.btnvisu.Name = "btnvisu";
            this.btnvisu.Size = new System.Drawing.Size(49, 43);
            this.btnvisu.TabIndex = 13;
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
            this.btnimp.Location = new System.Drawing.Point(331, 232);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(44, 43);
            this.btnimp.TabIndex = 12;
            this.btnimp.UseVisualStyleBackColor = false;
            this.btnimp.Click += new System.EventHandler(this.btnimp_Click);
            // 
            // dgv_disc
            // 
            this.dgv_disc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disc.Location = new System.Drawing.Point(10, 11);
            this.dgv_disc.Name = "dgv_disc";
            this.dgv_disc.Size = new System.Drawing.Size(420, 215);
            this.dgv_disc.TabIndex = 11;
            // 
            // ptDiaAlu
            // 
            this.ptDiaAlu.Document = this.pDoc;
            this.ptDiaAlu.UseEXDialog = true;
            // 
            // pDoc
            // 
            this.pDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDoc_PrintPage);
            // 
            // ptPPAlu
            // 
            this.ptPPAlu.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ptPPAlu.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ptPPAlu.ClientSize = new System.Drawing.Size(400, 300);
            this.ptPPAlu.Document = this.pDoc;
            this.ptPPAlu.Enabled = true;
            this.ptPPAlu.Icon = ((System.Drawing.Icon)(resources.GetObject("ptPPAlu.Icon")));
            this.ptPPAlu.Name = "ptPPAlu";
            this.ptPPAlu.Visible = false;
            // 
            // Relatorio_Cad_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(440, 282);
            this.Controls.Add(this.btnvisu);
            this.Controls.Add(this.btnimp);
            this.Controls.Add(this.dgv_disc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Relatorio_Cad_Aluno";
            this.Text = "Relatório Geral de Alunos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Relatorio_Cad_Aluno_FormClosing);
            this.Load += new System.EventHandler(this.Relatorio_Cad_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvisu;
        private System.Windows.Forms.Button btnimp;
        private System.Windows.Forms.DataGridView dgv_disc;
        private System.Windows.Forms.PrintDialog ptDiaAlu;
        private System.Drawing.Printing.PrintDocument pDoc;
        private System.Windows.Forms.PrintPreviewDialog ptPPAlu;
    }
}