namespace Projeto_Escola
{
    partial class Relatorio_Cad_Disciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_Cad_Disciplina));
            this.btnvisu = new System.Windows.Forms.Button();
            this.btnimp = new System.Windows.Forms.Button();
            this.dgv_disc = new System.Windows.Forms.DataGridView();
            this.ptDiaDisc = new System.Windows.Forms.PrintDialog();
            this.pDoc = new System.Drawing.Printing.PrintDocument();
            this.ptPPDisc = new System.Windows.Forms.PrintPreviewDialog();
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
            this.btnvisu.Location = new System.Drawing.Point(389, 233);
            this.btnvisu.Name = "btnvisu";
            this.btnvisu.Size = new System.Drawing.Size(49, 43);
            this.btnvisu.TabIndex = 9;
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
            this.btnimp.Location = new System.Drawing.Point(339, 233);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(44, 43);
            this.btnimp.TabIndex = 8;
            this.btnimp.UseVisualStyleBackColor = false;
            this.btnimp.Click += new System.EventHandler(this.btnimp_Click);
            // 
            // dgv_disc
            // 
            this.dgv_disc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disc.Location = new System.Drawing.Point(12, 12);
            this.dgv_disc.Name = "dgv_disc";
            this.dgv_disc.Size = new System.Drawing.Size(428, 215);
            this.dgv_disc.TabIndex = 7;
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
            // Relatorio_Cad_Disciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(450, 285);
            this.Controls.Add(this.btnvisu);
            this.Controls.Add(this.btnimp);
            this.Controls.Add(this.dgv_disc);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio_Cad_Disciplina";
            this.Text = "Relatório Geral de Disciplinas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Relatorio_Cad_Disciplina_FormClosing);
            this.Load += new System.EventHandler(this.Relatorio_Cad_Disciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvisu;
        private System.Windows.Forms.Button btnimp;
        private System.Windows.Forms.DataGridView dgv_disc;
        private System.Windows.Forms.PrintDialog ptDiaDisc;
        private System.Windows.Forms.PrintPreviewDialog ptPPDisc;
        private System.Drawing.Printing.PrintDocument pDoc;
    }
}