using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Negocio.Entidades
{
    public class Avion
    {
        public Avion()

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Borrado { get; set; }

        public Avion()
        {

        }


        public Empleado(int Id, string Descripcion, bool Borrado)
        {
            this.Id = Id;
            this.Descripcion = Descripcion;
            this.Borrado = Borrado;
        }
 
    }
}