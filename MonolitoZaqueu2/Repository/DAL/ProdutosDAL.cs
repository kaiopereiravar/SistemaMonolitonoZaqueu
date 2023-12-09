using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonolitoZaqueu2.Repository.DAL
{
    public class ProdutosDAL
    {
        public List<tabProduto> ObterProdutos()
        {
            using (var ctx = new DbZaqueuEntities())
            {
                return ctx.tabProdutos.ToList();

            }
        }
    }
}