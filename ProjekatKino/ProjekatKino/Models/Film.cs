using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public class Film
        {
        private int idFilma;
        private string naziv;
        private string zanr;
        private int duzinaTrajanja; //u minutama
        private string reziser;
        private string opisFilma;
        //private List<String> glavneUloge;

        public Film (int idFilma, string naziv, string zanr, int duzinaTrajanja, string reziser, string opisFilma)
            {
            this.idFilma = idFilma;
            this.naziv = naziv;
            this.zanr = zanr;
            this.duzinaTrajanja = duzinaTrajanja;
            this.reziser = reziser;
            this.opisFilma = opisFilma;
            }

        public int IdFilma
            {
            get
                {
                return idFilma;
                }

            set
                {
                idFilma = value;
                }
            }

        public string Naziv
            {
            get
                {
                return naziv;
                }

            set
                {
                naziv = value;
                }
            }

        public string Zanr
            {
            get
                {
                return zanr;
                }

            set
                {
                zanr = value;
                }
            }

        public int DuzinaTrajanja
            {
            get
                {
                return duzinaTrajanja;
                }

            set
                {
                duzinaTrajanja = value;
                }
            }

        public string Reziser
            {
            get
                {
                return reziser;
                }

            set
                {
                reziser = value;
                }
            }

        public string OpisFilma
            {
            get
                {
                return opisFilma;
                }

            set
                {
                opisFilma = value;
                }
            }

        }

    }
