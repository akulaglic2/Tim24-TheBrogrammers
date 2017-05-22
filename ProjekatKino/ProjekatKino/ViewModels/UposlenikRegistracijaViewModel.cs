using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.ViewModels
    {
    public class UposlenikRegistracijaViewModel : INotifyPropertyChanged
        {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged (String info)
            {
            if (PropertyChanged != null)
                {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }

        #region Privatni Atributi
        private string ime;
        private string prezime;
        private string email;
        private string adresa;
        private int idUposlenika;
        private int maticniBroj;
        private DateTime datumRodjenja;
        #endregion

        public string Ime
            {
            get
                {
                return ime;
                }

            set
                {
                ime = value;
                NotifyPropertyChanged("Ime");
                }
            }

        public string Prezime
            {
            get
                {
                return prezime;
                NotifyPropertyChanged("Prezime");
                }

            set
                {
                prezime = value;
                }
            }

        public string Email
            {
            get
                {
                return email;
                }

            set
                {
                email = value;
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

        public int IdUposlenika
            {
            get
                {
                return idUposlenika;
                }

            set
                {
                idUposlenika = value;
                }
            }

        public int MaticniBroj
            {
            get
                {
                return maticniBroj;
                }

            set
                {
                maticniBroj = value;
                }
            }

        public DateTime DatumRodjenja
            {
            get
                {
                return datumRodjenja;
                }

            set
                {
                datumRodjenja = value;
                }
            }
       




        }
    }
