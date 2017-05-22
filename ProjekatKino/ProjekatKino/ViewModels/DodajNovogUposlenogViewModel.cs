using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.ViewModels
    {
    public class DodajNovogUposlenogViewModel : INotifyPropertyChanged
        {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged (String info)
            {
            if (PropertyChanged != null)
                {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }

        #region Privatni atributi
        private string Ime;
        private string Prezime;
        private string Adresa;
        private string Username;
        private string Password;
        private DateTime DatumRodjenja;
        private string MaticniBroj;
        private string Email;
        #endregion
        }


    }
