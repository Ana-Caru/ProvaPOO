using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3C1ANACAROLINA01.Code.BLL;
using _3C1ANACAROLINA01.Code.DTO;

namespace _3C1ANACAROLINA01
{

    public partial class FormLogin : Form
    {
        SMEpaBLL medbll = new SMEpaBLL();
        SMEpaDTO meddto = new SMEpaDTO();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            dataGridViewProdutos.DataSource = medbll.Listar();
           
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            meddto.Produto = textBoxProduto.Text;
            meddto.Preco = textBoxPreco.Text;
            
            medbll.inserir(meddto);
            MessageBox.Show("Cadastro registrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxId.Clear();
            textBoxPreco.Clear();
            dataGridViewProdutos.DataSource = medbll.Listar();
        }


        private void buttonEditar_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(textBoxId.Text);
            meddto.Produto = textBoxProduto.Text;
            meddto.Preco = textBoxPreco.Text;

            medbll.Editar(meddto);

            MessageBox.Show("Editado com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridViewProdutos.DataSource = medbll.Listar();

            textBoxId.Clear();
            textBoxProduto.Clear();
            textBoxPreco.Clear();

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(textBoxId.Text);

            medbll.Excluir(meddto);

            MessageBox.Show("Exluido com Sucesso", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridViewProdutos.DataSource = medbll.Listar();

            textBoxId.Clear();
            textBoxPreco.Clear();
            textBoxProduto.Clear();

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void labelProduto_Click(object sender, EventArgs e)
        {

        }

        private void textBoxProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPreco_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxProduto.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPreco.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
