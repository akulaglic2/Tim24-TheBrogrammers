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
        public int idKinoDvorane { get; set; }
       public  string adresa { get; set; }
        public int brojMjesta { get; set; }

        public KinoDvorana(int idKinoDvorane,string adresa, int brojMjesta)
        {
            this.idKinoDvorane = idKinoDvorane;
            this.adresa = adresa;
            this.brojMjesta = brojMjesta;
        }

       
    }
}
