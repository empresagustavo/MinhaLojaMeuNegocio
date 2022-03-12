using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Models.Base
{
    public class Padao
    {
        [Key]
        public Guid EntidadeId { get; set; }

        [DisplayName("Cadastro")]
        public DateTime DataDeCadastro { get; set; }

        [DisplayName("Atualização")]  
        public DateTime? DataDeAtualizacao { get; set; }

        public bool Ativo { get; set; }
    }
}
