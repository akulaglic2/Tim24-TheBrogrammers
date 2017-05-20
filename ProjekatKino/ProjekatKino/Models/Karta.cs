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
        public int idKarte;
        public double cijenaKarte;
        public int idProjekcije;

        public int IdKarte
        {
            get
            {
                return idKarte;
            }

            set
            {
                idKarte = value;
            }
        }

        public double CijenaKarte
        {
            get
            {
                return cijenaKarte;
            }

            set
            {
                cijenaKarte = value;
            }
        }

        public int IdProjekcije
        {
            get
            {
                return idProjekcije;
            }

            set
            {
                idProjekcije = value;
            }
        }
    }
}
