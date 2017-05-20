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
        public int projekcijaID { get; set; }
        public DateTime vrijemePrikazivanja;
        public int idKinoDvorane;
        public int idFilma;

        public Projekcija (int projekcijaID, DateTime vrijemePrikazivanja, int idKinoDvorane, int idFilma)
            {
            this.projekcijaID = projekcijaID;
            this.vrijemePrikazivanja = vrijemePrikazivanja;
            this.idKinoDvorane = idKinoDvorane;
            this.IdFilma = idFilma;

            }


        public DateTime VrijemePrikazivanja
            {
            get
                {
                return vrijemePrikazivanja;
                }

            set
                {
                vrijemePrikazivanja = value;
                }
            }

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

        public int IdFilma
            {
            get
                {
                return idFilma;
                }

            set
                {
                idFilma = value;
                }
            }
        }
    }
