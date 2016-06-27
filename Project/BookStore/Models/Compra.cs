using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Compra
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Valor total")]
        public decimal ValorTotal { get; set; }

        [ForeignKey("Carrinho")]
        public int CarrinhoId { get; set; }
        public virtual Carrinho Carrinho { get; set; }
    }
}