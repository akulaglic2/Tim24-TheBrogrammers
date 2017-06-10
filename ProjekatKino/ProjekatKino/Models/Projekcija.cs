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


        public int id { get; set; }
        public DateTime vrijemePrikazivanja;
        public int idKinoDvorane;
        public int idFilma;


        public Projekcija (int projekcijaID, DateTime vrijemePrikazivanja, int idKinoDvorane, int idFilma)
            {

            this.vrijemePrikazivanja = vrijemePrikazivanja;
            this.idKinoDvorane = idKinoDvorane;

            }

        public Projekcija () { }
        }
    }
