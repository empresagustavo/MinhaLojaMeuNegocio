using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Models.Base
{
    public class Pessoa : Nomenclatura
    {
        [MaxLength(16)]
        public string Celular { get; set; }
        
        [MaxLength(16)]
        public string CelularOpcional { get; set; }

        [MaxLength(14)]
        public string Telefone { get; set; }
        
        [DisplayName("E-Mail")]
        [MaxLength(50, ErrorMessage = "O limite máximo de caracteres é 50.")]
        public string Email { get; set; }

        [DisplayName("Endereço")]
        [MaxLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
        public string Endereco { get; set; }

        [DisplayName("CPF/CNPJ")]
        [Required]
        [MaxLength(18, ErrorMessage = "Documento inválido.")]
        public string CpfCnp { get; set; }
    }
}
