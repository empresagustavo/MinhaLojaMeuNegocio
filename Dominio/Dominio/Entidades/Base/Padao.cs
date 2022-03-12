using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Base
{
    public class Padao
    {
        public Guid EntidadeId { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime? DataDeAtualizacao { get; set; }
        public bool Ativo { get; set; }
    }
}
