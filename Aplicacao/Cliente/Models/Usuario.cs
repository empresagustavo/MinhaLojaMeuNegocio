using Aplicacao.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Aplicacao.Models
{
    [Table("Usuarios")]
    public class Usuario : Pessoa
    {
        [DisplayName("Usuário")]
        [MaxLength(20, ErrorMessage = "O limite máximo de caracteres é 20.")]
        [Required]
        public string LogUsuario { get; set; }

        [DisplayName("Senha")]
        [Required]
        [MaxLength(8, ErrorMessage = "O limite máximo de caracteres é 8.")]
        public string LogSenha { get; set; }
        
        [DisplayName("Nível")]
        public Guid NivelId { get; set; }
        public Nivel Nivel { get; set; }
    }
}
