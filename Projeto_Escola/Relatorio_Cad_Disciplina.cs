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
    public partial class Relatorio_Cad_Disciplina : Form
    {
        public Relatorio_Cad_Disciplina()
        {
            InitializeComponent();
        }

        int cont = 0;
        int pag = 1; // variável para controlar o salto de página
        int registro, linha = 0; //variável contadora de registros e linhas impressas, 
        int fim = 0;    //variável que controla o fim da impressão


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
                MessageBox.Show("Não temos disciplinas cadastradas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }





        private void btnquant_Click(object sender, EventArgs e)
        {
            int a = bs_disc.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

   

      

        private void Relatorio_Cad_Disciplina_Load(object sender, EventArgs e)
        {
            

            carregar_grid();

            fim = bs_disc.Count;
        }

   

        private void btnvisu_Click(object sender, EventArgs e)
        {

            ptPPDisc.Text = " Visualizando a impressão";   // título da janela
            ptPPDisc.WindowState = FormWindowState.Maximized;  // status da janela do preview
            ptPPDisc.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            ptPPDisc.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            ptPPDisc.ShowDialog();
        }

        private void pDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

               
                DataGridViewRow reg_grid;
                reg_grid = dgv_disc.CurrentRow;



                e.Graphics.DrawImage(Image.FromFile("logo_ete.jpg"), 50, 5);
                // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
                e.Graphics.DrawString("RELATÓRIO GERAL DE DISCIPLINAS", new System.Drawing.Font("Consolas", 14, FontStyle.Bold), Brushes.Black, 410, 50);
                //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

                linha = 100;

                // cabeçalho de colunas
                e.Graphics.DrawString("Código  ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);
                e.Graphics.DrawString("Descrição   ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 150, linha);
                e.Graphics.DrawString("Sigla ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 400, linha);

                linha = 130;

                e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 85, 800, 85);

                while ((linha < 1060) & (registro != fim))
                {
                    // código
                    e.Graphics.DrawString(reg_grid.Cells["cod_disciplina"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 50, linha);
                    // descrição
                    e.Graphics.DrawString(reg_grid.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 150, linha);
                    // sigla
                    e.Graphics.DrawString(reg_grid.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 400, linha);

                    bs_disc.MoveNext(); // movendo para o próximo registro

                    reg_grid = dgv_disc.CurrentRow;  // atualizando a linha da grid para impressão

                    registro += 1;   // incrementando a variável contadora de registros

                    linha += 30; // incrementando a variável para pular linha
                }

                //***************************** 
                //imprime o rodapé do relatório 
                //***************************** 
                e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 650, 1095);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, 1115, 800, 1115);
                e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 50, 1130);
                e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 650, 1130);

                pag += 1;  // reajustando contadores de pag

                // trocando de página
                if ((pag > 1) & (registro < fim))
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;

                    pag = 1; 
                   
                    registro = 0;
                    linha = 0; 
                    bs_disc.MoveFirst();    

                }          
        }
          


        private void btnimp_Click(object sender, EventArgs e)
        {
              
  
                ptDiaDisc.ShowDialog();
                pDoc.Print();


        }

        private void Relatorio_Cad_Disciplina_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Conexao.fecharConexao();
            else
            {
                e.Cancel = true;
            }
        }









    }
}
