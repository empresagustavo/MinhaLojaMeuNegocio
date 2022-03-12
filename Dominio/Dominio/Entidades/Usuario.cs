using Dominio.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Usuario : Pessoa
    {
        public string LogUsuario { get; set; }
        public string LogSenha { get; set; }
        public int Nivel { get; set; }
    }
}
