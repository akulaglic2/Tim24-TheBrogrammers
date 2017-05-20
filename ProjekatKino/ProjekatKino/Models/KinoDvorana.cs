using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public class KinoDvorana
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int kinoDvoranaID { get; set; }
        public string adresa;
        public int brojMjesta;

        public KinoDvorana(int kinoDvoranaID, string adresa, int brojMjesta)
        {
            this.kinoDvoranaID = kinoDvoranaID;
            this.adresa = adresa;
            this.brojMjesta = brojMjesta;
        }


    }

    }
