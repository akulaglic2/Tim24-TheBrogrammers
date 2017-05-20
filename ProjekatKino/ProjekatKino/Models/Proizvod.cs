using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class Proizvod
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int proizvodID { get; set; }
        public string naziv;
        public double cijena;
        public string vrsta;

        

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

        public double Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            }
        }

        public string Vrsta
        {
            get
            {
                return vrsta;
            }

            set
            {
                vrsta = value;
            }
        }
    }
}
