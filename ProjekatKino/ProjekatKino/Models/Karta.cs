using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class Karta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int kartaID { get; set; }
        public double cijenaKarte { get; set; }
        public int idProjekcije { get; set; }

       
    }
}
