using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Negocio.Entidades
{
    public class Aeropuerto
    {
        public int IdAeropuerto { get; set; }
        public string Nombre { get; set; }
        public int IdCiudad { get; set; }

        public bool Borrado { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }


        public Aeropuerto()
        {

        }


        public Aeropuerto(int idAero, string nom, int idCiu)
        {
            this.IdAeropuerto = idAero;
            this.Nombre = nom;
            this.IdCiudad = idCiu;

        }

        public Aeropuerto(string nom, int idCiu)
        {
            
            this.Nombre = nom;
            this.IdCiudad = idCiu;

        }
    }
}
