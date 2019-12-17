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
        public object RetornaListaEstoque()
        {
            var estoque = ctx.Estoques.Where(x => x.Ativo);
            var ususarios = ctx.Usuarios;

            var retorno = from est in estoque
                          join usu in ususarios on est.UsuarioCriacao equals usu.Id
                          select new
                          {
                              Produto = est.Produto,
                              Quantidade = est.Quantidade,
                              Valor = est.Valor,
                              Usuario = usu.Login
                          };
            return retorno;
        }
    }
}
