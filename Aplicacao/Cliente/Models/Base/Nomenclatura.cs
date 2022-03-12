﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Models.Base
{
    public class Nomenclatura : Padao
    {
        [Required]
        [MaxLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
        public string Descricao { get; set; }

        [DisplayName("Observação")]
        [MaxLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
        public string Observacao { get; set; }
    }
}
