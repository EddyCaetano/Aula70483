using SistemaContrtoleEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContrtoleEstoque.Controller
{
    public class EstoqueController
    {
        SistemaContext ctx;//declara a porta

        public EstoqueController()
        {
            ctx = new SistemaContext();// abre a porta "carrega na memoria"
        }

        public void InsereEstoque(Estoque item)
        {
            ctx.Estoques.Add(item);
            ctx.SaveChanges();
        }

        public List<Estoque> GetEstoques()
        {
            return ctx.Estoques.ToList<Estoque>();
        }
    }
}
