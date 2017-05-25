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
    public class DodajProizvodViewModel : INotifyPropertyChanged
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
        private double cijena;
        private string vrsta;
        
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

        public double Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
                NotifyPropertyChanged("Cijena");
            }
        }

        public string Vrsta
        {
            get
            {
                return vrsta;
            }

            set
            {
                vrsta = value;
                NotifyPropertyChanged("Vrsta");
            }
        }

      
        #endregion

        public ICommand Dodaj { get; set; }
        public Proizvod proizvod { get; set; }



        public DodajProizvodViewModel()
        {
            Dodaj = new RelayCommand<object>(unosProizvoda);
        }

        private async void unosProizvoda(object obj)
        {
            using (var db = new KinoDbContext())
            {
                var unesiProizvod = new Proizvod(Naziv, Cijena,Vrsta);
                db.proizvodi.Add(unesiProizvod);
                db.SaveChanges();

                var message = new MessageDialog("Uspješno je unesen novi proizvod", "Unos proizvoda");
                await message.ShowAsync();

                Naziv = string.Empty;
                Cijena = 0;
                Vrsta = string.Empty;
                

            }
        }
    }
}
