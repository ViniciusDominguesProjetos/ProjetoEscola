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
    public partial class regMen : Form
    {

        


        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //dr e bs para a tabela aluno
        OleDbDataReader dr_alu;
        BindingSource bs_alu = new BindingSource();
        //dr e ds para a tabela disciplina
        OleDbDataReader dr_disc;
        BindingSource bs_disc = new BindingSource();
        //dr e bs para a tabela menção
        OleDbDataReader dr_men;
        BindingSource bs_men = new BindingSource();
        //dr e bs para o grid (inner join)
        OleDbDataReader dr_reg;
        BindingSource bs_reg = new BindingSource();


        //cria a variavel que receberá a query
        String _query;

        public regMen()
        {
            InitializeComponent();
          
        }


        private void carregar_aluno()
        {
            //Determine a query desejada
            _query = "SELECT * FROM Alunos ORDER BY Nome";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_alu = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_alu.HasRows == true)
            {
                bs_alu.DataSource = dr_alu;
                cmb_aluno.DataSource = bs_alu;
                cmb_aluno.DisplayMember = "Nome";
                cmb_aluno.ValueMember = "Matricula";
                lbl_matricula.Text = cmb_aluno.SelectedValue.ToString();

            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void carregar_disc()
        {
            //Determine a query desejada
            _query = "SELECT * FROM Disciplinas ORDER BY sigla";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_disc = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
                cmb_disciplina.DataSource = bs_disc;
                cmb_disciplina.DisplayMember = "sigla";
                cmb_disciplina.ValueMember = "cod_disciplina";
                lbl_cod.Text = cmb_disciplina.SelectedValue.ToString();

            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void carregar_men()
        {
            //Determine a query desejada
            _query = "SELECT * FROM Mencao ORDER BY Mencao";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_men = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_men.HasRows == true)
            {
                bs_men.DataSource = dr_men;
                cmb_men.DataSource = bs_men;
                cmb_men.DisplayMember = "Mencao";
                cmb_men.ValueMember = "cod_mencao";
               

            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


     

        private void carregar_grid()
        {
            //Determine a query desejada
            _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina ORDER BY Alunos.Nome";

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
                MessageBox.Show("Não temos menções cadastradas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }




      


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
       
                _query = "Insert into Registro_Mencoes (matricula,cod_disciplina,mencao) Values ";
                _query += "('" + lbl_matricula.Text + "','" + lbl_cod.Text + "','" + cmb_men.Text  + "')";
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

        private void regMen_Load(object sender, EventArgs e)
        {
            carregar_disc();
            carregar_aluno();
            carregar_men();
            carregar_grid();
        }

     

        private void cmb_aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_matricula.Text = cmb_aluno.SelectedValue.ToString();
        }

        private void cmb_disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_cod.Text = cmb_disciplina.SelectedValue.ToString();
        }

        private void regMen_FormClosing(object sender, FormClosingEventArgs e)
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
