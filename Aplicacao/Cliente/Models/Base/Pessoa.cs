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

        [MaxLength(14)]
        public string Telefone { get; set; }
        
        [DisplayName("E-Mail")]
        [MaxLength(50, ErrorMessage = "O limite máximo de caracteres é 50.")]
        public string Email { get; set; }

        [DisplayName("Endereço")]
        [MaxLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
        public string Endereco { get; set; }

        [DisplayName("CPF/CNPJ")]
        [MaxLength(18)]
        public string CpfCnp { get; set; }
    }
}
