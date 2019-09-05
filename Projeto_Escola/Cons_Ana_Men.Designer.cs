namespace Projeto_Escola
{
    partial class Cons_Ana_Men
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cons_Ana_Men));
            this.dgv_reg = new System.Windows.Forms.DataGridView();
            this.cmb_men = new System.Windows.Forms.ComboBox();
            this.lbm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reg
            // 
            this.dgv_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reg.Location = new System.Drawing.Point(9, 99);
            this.dgv_reg.Name = "dgv_reg";
            this.dgv_reg.Size = new System.Drawing.Size(473, 193);
            this.dgv_reg.TabIndex = 9;
            // 
            // cmb_men
            // 
            this.cmb_men.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_men.FormattingEnabled = true;
            this.cmb_men.Location = new System.Drawing.Point(79, 58);
            this.cmb_men.Name = "cmb_men";
            this.cmb_men.Size = new System.Drawing.Size(121, 27);
            this.cmb_men.TabIndex = 8;
            this.cmb_men.SelectedIndexChanged += new System.EventHandler(this.cmb_men_SelectedIndexChanged);
            // 
            // lbm
            // 
            this.lbm.AutoSize = true;
            this.lbm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbm.Location = new System.Drawing.Point(10, 58);
            this.lbm.Name = "lbm";
            this.lbm.Size = new System.Drawing.Size(72, 19);
            this.lbm.TabIndex = 7;
            this.lbm.Text = "Menção:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione a menção que deseja filtrar:";
            // 
            // Cons_Ana_Men
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(490, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_reg);
            this.Controls.Add(this.cmb_men);
            this.Controls.Add(this.lbm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cons_Ana_Men";
            this.Text = " Consulta Analítica de Menção";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cons_Ana_Men_FormClosing);
            this.Load += new System.EventHandler(this.Cons_Ana_Men_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reg;
        private System.Windows.Forms.ComboBox cmb_men;
        private System.Windows.Forms.Label lbm;
        private System.Windows.Forms.Label label1;
    }
}