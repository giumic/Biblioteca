﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class DVD : Documento
    {

        public int Durata { get; set; }

        public DVD(string Codice, string Titolo, int Anno, string Settore, int Durata) : base(Codice, Titolo, Anno, Settore)
        {
            this.Durata = Durata;
        }

        public override string ToString()
        {
            return string.Format("{0}\nDurata:{1}",
                base.ToString(),
                this.Durata);
            //Commento inserito in data 30 giugno 2023

            ///ciao
        }   
        ///Ciao 6 Luglio
        ///ciao 45
    }   ///Ciao 78
}
