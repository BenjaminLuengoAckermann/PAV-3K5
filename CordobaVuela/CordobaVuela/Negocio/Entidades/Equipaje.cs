using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Negocio.Entidades
{
    public class Equipaje
    {
        public Equipaje()

        public int Id { get; set; }
        public int Peso { get; set; }
        public bool Borrado { get; set; }

        public Equipaje()
        {

        }


        public Equipaje(int Id, int Peso, bool Borrado)

        {
            this.Id = Id;
            this.Peso = Peso;
            this.Borrado = Borrado;

        }

    }
}