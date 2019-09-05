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
    public partial class Cadastro_Disciplina : Form
    {
        public Cadastro_Disciplina()
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
                MessageBox.Show("Não temos disciplinas cadastrados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            lbl_cod.DataBindings.Add("Text", bs_disc, "cod_disciplina");
            lbl_cod.DataBindings.Clear();
            txtdes.DataBindings.Add("Text", bs_disc, "descricao");
            txtdes.DataBindings.Clear();
            txtsig.DataBindings.Add("Text", bs_disc, "sigla");
            txtsig.DataBindings.Clear();
            txtser.DataBindings.Add("Text", bs_disc, "série");
            txtser.DataBindings.Clear();
        }


        private void Cadastro_Disciplina_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

       
        private void dgv_disc_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Disciplinas where descricao like '" + txt_Pesquisar.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_disc = _dataCommand.ExecuteReader();

            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
            }
            else
            {
                MessageBox.Show("Não há disciplina cadastrada com esta descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Pesquisar.Text = "";
            }
        }


       

        private void btn_primeiro_Click(object sender, EventArgs e)
        {
            bs_disc.MoveFirst();
            // atualiza os campos do formulário com o registro posicionado na memória 
            igualar_text();

        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            bs_disc.MoveLast();
            // atualiza os campos do formulário com a posição da memória 
            igualar_text();

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (bs_disc.Position == 0)
                MessageBox.Show("Inicio de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_disc.MovePrevious();
            igualar_text();

        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            if (bs_disc.Count == bs_disc.Position + 1)
                MessageBox.Show("Fim de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_disc.MoveNext();
            igualar_text();

        }

        private void limpar()
        {
            lbl_cod.Text = "";
            txtdes.Clear();
            txtsig.Clear();
            txtser.Clear();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            txtdes.Focus();
        }

        private void Cadastro_Disciplina_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Conexao.fecharConexao();
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            _query = "delete from Disciplinas where cod_disciplina like '" + lbl_cod.Text + "'";
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
                MessageBox.Show("Excluída com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpar();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com a exclusão!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            bool teste; // variável para receber o valor de "erro" após executar valida
            teste = valida(); // executando "valida" e armazenando o resultado na variável "erro"
            if (teste == false)
            {
                _query = "Update Disciplinas set descricao ='" + txtdes.Text + "',";
                _query += "sigla = '" + txtsig.Text + "',";
                _query += "série = '" + txtser.Text + "'";
                _query += "where cod_disciplina like '" + lbl_cod.Text + "'";

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
            if (txtdes.Text == "")
            {
                MessageBox.Show("Campo 'Descrição' vazio. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdes.Focus();
            }
            else if (txtsig.Text == "")
            {
                MessageBox.Show("Campo 'Sigla' vazio. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsig.Focus();
            }
            else if (txtser.Text == "")
            {
                MessageBox.Show("Campo 'Série' vazio. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtser.Focus();
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
                _query = "Insert into Disciplinas (descricao,sigla,série) Values ";
                _query += "('" + txtdes.Text + "','" + txtsig.Text + "','" + txtser.Text + "')";
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

        private void dgv_disc_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        

      

      

    }
}
