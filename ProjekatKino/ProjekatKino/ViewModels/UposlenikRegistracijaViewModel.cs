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




        }
    }
