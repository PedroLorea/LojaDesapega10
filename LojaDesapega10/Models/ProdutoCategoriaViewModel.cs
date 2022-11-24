using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LojaDesapega10.Models
{
    public class ProdutoCategoriaViewModel
    {
        public List<Produto> Produtos { get; set; }
        public SelectList Categoria { get; set; }
        public string ProdutoCategoria { get; set; }
        public string SearchString { get; set; }
        
    }
}
