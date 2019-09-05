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
    public partial class Cons_Ana_Disc : Form
    {

        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //dr e ds para a tabela disciplina
        OleDbDataReader dr_disc;
        BindingSource bs_disc = new BindingSource();

        //dr e bs para o grid (inner join)
        OleDbDataReader dr_reg;
        BindingSource bs_reg = new BindingSource();


        //cria a variavel que receberá a query
        String _query;
        int cont = 0;


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
                cmb_disciplina.ValueMember = "descricao";
                lbl_cod.Text = cmb_disciplina.SelectedValue.ToString();

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


     




        public Cons_Ana_Disc()
        {
            InitializeComponent();
            
        }


  

        private void Cons_Ana_Disc_Load(object sender, EventArgs e)
        {
            carregar_grid();
            carregar_disc();
            cont = 1;
        }

        private void Cons_Ana_Disc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Conexao.fecharConexao();
            else
            {
                e.Cancel = true;
            }
        }

    

        private void cmb_disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_cod.Text = cmb_disciplina.SelectedValue.ToString();

            //Determine a query desejada
            if (cont== 1)
            {
                lbl_cod.Text = cmb_disciplina.SelectedValue.ToString();
                _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina WHERE Disciplinas.descricao = '" + lbl_cod.Text + "' ORDER BY Alunos.Nome";
               
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
        }



       
    }
}
