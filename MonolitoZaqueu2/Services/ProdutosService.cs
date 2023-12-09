using MonolitoZaqueu2.Repository;
using MonolitoZaqueu2.Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonolitoZaqueu2.Services
{
    public class ProdutosService
    {
        private readonly ProdutosDAL produtosDAL = new ProdutosDAL();

        public List<tabProduto> ObterProdutos()
        {
            return produtosDAL.ObterProdutos();
        }
    }
}