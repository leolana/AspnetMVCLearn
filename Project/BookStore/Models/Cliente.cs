using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome do cliente")]
        [Required(ErrorMessage="O nome do cliente é obrigatório")]
        [StringLength(100, ErrorMessage="O nome do cliente deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage="O CPF do cliente é obrigatório")]
        [StringLength(14, MinimumLength=14, ErrorMessage="O CPF deve ter 14 caracteres")]
        [RegularExpression(@"^([0-9]){3}\.([0-9]){3}\.([0-9]){3}-([0-9]){2}$", ErrorMessage="O CPF deve estar no formato 000.000.000-00")]
        public string CPF { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage="O endereço do cliente é obrigatório")]
        [StringLength(255, ErrorMessage="O endereço deve ter no máximo 255 caracteres")]
        public string Endereco { get; set; }

        [DisplayName("Município")]
        [Required(ErrorMessage="O município é obrigatório")]
        [StringLength(50, ErrorMessage="O município deve ter no máximo 50 caracteres")]
        public string Municipio { get; set; }

        [Required(ErrorMessage="A UF é obrigatória")]
        [StringLength(2, MinimumLength=2, ErrorMessage="A UF deve ter 2 caracteres")]
        public string UF { get; set; }

        [Required(ErrorMessage="O CEP é obrigatório")]
        [StringLength(9, MinimumLength=9, ErrorMessage="O CEP deve ter 9 caracteres")]
        [RegularExpression("^([0-9]){5}-([0-9]){3}$")]
        public string CEP { get; set; }

        [Required(ErrorMessage="O telefone é obrigatório")]
        [StringLength(13, MinimumLength=8, ErrorMessage="O telefone deve ter entre 8 e 13 caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage= "O e-mail é obrigatório")]
        [StringLength(255, ErrorMessage="O e-mail deve ter no máximo 255 caracteres")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage="A senha é obrigatória")]
        [StringLength(20, MinimumLength=4, ErrorMessage="A senha deve ter entre 4 e 20 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}