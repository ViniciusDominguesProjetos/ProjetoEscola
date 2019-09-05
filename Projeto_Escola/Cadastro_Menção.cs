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
    public partial class Cadastro_Menção : Form
    {
        public Cadastro_Menção()
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
                MessageBox.Show("Não temos menções cadastrados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            cod_men.DataBindings.Add("Text", bs_men, "cod_mencao");
            cod_men.DataBindings.Clear();
            txtmen.DataBindings.Add("Text", bs_men, "Mencao");
            txtmen.DataBindings.Clear();
        }

        private void Cadastro_Menção_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

      


        private void dgv_men_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void dgv_men_KeyPress(object sender, KeyPressEventArgs e)
        {
            igualar_text();
        }

       


        private void txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Mencao where Mencao like '" + txt_Pesquisar.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_men = _dataCommand.ExecuteReader();

            if (dr_men.HasRows == true)
            {
                bs_men.DataSource = dr_men;
            }
            else
            {
                MessageBox.Show("Não há disciplina cadastrada com esta descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Pesquisar.Text = "";
            }
        }


        private void btn_primeiro_Click(object sender, EventArgs e)
        {
            bs_men.MoveFirst();
            // atualiza os campos do formulário com o registro posicionado na memória 
            igualar_text();

        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            bs_men.MoveLast();
            // atualiza os campos do formulário com a posição da memória 
            igualar_text();

        }



        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (bs_men.Position == 0)
                MessageBox.Show("Inicio de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_men.MovePrevious();
            igualar_text();

        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            if (bs_men.Count == bs_men.Position + 1)
                MessageBox.Show("Fim de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_men.MoveNext();
            igualar_text();

        }
       

        private void limpar()
        {

            cod_men.Text = "";
            txtmen.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            txtmen.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            _query = "delete from Mencao where cod_mencao like '" + cod_men.Text + "'";
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
                MessageBox.Show("Excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpar();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com a exclusão!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Cadastro_Menção_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Conexao.fecharConexao();
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            bool teste; // variável para receber o valor de "erro" após executar valida
            teste = valida(); // executando "valida" e armazenando o resultado na variável "erro"
            if (teste == false)
            {
                _query = "Update Mencao set Mencao ='" + txtmen.Text + "'";
                _query += "where cod_mencao like '" + cod_men.Text + "'";

                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas com a alteração!" + ex, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private bool valida()
        {
            bool erro = true;
            if (txtmen.Text == "")
            {
                MessageBox.Show("Campo 'Menção' vazio. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmen.Focus();
            }
         

            else
            {
                erro = false;
            }
            return erro;
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            bool teste; // variável para receber o valor de "erro" após executar valida
            teste = valida(); // executando "valida" e armazenando o resultado na variável "erro"
            if (teste == false)
            {
                _query = "Insert into Mencao (Mencao) Values ";
                _query += "('" + txtmen.Text + "')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Incluido com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com a inclusão!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void dgv_men_Click(object sender, EventArgs e)
        {

            igualar_text();
        }

       
      
        

       






    }
}

