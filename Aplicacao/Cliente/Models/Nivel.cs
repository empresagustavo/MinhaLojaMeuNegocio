using Aplicacao.Models.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacao.Models
{
    public class Nivel : Nomenclatura
    {
        public int Valor { get; set; }
    }
}
