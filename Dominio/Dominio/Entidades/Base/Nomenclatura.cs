using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Base
{
    public class Nomenclatura : Padao
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
    }
}
