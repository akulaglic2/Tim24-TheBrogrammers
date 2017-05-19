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
        private int idKorisnika; // primary key
        private int brojKreditneKartice;
        private DateTime expDate;
        private string imeVlasnikaKartice;
        private string prezimeVlasnikaKartice;

        public Korisnik (string ime, string prezime, string adresa, string email, string username, string password, DateTime datumRodjenja, int idKorisnika, int brojKreditneKartice, DateTime expDate, string imeVlasnikaKartice, string prezimeVlasnikaKartice)
                : base(ime, prezime, adresa, email, username, password, datumRodjenja)
            {
            this.idKorisnika = idKorisnika;
            this.brojKreditneKartice = brojKreditneKartice;
            this.expDate = expDate;
            this.imeVlasnikaKartice = imeVlasnikaKartice;
            this.prezimeVlasnikaKartice = prezimeVlasnikaKartice;
            }

        public int IdKorisnika
            {
            get
                {
                return idKorisnika;
                }

            set
                {
                idKorisnika = value;
                }
            }

        public int BrojKreditneKartice
            {
            get
                {
                return brojKreditneKartice;
                }

            set
                {
                brojKreditneKartice = value;
                }
            }

        public DateTime ExpDate
            {
            get
                {
                return expDate;
                }

            set
                {
                expDate = value;
                }
            }

        public string ImeVlasnikaKartice
            {
            get
                {
                return imeVlasnikaKartice;
                }

            set
                {
                imeVlasnikaKartice = value;
                }
            }

        public string PrezimeVlasnikaKartice
            {
            get
                {
                return prezimeVlasnikaKartice;
                }

            set
                {
                prezimeVlasnikaKartice = value;
                }
            }
        }
    }
