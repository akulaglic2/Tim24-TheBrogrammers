using ProjekatKino.Helper;
using ProjekatKino.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace ProjekatKino.ViewModels
{
   public class DodajFilmViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #region Privatni Atributi
        private string naziv;
        private string zanr;
        private string reziser;
        private int duzinaTrajanja;
        private string opisFilma;
        #endregion

        #region Get,Set

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
                NotifyPropertyChanged("Naziv");
            }
        }

        public string Zanr
        {
            get
            {
                return zanr;
            }

            set
            {
                zanr = value;
                NotifyPropertyChanged("Zanr");
            }
        }

        public string Reziser
        {
            get
            {
                return reziser;
            }

            set
            {
                reziser = value;
                NotifyPropertyChanged("Reziser");
            }
        }

        public int DuzinaTrajanja
        {
            get
            {
                return duzinaTrajanja;
            }

            set
            {
                duzinaTrajanja = value;
                NotifyPropertyChanged("DuzinaTrajanja");
            }
        }

        public string OpisFilma
        {
            get
            {
                return opisFilma;
            }

            set
            {
                opisFilma = value;
                NotifyPropertyChanged("OpisFilma");
            }
        }
        #endregion

        public ICommand Dodaj { get; set; }
        public Film film { get; set; }

        

        public DodajFilmViewModel()
        {
            Dodaj = new RelayCommand<object>(unosFilma);
        }

        private async void unosFilma(object obj)
        {
            using (var db = new KinoDbContext())
            {
                var unesiFilm = new Film(Naziv, Zanr, DuzinaTrajanja, Reziser, OpisFilma);
                db.filmovi.Add(unesiFilm);
                db.SaveChanges();

                var message = new MessageDialog("Uspješno je unesen novi film", "Unos filma");
                await message.ShowAsync();

                Naziv = string.Empty;
                Zanr = string.Empty;
                DuzinaTrajanja = 0;
                Reziser = string.Empty;
               OpisFilma = string.Empty;
               
            }
        }
    }
}
