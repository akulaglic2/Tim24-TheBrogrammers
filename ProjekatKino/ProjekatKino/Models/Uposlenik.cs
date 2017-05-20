﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public class Uposlenik : Osoba
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int uposlenikID { get; set; } // primary key
        public int maticniBroj { get; set; }

        public Uposlenik (string ime, string prezime, string adresa, string email, string username, string password, DateTime datumRodjenja, int uposlenikID, int maticniBroj)
                : base(ime, prezime, adresa, email, username, password, datumRodjenja)
            {
            this.uposlenikID = uposlenikID;
            this.maticniBroj = maticniBroj;
            }

        public Uposlenik() { }

        }
    }
