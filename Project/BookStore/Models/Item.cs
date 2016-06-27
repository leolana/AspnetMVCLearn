using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Item
    {
        [DisplayName("Livro")]
        [Key, Column(Order = 0)]
        [ForeignKey("Livro")]
        public int LivroId { get; set; }
        public virtual Livro Livro { get; set; }

        [DisplayName("Carrinho")]
        [Key, Column(Order = 1)]
        [ForeignKey("Carrinho")]
        public int CarrinhoId { get; set; }
        public virtual Carrinho Carrinho { get; set; }

        public int Quantidade { get; set; }
    }
}