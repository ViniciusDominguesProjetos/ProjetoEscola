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
    public partial class Cons_Ana_Men : Form
    {

        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();

        //dr e bs para a tabela menção
        OleDbDataReader dr_men;
        BindingSource bs_men = new BindingSource();
        //dr e bs para o grid (inner join)
        OleDbDataReader dr_reg;
        BindingSource bs_reg = new BindingSource();


        //cria a variavel que receberá a query
        String _query;
        int cont = 0;

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
                cmb_men.ValueMember = "Mencao";
  


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







        public Cons_Ana_Men()
        {
            InitializeComponent();
        }

        private void cmb_men_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                //Determine a query desejada
                _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina WHERE Registro_Mencoes.mencao = '" + cmb_men.SelectedValue.ToString() + "' ORDER BY Alunos.Nome";

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

        private void Cons_Ana_Men_Load(object sender, EventArgs e)
        {
            carregar_grid();
            carregar_men();
            cont = 1;
        }

        private void Cons_Ana_Men_FormClosing(object sender, FormClosingEventArgs e)
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
