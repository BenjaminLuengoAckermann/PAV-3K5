﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Negocio.Entidades
{
    public class Pais
    {
        public int IdPais { get; set; }
        public string Nombre { get; set; }

        public Pais()
        {

        }


        public Pais(int idPais, string nom)
        {
            this.IdPais = idPais;
            this.Nombre = nom;

        }



    }
}
