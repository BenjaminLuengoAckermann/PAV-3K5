using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Negocio.Entidades
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }

        public int Pais { get; set; }

        public Provincia()
        {

        }

        public Provincia(int idProv, string nom, int pais)
        {
            this.IdProvincia = idProv;
            this.Nombre = nom;
            this.Pais = pais;
        }
    }
}
