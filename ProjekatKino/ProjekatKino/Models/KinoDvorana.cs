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
        public int idKinoDvorane;
       public  string adresa;
        public int brojMjesta;

        public int IdKinoDvorane
        {
            get
            {
                return idKinoDvorane;
            }

            set
            {
                idKinoDvorane = value;
            }
        }

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
