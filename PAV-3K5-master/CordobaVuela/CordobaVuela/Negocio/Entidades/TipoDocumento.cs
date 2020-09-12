using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Negocio.Entidades
{
    public class TipoDocumento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdPais { get; set; }

        public TipoDocumento()
        {

        }

        public TipoDocumento(int Id, int IdPais, string Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.IdPais = IdPais;

        }

    }
}
