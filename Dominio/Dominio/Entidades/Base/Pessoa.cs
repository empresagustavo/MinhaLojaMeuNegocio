using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Base
{
    public class Pessoa : Nomenclatura
    {
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string CpfCnp { get; set; }
    }
}
