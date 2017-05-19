using System;
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
        private int idUposlenika; // primary key
        private int maticniBroj;

        public Uposlenik (string ime, string prezime, string adresa, string email, string username, string password, DateTime datumRodjenja, int idUposlenika, int maticniBroj)
                : base(ime, prezime, adresa, email, username, password, datumRodjenja)
            {
            this.idUposlenika = idUposlenika;
            this.MaticniBroj = maticniBroj;
            }

        public int IdUposlenika
            {
            get
                {
                return idUposlenika;
                }

            set
                {
                idUposlenika = value;
                }
            }

        public int MaticniBroj
            {
            get
                {
                return maticniBroj;
                }

            set
                {
                maticniBroj = value;
                }
            }
        }
    }
