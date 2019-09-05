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
    public partial class Cadastro_Aluno : Form
    {
        public Cadastro_Aluno()
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
                MessageBox.Show("Não há alunos cadastrados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            lbl_cod.DataBindings.Add("Text", bs_aluno, "Matricula");
            lbl_cod.DataBindings.Clear();
            txt_nome.DataBindings.Add("Text", bs_aluno, "Nome");
            txt_nome.DataBindings.Clear();
            txtbairro.DataBindings.Add("Text", bs_aluno, "bairro");
            txtbairro.DataBindings.Clear();
            dtpnasc.DataBindings.Add("Text", bs_aluno, "Nasc");
            dtpnasc.DataBindings.Clear();
            cbsexo.DataBindings.Add("Text", bs_aluno, "sexo");
            cbsexo.DataBindings.Clear();
            txtrg.DataBindings.Add("Text", bs_aluno, "RG");
            txtrg.DataBindings.Clear();
            txtcpf.DataBindings.Add("Text", bs_aluno, "cpf");
            txtcpf.DataBindings.Clear();
            txtendereco.DataBindings.Add("Text", bs_aluno, "Endereco");
            txtendereco.DataBindings.Clear();
            txttel.DataBindings.Add("Text", bs_aluno, "telefone");
            txttel.DataBindings.Clear();
            txtcep.DataBindings.Add("Text", bs_aluno, "cep");
            txtcep.DataBindings.Clear();
            txtnum.DataBindings.Add("Text", bs_aluno, "numero");
            txtnum.DataBindings.Clear();
            txtcid.DataBindings.Add("Text", bs_aluno, "cidade");
            txtcid.DataBindings.Clear();

        }

        private void Cadastro_Aluno_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

       

        private void dgv_aluno_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Alunos where Nome like '" + txt_Pesquisar.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_aluno = _dataCommand.ExecuteReader();

            if (dr_aluno.HasRows == true)
            {
                bs_aluno.DataSource = dr_aluno;
            }
            else
            {
                MessageBox.Show("Não há alunos cadastrados com este nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Pesquisar.Text = "";
            }
        }

        private void btn_primeiro_Click(object sender, EventArgs e)
        {
            bs_aluno.MoveFirst();
            // atualiza os campos do formulário com o registro posicionado na memória 
            igualar_text();
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            bs_aluno.MoveLast();
            // atualiza os campos do formulário com a posição da memória 
            igualar_text();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (bs_aluno.Position == 0)
                MessageBox.Show("Inicio de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_aluno.MovePrevious();
            igualar_text();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            if (bs_aluno.Count == bs_aluno.Position + 1)
                MessageBox.Show("Fim de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_aluno.MoveNext();
            igualar_text(); 
        }

     
       
        private void limpar()
        {
            lbl_cod.Text = "";
            txt_nome.Clear();
            txtbairro.Clear();
            dtpnasc.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbsexo.Text= "";
            txtrg.Clear();
            txtcpf.Clear();
            txtendereco.Clear();
            txttel.Clear();
            txtcep.Clear();
            txtnum.Clear();
            txtcid.Clear();
            
        }

      
        private void Cadastro_Aluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Conexao.fecharConexao();
            else
            {
                e.Cancel = true;
            }
        } 
        
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            txt_nome.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            _query = "delete from Alunos where Matricula like '" + lbl_cod.Text + "'";
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

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            bool teste; // variável para receber o valor de "erro" após executar valida
            teste = valida(); // executando "valida" e armazenando o resultado na variável "erro"
            if (teste == false)
            {
                _query = "Update Alunos set Nome ='" + txt_nome.Text + "',";
                _query += "Nasc = '" + dtpnasc.Text + "',";
                _query += "Endereco = '" + txtendereco.Text + "',";
                _query += "numero = '" + txtnum.Text + "',";
                _query += "bairro = '" + txtbairro.Text + "',";
                _query += "cidade = '" + txtcid.Text + "',";
                _query += "cep = '" + txtcep.Text + "',";
                _query += "RG = '" + txtrg.Text + "',";
                _query += "telefone = '" + txttel.Text + "',";
                _query += "cpf = '" + txtcpf.Text + "',";
                _query += "sexo = '" + cbsexo.Text + "'";
                _query += "where Matricula like '" + lbl_cod.Text + "'";

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
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Campo 'Nome' vazio. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nome.Focus();
            }
            else if (txtbairro.Text == "")
            {
                MessageBox.Show("Campo 'Bairro' vazio. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbairro.Focus();
            }

            else if (txtendereco.Text == "")
            {
                MessageBox.Show("Campo 'Endereço' vazio. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbairro.Focus();
            }

            else if (txtnum.Text == "")
            {
                MessageBox.Show("Campo 'Número' vazio. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbairro.Focus();
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
                _query = "Insert into Alunos (Nome,Nasc,Endereco,numero,bairro,cidade,cep,RG,telefone,cpf,sexo) Values ";
                _query += "('" + txt_nome.Text + "','" + dtpnasc.Text + "','" + txtendereco.Text + "','" + txtnum.Text + "','" + txtbairro.Text + "','" + txtcid.Text + "','" + txtcep.Text + "' ,'" + txtrg.Text + "','" + txttel.Text + "','" + txtcpf.Text + "','" + cbsexo.Text + "')";
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

      

        private void dgv_aluno_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

       

       
       


       


       



    }



}
