using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Escola
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tsHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            tsData.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Aluno tCA = new Cadastro_Aluno();//Criando uma instância do formulário Exercício 1
            tCA.MdiParent = this;
            tCA.Show();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Disciplina tCD= new Cadastro_Disciplina();//Criando uma instância do formulário Exercício 1
            tCD.MdiParent = this;
            tCD.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Conexao.fecharConexao();
            else
            {
                e.Cancel = true;
            }
        }

        private void mençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Menção tCM = new Cadastro_Menção();//Criando uma instância do formulário Exercício 1
            tCM.MdiParent = this;
            tCM.Show();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {

            Cadastro_Aluno tCA = new Cadastro_Aluno();//Criando uma instância do formulário Exercício 1
            tCA.MdiParent = this;
            tCA.Show();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            Cadastro_Disciplina tCD = new Cadastro_Disciplina();//Criando uma instância do formulário Exercício 1
            tCD.MdiParent = this;
            tCD.Show();
        }

        private void btnMencao_Click(object sender, EventArgs e)
        {
            Cadastro_Menção tCM = new Cadastro_Menção();//Criando uma instância do formulário Exercício 1
            tCM.MdiParent = this;
            tCM.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Cons_Cad_Aluno cCA = new Cons_Cad_Aluno();//Criando uma instância do formulário Exercício 1
            cCA.MdiParent = this;
            cCA.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cons_Cad_Aluno cCA = new Cons_Cad_Aluno();//Criando uma instância do formulário Exercício 1
            cCA.MdiParent = this;
            cCA.Show();
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cons_Cad_Disc cCD = new frm_Cons_Cad_Disc();//Criando uma instância do formulário Exercício 1
            cCD.MdiParent = this;
            cCD.Show();
        }

        private void mençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cons_Cad_Mencao cCM = new Cons_Cad_Mencao();//Criando uma instância do formulário Exercício 1
            cCM.MdiParent = this;
            cCM.Show();
        }

        private void registrarMençõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regMen rM= new regMen();//Criando uma instância do formulário Exercício 1
            rM.MdiParent = this;
            rM.Show();
        }

        private void umToolStripMenuItem_Click(object sender, EventArgs e)
        {

           Cons_Ana_Aluno cAA = new Cons_Ana_Aluno();//Criando uma instância do formulário Exercício 1
           cAA.MdiParent = this;
           cAA.Show();
        }

        private void doisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cons_Ana_Disc cAD = new Cons_Ana_Disc();//Criando uma instância do formulário Exercício 1
            cAD.MdiParent = this;
            cAD.Show();
        }

        private void tresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cons_Ana_Men cAM = new Cons_Ana_Men();//Criando uma instância do formulário Exercício 1
            cAM.MdiParent = this;
            cAM.Show();
        }

        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorio_Cad_Aluno rCA = new Relatorio_Cad_Aluno();//Criando uma instância do formulário Exercício 1
            rCA.MdiParent = this;
            rCA.Show();
        }

        private void disciplinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorio_Cad_Disciplina rCD = new Relatorio_Cad_Disciplina();//Criando uma instância do formulário Exercício 1
            rCD.MdiParent = this;
            rCD.Show();
        }

        private void relUmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_Analitico rA = new Relatorio_Analitico();//Criando uma instância do formulário Exercício 1
            rA.MdiParent = this;
            rA.Show();
        }

        private void tsHora_Click(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Sobre s = new   Sobre();//Criando uma instância do formulário Exercício 1
            s.MdiParent = this;
            s.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Sobre s = new Sobre();//Criando uma instância do formulário Exercício 1
            s.MdiParent = this;
            s.Show();
        }
        

       
    }
}
