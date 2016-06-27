using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Descrição da categoria")]
        [Required(ErrorMessage="A descrição é obrigatoria")]
        [StringLength(100, ErrorMessage="A descrição deve ter no máximo 100 caracteres")]
        public string Descricao { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}