using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Negocio.Entidades
{
   public class Usuario
    {
        public string IdUsuario { get; set; }
        public string Password { get; set; }
        
   
        public Usuario()
        {
            
        }

        public Usuario(string idUsu, string pass)
        {
            this.IdUsuario = idUsu;
            this.Password = pass;
        }
    }
}
