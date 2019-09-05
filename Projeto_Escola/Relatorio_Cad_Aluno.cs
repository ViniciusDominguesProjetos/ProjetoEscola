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
    public partial class Relatorio_Cad_Aluno : Form
    {
        public Relatorio_Cad_Aluno()
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
            _query = "Select * from Alunos";
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
                MessageBox.Show("Não temos alunos cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnimp_Click(object sender, EventArgs e)
        {
            ptDiaAlu.ShowDialog();
            pDoc.Print();
        }

        private void btnvisu_Click(object sender, EventArgs e)
        {
            ptPPAlu.Text = " Visualizando a impressão";   // título da janela
            ptPPAlu.WindowState = FormWindowState.Maximized;  // status da janela do preview
            ptPPAlu.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            ptPPAlu.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            ptPPAlu.ShowDialog();
        }

        private void pDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            DataGridViewRow reg_grid;
            reg_grid = dgv_disc.CurrentRow;



            e.Graphics.DrawImage(Image.FromFile("logo_ete.jpg"), 50, 5);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("RELATÓRIO GERAL DE ALUNOS", new System.Drawing.Font("Consolas", 14, FontStyle.Bold), Brushes.Black, 800, 55);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)
            linha = 100;

            // cabeçalho de colunas
            e.Graphics.DrawString("Mat.  ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);
            e.Graphics.DrawString("Nome   ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 100, linha);
            e.Graphics.DrawString("Data Nasc.", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 240, linha);
            e.Graphics.DrawString("Endereço", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 330, linha);
            e.Graphics.DrawString("Nº", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 490, linha);
            e.Graphics.DrawString("Bairro", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 550, linha);
            e.Graphics.DrawString("Cidade", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 630, linha);
            e.Graphics.DrawString("CEP", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 710, linha);
            e.Graphics.DrawString("RG", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 800, linha);
            e.Graphics.DrawString("CPF", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 900, linha);
            e.Graphics.DrawString("Telefone", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 1010, linha);
            e.Graphics.DrawString("Sexo", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 1110, linha);
            linha = 130;

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 85, 1150, 85);

            while ((linha < 730) & (registro != fim))
            {
                // matricula
                e.Graphics.DrawString(reg_grid.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 50, linha);
                // nome
                e.Graphics.DrawString(reg_grid.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 100, linha);
                // nasc
                e.Graphics.DrawString(String.Format("{0:dd/MM/yyyy}", reg_grid.Cells["Nasc"].Value), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 240, linha);
                // nasc
                e.Graphics.DrawString(reg_grid.Cells["Endereco"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 330, linha);
                // nasc
                e.Graphics.DrawString(reg_grid.Cells["numero"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 490, linha);
                // nasc
                e.Graphics.DrawString(reg_grid.Cells["bairro"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 550, linha);
                // nasc
                e.Graphics.DrawString(reg_grid.Cells["cidade"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 630, linha);
                // nasc
                e.Graphics.DrawString(reg_grid.Cells["cep"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 710, linha);
                // nasc
                e.Graphics.DrawString(reg_grid.Cells["RG"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 800, linha);
                // nasc
                e.Graphics.DrawString(reg_grid.Cells["cpf"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 900, linha);
                // nasc
                e.Graphics.DrawString(reg_grid.Cells["telefone"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 1010, linha);
                // nasc
                e.Graphics.DrawString(reg_grid.Cells["sexo"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 1110, linha);





                bs_disc.MoveNext();
                reg_grid = dgv_disc.CurrentRow;  // atualizando a linha da grid para impressão

                registro += 1;   // incrementando a variável contadora de registros

                linha += 30; // incrementando a variável para pular linha
            }

            //***************************** 
            //imprime o rodapé do relatório 
            //***************************** 
            e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 1000, 750);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, 770, 1150, 770);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 50, 790);
            e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 1000, 785);

            pag += 1;  // reajustando contadores de pag

            // trocando de página
            if ((pag > 1) & (registro < fim))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;

                pag = 1; // variável para controlar o salto de página

                registro = 0;
                linha = 0;
                bs_disc.MoveFirst();    

            }
        }

        private void Relatorio_Cad_Aluno_Load(object sender, EventArgs e){
            carregar_grid();
            fim = bs_disc.Count;
            pDoc.DefaultPageSettings.Landscape = true;
        }

        private void btnquant_Click(object sender, EventArgs e)
        {
            int a = bs_disc.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Relatorio_Cad_Aluno_FormClosing(object sender, FormClosingEventArgs e)
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
