using Microsoft.WindowsAzure.MobileServices;
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
    public class DodajPosebniProizvodViewModel : INotifyPropertyChanged
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
        private string naziv;
        private double cijena;
        private string velicina;
        private string sadrzaj1;
        private string sadrzaj2;
        private string kratakOpis;


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

        public string Velicina
            {
            get
                {
                return velicina;
                }

            set
                {
                velicina = value;
                NotifyPropertyChanged("Velicina");
                }
            }
        public string Sadrzaj1
            {
            get
                {
                return sadrzaj1;
                }

            set
                {
                sadrzaj1 = value;
                NotifyPropertyChanged("Sadrzaj1");
                }
            }

        public string Sadrzaj2
            {
            get
                {
                return sadrzaj2;
                }

            set
                {
                sadrzaj2 = value;
                NotifyPropertyChanged("Sadrzaj2");
                }
            }

        public string KratakOpis
            {
            get
                {
                return kratakOpis;
                }

            set
                {
                kratakOpis = value;
                NotifyPropertyChanged("KratakOpis");
                }
            }


        #endregion

        public ICommand Dodaj { get; set; }
        public PosebnePonude posebne { get; set; }



        public DodajPosebniProizvodViewModel ()
            {
            Dodaj = new RelayCommand<object>(unosProizvoda);
            }

        IMobileServiceTable<PosebnePonude> userTableObj = App.MobileService.GetTable<PosebnePonude>();

        private async void unosProizvoda (object obj)
            {
            using (var db = new KinoDbContext())
                {
                // validacija unosa 
                if (Naziv == "" || Cijena == 0 || Velicina == "" || Sadrzaj1 == "" || Sadrzaj2 == "" || KratakOpis == "")
                    {
                    var messageDialog = new MessageDialog("Morate popuniti sva polja!");
                    await messageDialog.ShowAsync();
                    }
                if (KratakOpis.Length < 10)
                    {
                    var messageDialog = new MessageDialog("Prekratak opis!");
                    await messageDialog.ShowAsync();
                    }

                try
                    {

                    PosebnePonude kor = new PosebnePonude();
                    kor.naziv = Naziv;
                    kor.cijena = Cijena;
                    kor.velicina = Velicina;
                    kor.sadrzaj1 = Sadrzaj1;
                    kor.sadrzaj2 = Sadrzaj2;
                    kor.kratakOpis = KratakOpis;
                    userTableObj.InsertAsync(kor);

                    MessageDialog msgDialog = new MessageDialog("Uspješno ste dodali film.");
                    msgDialog.ShowAsync();
                    }

                catch (Exception ex)
                    {
                    MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                    msgDialogError.ShowAsync();
                    }

                var unesiProizvod = new PosebnePonude(Naziv, Cijena, Velicina, Sadrzaj1, Sadrzaj2, KratakOpis);
                //db.posebnePonude.Add(unesiProizvod);
                //db.SaveChanges();

                //var message = new MessageDialog("Uspješno je unesena nova posebna ponuda", "Unos posebne ponude");
                //await message.ShowAsync();

                Naziv = string.Empty;
                Cijena = 0;
                Velicina = string.Empty;
                Sadrzaj1 = string.Empty;
                Sadrzaj2 = string.Empty;
                KratakOpis = string.Empty;


                }
            }
        }
    }
