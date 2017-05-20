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
        public string naziv { get; set; }
        public double cijena { get; set; }
        public string vrsta { get; set; }

        public Proizvod(int proizvodID, string naziv, double cijena, string vrsta) {
            this.proizvodID = proizvodID;
            this.naziv = naziv;
            this.cijena = cijena;
            this.vrsta = vrsta;

        }


        
    }
}
