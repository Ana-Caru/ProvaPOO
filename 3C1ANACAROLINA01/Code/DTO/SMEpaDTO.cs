using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1ANACAROLINA01.Code.DTO
{
    internal class SMEpaDTO
    {
        private int _id;
        private string _produto;
        private string _preco;


        public string Preco { get => _preco; set => _preco = value; }
        public int Id { get => _id; set => _id = value; }
        public string Produto { get => _produto; set => _produto = value; }
    }
}
