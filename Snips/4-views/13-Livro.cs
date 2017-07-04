  ﻿using System;
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
        [DataType(DataType.Date)]
        [Required]
        [DisplayName("Data de lançamento")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] //Formatação para exibir apenas Data
        [UIHint("Datepicker")]
        public DateTime DataLancamento { get; set; }
    }
}
