namespace Projeto_Escola
{
    partial class Cons_Ana_Disc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cons_Ana_Disc));
            this.lbl_cod = new System.Windows.Forms.Label();
            this.cmb_disciplina = new System.Windows.Forms.ComboBox();
            this.lbd = new System.Windows.Forms.Label();
            this.dgv_reg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod.Location = new System.Drawing.Point(117, 43);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(72, 19);
            this.lbl_cod.TabIndex = 11;
            this.lbl_cod.Text = "desdisc";
            // 
            // cmb_disciplina
            // 
            this.cmb_disciplina.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_disciplina.FormattingEnabled = true;
            this.cmb_disciplina.Location = new System.Drawing.Point(82, 67);
            this.cmb_disciplina.Name = "cmb_disciplina";
            this.cmb_disciplina.Size = new System.Drawing.Size(253, 27);
            this.cmb_disciplina.TabIndex = 10;
            this.cmb_disciplina.SelectedIndexChanged += new System.EventHandler(this.cmb_disciplina_SelectedIndexChanged);
            // 
            // lbd
            // 
            this.lbd.AutoSize = true;
            this.lbd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbd.Location = new System.Drawing.Point(15, 43);
            this.lbd.Name = "lbd";
            this.lbd.Size = new System.Drawing.Size(108, 19);
            this.lbd.TabIndex = 9;
            this.lbd.Text = "Disciplina:";
            // 
            // dgv_reg
            // 
            this.dgv_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reg.Location = new System.Drawing.Point(10, 106);
            this.dgv_reg.Name = "dgv_reg";
            this.dgv_reg.Size = new System.Drawing.Size(451, 205);
            this.dgv_reg.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sigla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Selecione a disciplina que deseja filtrar:";
            // 
            // Cons_Ana_Disc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(468, 319);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_reg);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.cmb_disciplina);
            this.Controls.Add(this.lbd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cons_Ana_Disc";
            this.Text = " Consulta Analítica de Disciplina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cons_Ana_Disc_FormClosing);
            this.Load += new System.EventHandler(this.Cons_Ana_Disc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.ComboBox cmb_disciplina;
        private System.Windows.Forms.Label lbd;
        private System.Windows.Forms.DataGridView dgv_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}