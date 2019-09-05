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
    public partial class Relatorio_Analitico : Form
    {
        public Relatorio_Analitico()
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
        OleDbDataReader dr_reg;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_reg = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

   

        private void Relatorio_Analitico_Load(object sender, EventArgs e){

            cmb_esc.SelectedIndex = 0;
            fim = bs_reg.Count;
        }

        private void carregar_men() {

                dgv_reg.DataSource = null;
                //Determine a query desejada
                _query = "SELECT Registro_Mencoes.mencao, Alunos.Matricula, Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina ORDER BY Registro_Mencoes.mencao";

                //declare o objeto DataCommand passando a query e o objeto de conexão
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                //execute o método ExecuteReader que retornará um DataReader preenchido com a query
                dr_reg = _dataCommand.ExecuteReader();
                //Teste para verificar se retornaram linhas
                if (dr_reg.HasRows == true)
                {
                    bs_reg.DataSource = dr_reg;
                    dgv_reg.DataSource = bs_reg;

                }
                else
                {
                    MessageBox.Show("Erro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            
        
        
        }

        private void carregar_disc()
        {
            dgv_reg.DataSource = null;
            //Determine a query desejada
            _query = "SELECT Disciplinas.sigla, Alunos.Matricula, Alunos.Nome, Registro_Mencoes.mencao, Disciplinas.descricao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina ORDER BY Disciplinas.sigla";


            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_reg = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_reg.HasRows == true)
            {
                bs_reg.DataSource = dr_reg;
                dgv_reg.DataSource = bs_reg;

            }
            else
            {
                MessageBox.Show("Erro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        private void carregar_b()
        {
            dgv_reg.DataSource = null;
            //Determine a query desejada
            _query = "SELECT Alunos.Nome, Alunos.Matricula, Registro_Mencoes.mencao, Disciplinas.sigla, Disciplinas.descricao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina ORDER BY Alunos.Nome";


            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_reg = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_reg.HasRows == true)
            {
                bs_reg.DataSource = dr_reg;
                dgv_reg.DataSource = bs_reg;

            }
            else
            {
                MessageBox.Show("Erro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        private void cmb_esc_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_esc.SelectedItem.ToString() == "Agrupado por Menção")
            {

                carregar_men();

            }


            else if (cmb_esc.SelectedItem.ToString() == "Agrupado por Disciplina")
            {
                carregar_disc();
            }

            else if (cmb_esc.SelectedItem.ToString() == "Boletim")
            
            {
                carregar_b();
            }



        }

        private void pDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          

            if (cmb_esc.SelectedItem.ToString() == "Agrupado por Menção")
            {
                DataGridViewRow reg_grid;
                reg_grid = dgv_reg.CurrentRow;
                String nota = reg_grid.Cells["mencao"].Value.ToString();
                String ant = nota;

                e.Graphics.DrawImage(Image.FromFile("logo_ete.jpg"), 50, 5);
                // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
                e.Graphics.DrawString("RELATÓRIO AGRUPADO POR MENÇÃO", new System.Drawing.Font("Consolas", 14, FontStyle.Bold), Brushes.Black, 410, 50);
                //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)
                e.Graphics.DrawString("Menção: " + nota, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, 100);
                linha = 150;

                // cabeçalho de colunas
                e.Graphics.DrawString("Matrícula ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);
                e.Graphics.DrawString("Nome   ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 150, linha);
                e.Graphics.DrawString("Descrição ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 400, linha);
                e.Graphics.DrawString("Sigla ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 650, linha);

                linha = 185;
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 85, 800, 85);


                e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 125, 800, 125);


                while ((linha < 1020) & (registro != fim))
                {
                    nota = reg_grid.Cells["mencao"].Value.ToString();
                    if (nota.Equals(ant) == false)
                    {
                        e.Graphics.DrawString("Total de Registros: " + cont, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 650, linha);
                        linha += 40;
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 800, linha);
                        linha += 10;
                        e.Graphics.DrawString("Menção: " + nota, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);

                        linha += 20;
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 800, linha);
                        linha += 20;
                        e.Graphics.DrawString("Matrícula ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);
                        e.Graphics.DrawString("Nome   ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 150, linha);
                        e.Graphics.DrawString("Descrição", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 400, linha);
                        e.Graphics.DrawString("Sigla", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 650, linha);
                        linha += 30;
                        cont = 0;
                        ant = nota;

                        


                    }
                    cont++;

                    // código
                    e.Graphics.DrawString(reg_grid.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 50, linha);
                    // código
                    e.Graphics.DrawString(reg_grid.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 150, linha);
                    // descrição
                    e.Graphics.DrawString(reg_grid.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 400, linha);
                    e.Graphics.DrawString(reg_grid.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 650, linha);

                    bs_reg.MoveNext(); // movendo para o próximo registro 

                    reg_grid = dgv_reg.CurrentRow;  // atualizando a linha da grid para impressão

                    registro += 1;   // incrementando a variável contadora de registros

                    linha += 30; // incrementando a variável para pular linha
                    if (registro == fim)
                    {
                        e.Graphics.DrawString("Total de Registros: " + cont, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 650, linha);
                    }
                }


                //***************************** 
                //imprime o rodapé do relatório 
                //***************************** 
                e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 650, 1095);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, 1115, 800, 1115);
                e.Graphics.DrawString("Hora: " + DateTime.Now.ToString("HH:mm:ss"), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 200, 1130);
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
                    bs_reg.MoveFirst();
                    cont = 0;

                }
            }

            else if (cmb_esc.SelectedItem.ToString() == "Agrupado por Disciplina")
            {
                DataGridViewRow reg_grid;
                reg_grid = dgv_reg.CurrentRow;
                String de = reg_grid.Cells["descricao"].Value.ToString();
                String dea = de;
                String sig = reg_grid.Cells["sigla"].Value.ToString();
                String siga = sig;

                e.Graphics.DrawImage(Image.FromFile("logo_ete.jpg"), 50, 5);
                // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
                e.Graphics.DrawString("RELATÓRIO AGRUPADO POR DISCIPLINA", new System.Drawing.Font("Consolas", 14, FontStyle.Bold), Brushes.Black, 410, 50);
                //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)
                e.Graphics.DrawString("Sigla: " + sig, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, 100);
                 e.Graphics.DrawString("- " + de, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 120, 100);

                linha = 150;

                // cabeçalho de colunas
                e.Graphics.DrawString("Matrícula ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);
                e.Graphics.DrawString("Nome   ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 150, linha);
               
                e.Graphics.DrawString("Menção ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 400, linha);

                linha = 185;
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 85, 800, 85);


                e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 125, 800, 125);


                while ((linha < 1020) & (registro != fim))
                {
                    sig = reg_grid.Cells["sigla"].Value.ToString();
                    de = reg_grid.Cells["descricao"].Value.ToString();
                    if (sig.Equals(siga) == false)
                    {
                       
                        e.Graphics.DrawString("Total de Registros: " + cont, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 650, linha);
                        linha += 40;
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 800, linha);
                        linha += 10;
                        e.Graphics.DrawString("Sigla: " + sig, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);
                        e.Graphics.DrawString("- " + de, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 120, linha);
                        linha += 25;
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 800, linha);
                        linha += 20;
                        e.Graphics.DrawString("Matrícula ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);
                        e.Graphics.DrawString("Nome   ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 150, linha);

                        e.Graphics.DrawString("Menção", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 400, linha);
                        linha += 30;
                        cont = 0;
                        siga = sig;
                        dea = de;

                       
                    }
                    cont++;

                    // código
                    e.Graphics.DrawString(reg_grid.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 50, linha);
                    // código
                    e.Graphics.DrawString(reg_grid.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 150, linha);
                    // descrição
                   
                    e.Graphics.DrawString(reg_grid.Cells["mencao"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 400, linha);

                    bs_reg.MoveNext(); // movendo para o próximo registro 

                    reg_grid = dgv_reg.CurrentRow;  // atualizando a linha da grid para impressão

                    registro += 1;   // incrementando a variável contadora de registros

                    linha += 30; // incrementando a variável para pular linha
                    if (registro == fim)
                    {
                        e.Graphics.DrawString("Total de Registros: " + cont, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 650, linha);
                    }
                }


                //***************************** 
                //imprime o rodapé do relatório 
                //***************************** 
                e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 650, 1095);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, 1115, 800, 1115);
                e.Graphics.DrawString("Hora: " + DateTime.Now.ToString("HH:mm:ss"), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 200, 1130);
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
                    bs_reg.MoveFirst();
                    cont = 0;

                }


            }




            else if (cmb_esc.SelectedItem.ToString() == "Boletim")
            {
                DataGridViewRow reg_grid;
                reg_grid = dgv_reg.CurrentRow;
                String nome = reg_grid.Cells["Nome"].Value.ToString();
                String nomea = nome;
                String mat = reg_grid.Cells["Matricula"].Value.ToString();
                String mata = mat;

                e.Graphics.DrawImage(Image.FromFile("logo_ete.jpg"), 50, 5);
                // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
                e.Graphics.DrawString("BOLETIM", new System.Drawing.Font("Consolas", 14, FontStyle.Bold), Brushes.Black, 600, 50);
                //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)
                e.Graphics.DrawString("Nome do Aluno: " + nome, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, 100);
                e.Graphics.DrawString("Matrícula: " + mat, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 400, 100);
                linha = 150;

                // cabeçalho de colunas
                e.Graphics.DrawString("Sigla ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);
                e.Graphics.DrawString("Descrição ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 150, linha);

                e.Graphics.DrawString("Menção ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 400, linha);

                linha = 185;
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 85, 800, 85);


                e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 125, 800, 125);


                while ((linha < 1020) & (registro != fim))
                {
                    nome = reg_grid.Cells["Nome"].Value.ToString();
                    mat = reg_grid.Cells["Matricula"].Value.ToString();
                    if (nome.Equals(nomea) == false)
                    {
                        linha += 40;
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 800, linha);
                        linha += 10;
                        e.Graphics.DrawString("Nome do Aluno: " + nome, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);
                        e.Graphics.DrawString("Matrícula: " + mat, new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 400, linha);
                        linha += 25;
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 800, linha);
                        linha += 20;
                        e.Graphics.DrawString("Sigla ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 50, linha);
                        e.Graphics.DrawString("Descrição ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 150, linha);
                        e.Graphics.DrawString("Menção ", new System.Drawing.Font("Consola", 10, FontStyle.Bold), Brushes.Black, 400, linha);
                        linha += 30;
                        cont = 0;

                        nomea = nome;
                        mata = mat;


                    }

                    cont++;

                    // código
                    e.Graphics.DrawString(reg_grid.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 50, linha);
                    // código
                    e.Graphics.DrawString(reg_grid.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 150, linha);

                    e.Graphics.DrawString(reg_grid.Cells["mencao"].Value.ToString(), new System.Drawing.Font("Consola", 10, FontStyle.Regular), Brushes.Black, 400, linha);

                    bs_reg.MoveNext(); // movendo para o próximo registro 

                    reg_grid = dgv_reg.CurrentRow;  // atualizando a linha da grid para impressão
                    nome = reg_grid.Cells["Nome"].Value.ToString(); ;

                    registro += 1;   // incrementando a variável contadora de registros

                    linha += 30; // incrementando a variável para pular linha

                    if (nome.Equals(nomea) == false)
                    {
                        linha = 1030;
                    }
                }
          
               
                //***************************** 
                //imprime o rodapé do relatório 
                //***************************** 
              
                e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, 1115, 800, 1115);
                e.Graphics.DrawString("Hora: " + DateTime.Now.ToString("HH:mm:ss"), new System.Drawing.Font("Consola", 9, FontStyle.Bold), Brushes.Black, 200, 1130);
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
                    bs_reg.MoveFirst();
                    cont = 0;

                }


            }

         


        }

        private void btnimp_Click(object sender, EventArgs e)
        {
            ptDia.ShowDialog();
            pDoc.Print();
        }

        private void btnvisu_Click(object sender, EventArgs e)
        {
            ptPP.Text = " Visualizando a impressão";   // título da janela
            ptPP.WindowState = FormWindowState.Maximized;  // status da janela do preview
            ptPP.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            ptPP.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            ptPP.ShowDialog();
        }









    }











































 
}
