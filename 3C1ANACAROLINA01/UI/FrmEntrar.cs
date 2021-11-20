using _3C1ANACAROLINA01.Code.BLL;
using _3C1ANACAROLINA01.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1ANACAROLINA01.UI
{
    public partial class FrmEntrar : Form
    {
        ClasseLoginDTO LoginDTO = new ClasseLoginDTO();
        ClasseLoginBLL LoginBLL = new ClasseLoginBLL();
        public FrmEntrar()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginDTO.Email = textBoxEmail.Text;
            LoginDTO.Senha = textBoxSenha.Text;
            if (LoginBLL.RealizarLogin(LoginDTO) == true)
            {
                FormLogin Produto = new FormLogin();
                Produto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o e-mail e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEntrar_Load(object sender, EventArgs e)
        {

        }
    }
}
