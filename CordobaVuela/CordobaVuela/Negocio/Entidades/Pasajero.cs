using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Negocio.Entidades
{
    public class Pasajero
    {
        public Pasajero()

        public int Documento { get; set; }
        public int IdTipoDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_nac { get; set; }
        public string IdUsuario { get; set; }

        public Pasajero()
        {

        }


        public Pasajero(int Documento , int IdTipoDoc, string Nombre, string Apellido, string Fecha_nac, string IdUsuario)

        {
            this.Documento = Documento;
            this.IdTipoDoc = IdTipoDoc;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Fecha_nac = Fecha_nac;
            this.IdUsuario = IdUsuario;
        }

    }
}