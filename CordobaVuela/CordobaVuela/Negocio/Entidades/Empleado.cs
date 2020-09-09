using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Negocio.Entidades
{
    public class Empleado
    {
        public Empleado()

        public int Legajo { get; set; }
        public string IdUsuario { get; set; }
        public bool Borrado { get; set; }

        public Empleado()
        {

        }


        public Empleado(int Legajo, string IdUsuario, bool Borrado)
        {
            this.Legajo = Legajo;
            this.IdUsuario = IdUsuario;
            this.Borrado = Borrado;
        }

    }
}