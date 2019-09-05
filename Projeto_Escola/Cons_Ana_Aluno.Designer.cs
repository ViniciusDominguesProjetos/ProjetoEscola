namespace Projeto_Escola
{
    partial class Cons_Ana_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cons_Ana_Aluno));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.cmb_aluno = new System.Windows.Forms.ComboBox();
            this.lba = new System.Windows.Forms.Label();
            this.dgv_reg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 14;
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(107, 41);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(72, 19);
            this.lbl_matricula.TabIndex = 13;
            this.lbl_matricula.Text = "matrial";
            // 
            // cmb_aluno
            // 
            this.cmb_aluno.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_aluno.FormattingEnabled = true;
            this.cmb_aluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_aluno.Location = new System.Drawing.Point(74, 64);
            this.cmb_aluno.Name = "cmb_aluno";
            this.cmb_aluno.Size = new System.Drawing.Size(307, 27);
            this.cmb_aluno.TabIndex = 12;
            this.cmb_aluno.SelectedIndexChanged += new System.EventHandler(this.cmb_aluno_SelectedIndexChanged);
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lba.Location = new System.Drawing.Point(12, 64);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(63, 19);
            this.lba.TabIndex = 11;
            this.lba.Text = "Aluno:";
            // 
            // dgv_reg
            // 
            this.dgv_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reg.Location = new System.Drawing.Point(10, 101);
            this.dgv_reg.Name = "dgv_reg";
            this.dgv_reg.Size = new System.Drawing.Size(451, 188);
            this.dgv_reg.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Selecione o aluno que deseja filtrar:";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Matrícula:";
            // 
            // Cons_Ana_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(469, 297);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_reg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.cmb_aluno);
            this.Controls.Add(this.lba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cons_Ana_Aluno";
            this.Text = "Consulta Analítica de Aluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cons_Ana_Aluno_FormClosing);
            this.Load += new System.EventHandler(this.Cons_Ana_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.ComboBox cmb_aluno;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.DataGridView dgv_reg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}