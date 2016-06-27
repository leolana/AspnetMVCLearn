using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="O nome do autor é obrigatório")]
        [StringLength(100, ErrorMessage="O nome do autor deve ter no máximo 100 caracteres")]
        public string Autor { get; set; }

        [Required(ErrorMessage="O título do livro é obrigatório")]
        [StringLength(100, ErrorMessage="O título do livro deve ter no máximo 100 caracteres")]
        public string Titulo { get; set; }

        [StringLength(2048, ErrorMessage="A sinopse do livro deve ter no máximo 2048 caracteres")]
        [DataType(DataType.MultilineText)]
        public string Sinopse { get; set; }

        [DisplayName("Data de lançamento")]
        public DateTime? DataLancamento { get; set; }

        [DisplayName("Preço")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage="O preço do livro é obrigatório")]
        public decimal Preco{get;set;}

        [DisplayName("Categoria")]
        [Required(ErrorMessage="A categoria do livro é obrigatória")]
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}