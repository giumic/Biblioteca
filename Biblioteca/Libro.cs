﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro : Documento
    {
        public int NumeroPagine { get; set; }

        public Libro(string Codice, string Titolo, int Anno, string Settore, int NumeroPagine) : base(Codice, Titolo, Anno, Settore)
        {
            this.NumeroPagine = NumeroPagine;
        }

        public override string ToString()
        {
            return string.Format("{0}\nNumeroPagine:{1}",
                base.ToString(),
                this.NumeroPagine);
            //test 7 luglio
            //modifica 2
            //provadenny
        }
    }
}
