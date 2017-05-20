using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class PosebnePonude
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int posebnaPonudaID { get; set; }
        public string naziv;
        public double cijena;
        public string velicina;
        public List<Proizvod> sadrzaj;

      public  PosebnePonude(int posebnaPonudaID,string naziv,double cijena,string velicina, List<Proizvod> sadrzaj)
        {
            this.posebnaPonudaID = posebnaPonudaID;
            this.naziv= naziv;
            this.cijena = cijena;
            this.velicina = velicina;
            this.sadrzaj = sadrzaj;


        }

        public PosebnePonude() { }

        
    }
}
