using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Text;

namespace BookStore.Models
{
    public class CategoriaLivro
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}