using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;



namespace Projeto_Escola
{
    public partial class Cons_Cad_Aluno : Form
    {
        public Cons_Cad_Aluno()
        {
            InitializeComponent();
        }

        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_aluno;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_aluno = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

        private void carregar_grid()
        {
            //Determine a query desejada
            _query = "Select * from Alunos";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_aluno = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_aluno.HasRows == true)
            {
                bs_aluno.DataSource = dr_aluno;
                dgv_aluno.DataSource = bs_aluno;

            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }



        private void Cons_Cad_Aluno_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void txt_pesq_TextChanged(object sender, EventArgs e)
        {

           if (cmb_escolha.Text == "Matrícula") 
            {
                _query = "Select * from Alunos where Matricula like '" + txt_pesq.Text + "%'";
            }

            else if (cmb_escolha.Text == "Nome")
            {
                _query = "Select * from Alunos where Nome like'" + txt_pesq.Text + "%'";
            }

             else if (cmb_escolha.Text == "Bairro")
            {
                _query = "Select * from Alunos where bairro like'" + txt_pesq.Text + "%'";
            }
    
             else if (cmb_escolha.Text == "Data de Nascimento")
            {
                _query = "Select * from Alunos where Nasc like'" + txt_pesq.Text + "%'";
            }
           
             else if (cmb_escolha.Text == "Sexo")
            {
                _query = "Select * from Alunos where sexo like'" + txt_pesq.Text + "%'";
            }
    
             else if (cmb_escolha.Text == "RG")
            {
                _query = "Select * from Alunos where RG like'" + txt_pesq.Text + "%'";
            }
    
             else if (cmb_escolha.Text == "CPF")
            {
                _query = "Select * from Alunos where cpf like'" + txt_pesq.Text + "%'";
            }

            else if (cmb_escolha.Text == "Endereço")
            {
                _query = "Select * from Alunos where Endereco like'" + txt_pesq.Text + "%'";
            }

            else if (cmb_escolha.Text == "Telefone")
            {
                _query = "Select * from Alunos where telefone like'" + txt_pesq.Text + "%'";
            }

            else if (cmb_escolha.Text == "CEP")
            {
                _query = "Select * from Alunos where cep like'" + txt_pesq.Text + "%'";
            }

            else if (cmb_escolha.Text == "Número da Residência")
            {
                _query = "Select * from Alunos where numero like'" + txt_pesq.Text + "%'";
            }

            else if (cmb_escolha.Text == "Cidade")
            {
                _query = "Select * from Alunos where cidade like'" + txt_pesq.Text + "%'";
            }
            


            else
            {
                MessageBox.Show("Escolha um campo pra pesquisar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_escolha.Focus();
            }

            txt_pesq.Focus();
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_aluno = _dataCommand.ExecuteReader();

            if (dr_aluno.HasRows == true)
            {
                bs_aluno.DataSource = dr_aluno;
            }

            else
            {
                MessageBox.Show("Não temos nenhum Aluno cadastrado com este parametro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_pesq.Clear();
            }


        }

        private void btnquant_Click(object sender, EventArgs e)
        {
            
            int a = bs_aluno.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pDocAluno_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgv_aluno.CurrentRow;
            e.Graphics.DrawImage(Image.FromFile("logo_ete.jpg"), 50, 5);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DE ALUNO", new System.Drawing.Font("Consolas", 14, FontStyle.Bold), Brushes.Black, 450, 60);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 85, 800, 85);
            // código
            e.Graphics.DrawString("MATRÍCULA:  " + linha.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 120);
            // descrição
            e.Graphics.DrawString("NOME:   " + linha.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 140);
            // sigla
            e.Graphics.DrawString("DATA DE NASCIMENTO: " + linha.Cells["Nasc"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 160);
            //
            e.Graphics.DrawString("ENDEREÇO: " + linha.Cells["Endereco"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 180);
            //
            e.Graphics.DrawString("NÚMERO: " + linha.Cells["numero"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 200);
            //
            e.Graphics.DrawString("BAIRRO: " + linha.Cells["bairro"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 220);
            //
            e.Graphics.DrawString("CIDADE: " + linha.Cells["cidade"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 240);
            //
            e.Graphics.DrawString("CEP: " + linha.Cells["cep"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 260);
            //
            e.Graphics.DrawString("RG: " + linha.Cells["RG"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 280);
            //
            e.Graphics.DrawString("TELEFONE: " + linha.Cells["telefone"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 300);
            //
            e.Graphics.DrawString("CPF: " + linha.Cells["cpf"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 320);
            //
            e.Graphics.DrawString("SEXO: " + linha.Cells["sexo"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 340);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 1100, 800, 1100);
        }

        
        private void btnvisu_Click(object sender, EventArgs e)
        {
            ptPPAluno.Text = " Visualizando a impressão";   // título da janela
            ptPPAluno.WindowState = FormWindowState.Maximized;  // status da janela do preview
            ptPPAluno.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            ptPPAluno.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            ptPPAluno.ShowDialog();
        }

        private void btnimp_Click(object sender, EventArgs e)
        {
            ptDiaAluno.ShowDialog();
            pDocAluno.Print();
        }



    }
}
