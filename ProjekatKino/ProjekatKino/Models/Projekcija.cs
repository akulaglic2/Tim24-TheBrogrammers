using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
   public class Projekcija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProjekcija { get; set; }
        public DateTime vrijemePrikazivanja { get; set; }
        public int idKinoDvorane { get; set; }
        public int idFilma { get; set; }

        public Projekcija(int idProjekcija,DateTime vrijemePrikazivanja,int idKinoDvorane,int idFilma){
            this.idProjekcija = idProjekcija;
            this.vrijemePrikazivanja = vrijemePrikazivanja;
            this.idKinoDvorane = idKinoDvorane;
            this.idFilma = idFilma;
            
                }
        
    }
}
