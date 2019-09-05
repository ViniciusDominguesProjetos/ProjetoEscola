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
    public partial class Cons_Cad_Mencao : Form
    {
        public Cons_Cad_Mencao()
        {
            InitializeComponent();
        }

        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_men;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_men = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

        private void carregar_grid()
        {
            //Determine a query desejada
            _query = "Select * from Mencao";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_men = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_men.HasRows == true)
            {
                bs_men.DataSource = dr_men;
                dgv_men.DataSource = bs_men;

            }
            else
            {
                MessageBox.Show("Não temos menções cadastradas!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Cons_Cad_Mencao_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void txt_pesq_TextChanged(object sender, EventArgs e)
        {

             if (cmb_escolha.Text == "Código da Menção") 
            {
                _query = "Select * from Mencao where cod_mencao like '" + txt_pesq.Text + "%'";
            }

            else if (cmb_escolha.Text == "Menção")
            {
                _query = "Select * from Mencao where Mencao like'" + txt_pesq.Text + "%'";
            }

           

            else
            {
                MessageBox.Show("Escolha um campo pra pesquisar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_escolha.Focus();
            }

            txt_pesq.Focus();
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_men = _dataCommand.ExecuteReader();

            if (dr_men.HasRows == true)
            {
                bs_men.DataSource = dr_men;
            }

            else
            {
                MessageBox.Show("Não temos nenhuma Menção cadastrada com este parametro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_pesq.Clear();
            }

        }

        private void btnquant_Click(object sender, EventArgs e)
        {
            int a = bs_men.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pDocMen_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgv_men.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("logo_ete.jpg"), 50, 5);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DE MENÇÃO", new System.Drawing.Font("Consolas", 14, FontStyle.Bold), Brushes.Black, 450, 60);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 85, 800, 85);
            // código
            e.Graphics.DrawString("CÓDIGO DA MENÇÃO:  " + linha.Cells["cod_mencao"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 120);
            // descrição
            e.Graphics.DrawString("MENÇÃO:   " + linha.Cells["Mencao"].Value.ToString(), new System.Drawing.Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 50, 140);
           
          

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 1100, 800, 1100);
        }

        private void btnimp_Click(object sender, EventArgs e)
        {
            ptDiaMen.ShowDialog();
            pDocMen.Print();     
        }

        private void btnvisu_Click(object sender, EventArgs e)
        {
            ptPPMen.Text = " Visualizando a impressão";   // título da janela
            ptPPMen.WindowState = FormWindowState.Maximized;  // status da janela do preview
            ptPPMen.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            ptPPMen.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            ptPPMen.ShowDialog();
        }












        }














    }

