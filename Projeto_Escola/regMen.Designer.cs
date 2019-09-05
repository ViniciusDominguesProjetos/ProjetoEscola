namespace Projeto_Escola
{
    partial class regMen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regMen));
            this.lba = new System.Windows.Forms.Label();
            this.lbd = new System.Windows.Forms.Label();
            this.lbm = new System.Windows.Forms.Label();
            this.cmb_aluno = new System.Windows.Forms.ComboBox();
            this.cmb_disciplina = new System.Windows.Forms.ComboBox();
            this.cmb_men = new System.Windows.Forms.ComboBox();
            this.dgv_reg = new System.Windows.Forms.DataGridView();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).BeginInit();
            this.SuspendLayout();
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lba.Location = new System.Drawing.Point(10, 61);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(63, 19);
            this.lba.TabIndex = 0;
            this.lba.Text = "Aluno:";
            // 
            // lbd
            // 
            this.lbd.AutoSize = true;
            this.lbd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbd.Location = new System.Drawing.Point(9, 98);
            this.lbd.Name = "lbd";
            this.lbd.Size = new System.Drawing.Size(108, 19);
            this.lbd.TabIndex = 1;
            this.lbd.Text = "Disciplina:";
            // 
            // lbm
            // 
            this.lbm.AutoSize = true;
            this.lbm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbm.Location = new System.Drawing.Point(9, 132);
            this.lbm.Name = "lbm";
            this.lbm.Size = new System.Drawing.Size(72, 19);
            this.lbm.TabIndex = 2;
            this.lbm.Text = "Menção:";
            // 
            // cmb_aluno
            // 
            this.cmb_aluno.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_aluno.FormattingEnabled = true;
            this.cmb_aluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_aluno.Location = new System.Drawing.Point(146, 61);
            this.cmb_aluno.Name = "cmb_aluno";
            this.cmb_aluno.Size = new System.Drawing.Size(403, 27);
            this.cmb_aluno.TabIndex = 3;
            this.cmb_aluno.SelectedIndexChanged += new System.EventHandler(this.cmb_aluno_SelectedIndexChanged);
            // 
            // cmb_disciplina
            // 
            this.cmb_disciplina.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_disciplina.FormattingEnabled = true;
            this.cmb_disciplina.Location = new System.Drawing.Point(190, 98);
            this.cmb_disciplina.Name = "cmb_disciplina";
            this.cmb_disciplina.Size = new System.Drawing.Size(359, 27);
            this.cmb_disciplina.TabIndex = 4;
            this.cmb_disciplina.SelectedIndexChanged += new System.EventHandler(this.cmb_disciplina_SelectedIndexChanged);
            // 
            // cmb_men
            // 
            this.cmb_men.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_men.FormattingEnabled = true;
            this.cmb_men.Location = new System.Drawing.Point(83, 132);
            this.cmb_men.Name = "cmb_men";
            this.cmb_men.Size = new System.Drawing.Size(121, 27);
            this.cmb_men.TabIndex = 5;
            // 
            // dgv_reg
            // 
            this.dgv_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reg.Location = new System.Drawing.Point(12, 177);
            this.dgv_reg.Name = "dgv_reg";
            this.dgv_reg.Size = new System.Drawing.Size(537, 193);
            this.dgv_reg.TabIndex = 6;
          
           
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(68, 61);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(72, 19);
            this.lbl_matricula.TabIndex = 7;
            this.lbl_matricula.Text = "matrial";
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod.Location = new System.Drawing.Point(112, 98);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(72, 19);
            this.lbl_cod.TabIndex = 8;
            this.lbl_cod.Text = "coddisc";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(509, 131);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(40, 41);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione o aluno, a disciplina e menção que deseja aplicar:";
            // 
            // regMen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(558, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.dgv_reg);
            this.Controls.Add(this.cmb_men);
            this.Controls.Add(this.cmb_disciplina);
            this.Controls.Add(this.cmb_aluno);
            this.Controls.Add(this.lbm);
            this.Controls.Add(this.lbd);
            this.Controls.Add(this.lba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "regMen";
            this.Text = "Registrar Menções";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.regMen_FormClosing);
            this.Load += new System.EventHandler(this.regMen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbd;
        private System.Windows.Forms.Label lbm;
        private System.Windows.Forms.ComboBox cmb_disciplina;
        private System.Windows.Forms.ComboBox cmb_men;
        private System.Windows.Forms.DataGridView dgv_reg;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmb_aluno;
        private System.Windows.Forms.Label label1;
    }
}