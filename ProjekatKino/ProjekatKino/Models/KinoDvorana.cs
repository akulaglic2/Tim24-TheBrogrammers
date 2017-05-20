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


        public string Adresa
            {
            get
                {
                return adresa;
                }

            set
                {
                adresa = value;
                }
            }

        public int BrojMjesta
            {
            get
                {
                return brojMjesta;
                }

            set
                {
                brojMjesta = value;
                }
            }
        }
    }
