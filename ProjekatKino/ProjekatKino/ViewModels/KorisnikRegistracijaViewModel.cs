using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjekatKino.Helper;
using System.Linq;
using Windows.UI.Popups;
using System.Threading.Tasks;
using ProjekatKino.Models;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatKino.ViewModels
    {
    public class KorisnikRegistracijaViewModel : INotifyPropertyChanged
        {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged (String info)
            {
            if (PropertyChanged != null)
                {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }

        #region Privatni atributi, get set
        private string ime;
        private string prezime;
        private string email;
        private string adresa;
        private string username;
        private string password;
        private DateTime datumRodjenja;
        private Int64 brojKreditneKartice;
        private DateTime expDate;
        private string imeVlasnikaKartice;
        private string prezimeVlasnikaKartice;
        private string vrstaKreditneKartice;

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
                }

            set
                {
                prezime = value;
                NotifyPropertyChanged("Prezime");
                }
            }
        public string VrstaKreditneKartice
            {
            get
                {
                return vrstaKreditneKartice;
                }

            set
                {
                vrstaKreditneKartice = value;
                NotifyPropertyChanged("VrstaKreditneKartice");
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
                NotifyPropertyChanged("Email");
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
                NotifyPropertyChanged("Adresa");
                }
            }

        public string Username
            {
            get
                {
                return username;
                }

            set
                {
                username = value;
                NotifyPropertyChanged("Username");
                }
            }

        public string Password
            {
            get
                {
                return password;
                }

            set
                {
                password = value;
                NotifyPropertyChanged("Password");
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
                NotifyPropertyChanged("DatumRodjenja");
                }
            }

        public long BrojKreditneKartice
            {
            get
                {
                return brojKreditneKartice;
                }

            set
                {
                brojKreditneKartice = value;
                NotifyPropertyChanged("BrojKreditneKartice");
                }
            }

        public DateTime ExpDate
            {
            get
                {
                return expDate;
                }

            set
                {
                expDate = value;
                NotifyPropertyChanged("ExpDate");
                }
            }

        public string ImeVlasnikaKartice
            {
            get
                {
                return imeVlasnikaKartice;
                }

            set
                {
                imeVlasnikaKartice = value;
                NotifyPropertyChanged("ImeVlasnikaKartice");
                }
            }

        public string PrezimeVlasnikaKartice
            {
            get
                {
                return prezimeVlasnikaKartice;
                }

            set
                {
                prezimeVlasnikaKartice = value;
                NotifyPropertyChanged("PrezimeVlasnikaKartice");
                }
            }
        #endregion

        public ICommand Dodaj { get; set; }
        public Korisnik Korisnik { get; set; }



        public KorisnikRegistracijaViewModel ()
            {
            Dodaj = new RelayCommand<object>(unosKorisnika);
            }

        private async void unosKorisnika (object obj)
            {
            using (var db = new KinoDbContext())
                {
                // validacija unosa 
                if (Ime == "" || Prezime == "" || Adresa == "" || Email == "" || Username == "" || Password == "" || DatumRodjenja == null || BrojKreditneKartice == null || ExpDate == null || ImeVlasnikaKartice == "" || PrezimeVlasnikaKartice == "")
                    {
                    var messageDialog = new MessageDialog("Morate popuniti sva polja!");
                    await messageDialog.ShowAsync();
                    }
                if (Username.Length < 7 || Username.Length > 22)
                    {
                    var messageDialog = new MessageDialog("Username mora imati najmanje 7, a najvise 22 karaktera");
                    await messageDialog.ShowAsync();
                    }
                if (Password.Length < 8 || Password.Length > 22)
                    {
                    var messageDialog = new MessageDialog("Password mora imati najmanje 8, a najvise 22 karaktera");
                    await messageDialog.ShowAsync();
                    }
                if (DateTime.Compare(ExpDate, DateTime.Today) <= 0)
                    {
                    var messageDialog = new MessageDialog("Datum isteka kartice nije validan!");
                    await messageDialog.ShowAsync();
                    }

                var uneseniKorisnik = new Korisnik(Ime, Prezime, Adresa, Email, Username, Password, Convert.ToDateTime(DatumRodjenja), BrojKreditneKartice, Convert.ToDateTime(ExpDate), ImeVlasnikaKartice, PrezimeVlasnikaKartice, VrstaKreditneKartice);
                db.korisnici.Add(uneseniKorisnik);
                db.SaveChanges();

                var message = new MessageDialog("Uspješno je unesen novi radnik", "Unos radnika");
                await message.ShowAsync();

                Ime = string.Empty;
                Prezime = string.Empty;
                Username = string.Empty;
                Password = string.Empty;
                Adresa = string.Empty;
                Email = string.Empty;
                BrojKreditneKartice = 0;
                ImeVlasnikaKartice = string.Empty;
                PrezimeVlasnikaKartice = string.Empty;
                }
            }













        }
    }
