using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public abstract class Osoba
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //idOsobe
        private string ime;
        private string prezime;
        private string adresa;
        private string email;
        private string username;
        private string password;
        private DateTime datumRodjenja;

        public Osoba ()
            { }

        public Osoba (string ime, string prezime, string adresa, string email, string username, string password, DateTime datumRodjenja)
            {
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.email = email;
            this.username = username;
            this.password = password;
            this.datumRodjenja = datumRodjenja;
            }

        public string Ime
            {
            get
                {
                return ime;
                }

            set
                {
                ime = value;
                }
            }

        public string Prezime
            {
            get
                {
                return prezime;
                }

            set
                {
                prezime = value;
                }
            }

        public string Adresa
            {
            get
                {
                return adresa;
                }

            set
                {
                adresa = value;
                }
            }

        public string Email
            {
            get
                {
                return email;
                }

            set
                {
                email = value;
                }
            }

        public string Username
            {
            get
                {
                return username;
                }

            set
                {
                username = value;
                }
            }

        public string Password
            {
            get
                {
                return password;
                }

            set
                {
                password = value;
                }
            }

        public DateTime DatumRodjenja
            {
            get
                {
                return datumRodjenja;
                }

            set
                {
                datumRodjenja = value;
                }
            }
        }
    }
