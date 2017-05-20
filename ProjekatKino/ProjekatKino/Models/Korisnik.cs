using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public class Korisnik : Osoba
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idKorisnika { get; set; }// primary key
        public int brojKreditneKartice { get; set; }
        public DateTime expDate { get; set; }
        public string imeVlasnikaKartice { get; set; }
        public string prezimeVlasnikaKartice { get; set; }

        public Korisnik (string ime, string prezime, string adresa, string email, string username, string password, DateTime datumRodjenja, int idKorisnika, int brojKreditneKartice, DateTime expDate, string imeVlasnikaKartice, string prezimeVlasnikaKartice)
                : base(ime, prezime, adresa, email, username, password, datumRodjenja)
            {
            this.idKorisnika = idKorisnika;
            this.brojKreditneKartice = brojKreditneKartice;
            this.expDate = expDate;
            this.imeVlasnikaKartice = imeVlasnikaKartice;
            this.prezimeVlasnikaKartice = prezimeVlasnikaKartice;
            }

       
        }
    }
