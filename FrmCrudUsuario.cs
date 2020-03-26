using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LojaCL
{
    public partial class FrmCrudUsuario : Form
    {
        public FrmCrudUsuario()
        {
            InitializeComponent();
        }

        public void CarregaDgvUsuario()
        {
            SqlConnection con = clConexao.ObterConexao();
            String query = "select * from usuario";
            SqlCommand cmd = new SqlCommand(query, con);
            clConexao.ObterConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable produto = new DataTable();
            da.Fill(produto);
            DgvUsuario.DataSource = produto;
            clConexao.fecharConexao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = clConexao.ObterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                clConexao.ObterConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvUsuario();
                MessageBox.Show("Registro inserido com sucesso!", "Cadastro", MessageBoxButtons.OK);
                clConexao.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = clConexao.ObterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@nome", this.txtNome.Text);
                cmd.Parameters.AddWithValue("@login", this.txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", this.txtSenha.Text);
                clConexao.ObterConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvUsuario();
                MessageBox.Show("Registro atualizado com sucesso!", "Atualizar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clConexao.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = clConexao.ObterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "ExcluirUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                clConexao.ObterConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvUsuario();
                MessageBox.Show("Registro apagado com sucesso!", "Excluir Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clConexao.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = clConexao.ObterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                clConexao.ObterConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    txtLogin.Text = rd["login"].ToString();
                    txtSenha.Text = rd["senha"].ToString();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Sem registro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
            }
        }

        private void DgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DgvUsuario.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtLogin.Text = row.Cells[2].Value.ToString();
                txtSenha.Text = row.Cells[3].Value.ToString();
            }
        }

        private void FrmCrudUsuario_Load(object sender, EventArgs e)
        {
            CarregaDgvUsuario();
        }
    }
}
