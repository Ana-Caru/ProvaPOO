using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3C1ANACAROLINA01.Code.DTO;
using _3C1ANACAROLINA01.Code.DAL;
using System.Data;

namespace _3C1ANACAROLINA01.Code.BLL
{
    internal class SMEpaBLL
    {
        SMEpaDAL conexao=new SMEpaDAL();
        string tabela="tbl_Produto";

        public void inserir (SMEpaDTO meddto)
        {
            string inserir = $"insert into {tabela} values(null, '{meddto.Produto}','{meddto.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(SMEpaDTO meddto)
        {
            string alterar = $"update {tabela} set Produto = '{meddto.Produto}', Preco = '{meddto.Preco}' where id = '{meddto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(SMEpaDTO meddto)
        {
            string Excluir = $"delete from {tabela} where id = '{meddto.Id}';";
            conexao.ExecutarComando(Excluir);
        }
    }


}
