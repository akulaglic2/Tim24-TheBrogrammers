using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
    public class PosebnePonude
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPosebnePonude;
        public string naziv;
        public double cijena;
        public string velicina;
        public List<Proizvod> sadrzaj;

        public int IdPosebnePonude
        {
            get
            {
                return idPosebnePonude;
            }

            set
            {
                idPosebnePonude = value;
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public double Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            }
        }

        public string Velicina
        {
            get
            {
                return velicina;
            }

            set
            {
                velicina = value;
            }
        }

        public List<Proizvod> Sadrzaj
        {
            get
            {
                return sadrzaj;
            }

            set
            {
                sadrzaj = value;
            }
        }
    }
}
