using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Negocio.Entidades
{
    public class Ciudad
    {
        public int IdCiudad { get; set; }
        public string Nombre { get; set; }

        public int Provincia { get; set; }

        public Ciudad()
        {

        }

        public Ciudad(int idCiu, string nom, int prov)
        {
            this.IdCiudad = idCiu; 
            this.Nombre = nom;
            this.Provincia = prov;
        }


    }
}
