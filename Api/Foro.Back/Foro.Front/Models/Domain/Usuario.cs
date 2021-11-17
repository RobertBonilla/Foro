using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foro.Front.Models.Domain
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string username { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contra { get; set; }
        public bool activo { get; set; }

    }
}
