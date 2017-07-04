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

        [DisplayName("Cliente")]
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [DisplayName("Valor Total")]
        public decimal ValorTotal { get; set; }

        [DisplayName("Valor do Frete")]
        public decimal ValorFrete { get; set; }
    }
}