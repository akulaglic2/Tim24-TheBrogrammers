using ProjekatKino.Helper;
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
    public class FindMyMovieViewModel :  INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
       
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        private string nazivFilma;
        private string vrijemePrikazivanja;
        private int brojKarti;

        public string NazivFilma
        {
            get
            {
                return nazivFilma;
            }

            set
            {
                nazivFilma = value;
                NotifyPropertyChanged("NazivFilma");
            }
        }

        public string VrijemePrikazivanja
        {
            get
            {
                return vrijemePrikazivanja;
            }

            set
            {
                vrijemePrikazivanja = value;
                NotifyPropertyChanged("VrijemePrikazivanja");
            }
        }

        public int BrojKarti
        {
            get
            {
                return brojKarti;
            }

            set
            {
                brojKarti = value;
                      NotifyPropertyChanged("BrojKarti");
            }
        }
        public ICommand FindKupiKartu { get; set; }


        public FindMyMovieViewModel()
        {
            FindKupiKartu = new RelayCommand<object>(kupiFindKartu);
            BrojKarti=0;
        }
        private async void kupiFindKartu(object obj)
        {
           
            if (Convert.ToString(BrojKarti) == null)
            {
                var messageDialog = new MessageDialog("Nije unesen broj karata!", "Greška pri kupovini karte");
                await messageDialog.ShowAsync();
            }



            else
            {
                var message = new MessageDialog("Uspješno ste kupili kartu!", "Kupovina karte uspješna");
                NazivFilma = string.Empty;
                VrijemePrikazivanja = string.Empty;
                BrojKarti = 0;
                

            }
        }
    }
}
