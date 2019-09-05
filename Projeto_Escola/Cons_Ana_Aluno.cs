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
    public partial class Cons_Ana_Aluno : Form
    {
        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //dr e bs para a tabela aluno
        OleDbDataReader dr_alu;
        BindingSource bs_alu = new BindingSource();

        //dr e bs para o grid (inner join)
        OleDbDataReader dr_reg;
        BindingSource bs_reg = new BindingSource();


        //cria a variavel que receberá a query
        String _query;
        int cont = 0;

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














        public Cons_Ana_Aluno()
        {
            InitializeComponent();
           
            
        }

        private void cmb_aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_matricula.Text = cmb_aluno.SelectedValue.ToString();

            if (cont == 1)
            {
                _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina WHERE Alunos.Matricula = " + lbl_matricula.Text + " ORDER BY Alunos.Nome";
                     
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
                    MessageBox.Show("Não temos alunos cadastradas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }



        }

        private void Cons_Ana_Aluno_Load(object sender, EventArgs e)
        {
            carregar_grid();
            carregar_aluno();
            cont = 1;
        }

        private void Cons_Ana_Aluno_FormClosing(object sender, FormClosingEventArgs e)
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
