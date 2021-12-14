﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Biblioteca
    {
        public string Nome { get; set; }
        public List<Documento> Documenti { get; set; }
        public List<Prestito> Prestiti { get; set; }
        public List<Utente> Utenti { get; set; }

        public Biblioteca(string Nome)
        {
            this.Nome = Nome;
            this.Documenti = new List<Documento>();
            this.Prestiti = new List<Prestito>();
            this.Utenti = new List<Utente>();
        }

        public List<Documento> SearchByCodice(string Codice)
        {
            return this.Documenti.Where(d => d.Codice == Codice).ToList();
        }

        public List<Documento> SearchByTitolo(string Titolo)
        {
            return this.Documenti.Where(d => d.Titolo == Titolo).ToList();
        }

        public List<Prestito> SearchPrestiti(string Numero)
        {
            return this.Prestiti.Where(p => p.Numero == Numero).ToList();
        }

        public List<Prestito> SearchPrestiti(string Nome, string Cognome)
        {
            return this.Prestiti.Where(p => p.Utente.Nome == Nome && p.Utente.Cognome == Cognome).ToList();
        }
    }

    enum Stato { Disponibile, Prestito }
    

}
