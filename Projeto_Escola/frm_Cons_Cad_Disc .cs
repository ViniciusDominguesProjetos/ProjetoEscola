using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Projeto_Escola
{
    public partial class frm_Cons_Cad_Disc : Form
    {
        public frm_Cons_Cad_Disc()
        {
            InitializeComponent();
        }



        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_disc;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_disc = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

        private void carregar_grid()
        {
            //Determine a query desejada
            _query = "Select * from Disciplinas";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_disc = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
                dgv_disc.DataSource = bs_disc;

            }
            else
            {
                MessageBox.Show("Não temos disciplinas cadastradas!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frm_Cons_Cad_Disc_Load(object sender, EventArgs e)
        {
             carregar_grid();
        }

        private void txt_pesq_TextChanged(object sender, EventArgs e)
        {

            if (cmb_escolha.Text == "Sigla") 
            {
                _query = "Select * from disciplinas where sigla like '" + txt_pesq.Text + "%'";
            }

            else if (cmb_escolha.Text == "Descrição")
            {
                _query = "Select * from disciplinas where descricao like '" + txt_pesq.Text + "%'";
            }

            
            else if (cmb_escolha.Text == "Série")
            {
                _query = "Select * from disciplinas where série like '" + txt_pesq.Text + "%'";
            }

            else if (cmb_escolha.Text == "Código da Disciplina")
            {
                 _query = "Select * from disciplinas where cod_disciplina like '" + txt_pesq.Text + "%'";
            }

            else
            {
                MessageBox.Show("Escolha um campo pra pesquisar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_escolha.Focus();
            }

            txt_pesq.Focus();
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_disc = _dataCommand.ExecuteReader();

            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
            }

            else
            {
                MessageBox.Show("Não temos nenhuma Disciplina cadastrada com este parametro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_pesq.Clear();
            }

        }

        private void btnquant_Click(object sender, EventArgs e)
        { 
            int a = bs_disc.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgv_disc.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("logo_ete.jpg"), 50, 5);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DE DISCIPLINA", new System.Drawing.Font("Consolas", 14, FontStyle.Bold), Brushes.Black, 450, 60);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 85, 800, 85);
            // código
            e.Graphics.DrawString("CÓDIGO DA DISCIPLINA:  " + linha.Cells["cod_disciplina"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 120);
            // descrição
            e.Graphics.DrawString("DESCRIÇÃO:   " + linha.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 140);
            // sigla
            e.Graphics.DrawString("SIGLA : " + linha.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 160);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 1100, 800, 1100);

        }

        private void btnvisu_Click(object sender, EventArgs e)
        {
            ptPPDisc.Text = " Visualizando a impressão";   // título da janela
            ptPPDisc.WindowState = FormWindowState.Maximized;  // status da janela do preview
            ptPPDisc.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            ptPPDisc.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            ptPPDisc.ShowDialog();

        }

        private void btnimp_Click(object sender, EventArgs e)
        {
            ptDiaDisc.ShowDialog();
            pDoc.Print();                             

        }

     

    

       




        }
    }

