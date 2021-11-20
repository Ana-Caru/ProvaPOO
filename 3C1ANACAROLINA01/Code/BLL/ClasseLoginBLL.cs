using _3C1ANACAROLINA01.Code.DAL;
using _3C1ANACAROLINA01.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1ANACAROLINA01.Code.BLL
{
    
    internal class ClasseLoginBLL
    {
        SMEpaDAL conexao = new SMEpaDAL();
        string tabela = "tbl_Usuarios";

        public bool RealizarLogin(ClasseLoginDTO Login)
        {
            string sql = $"select * from {tabela} where email='{Login.Email}' and senha='{Login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
