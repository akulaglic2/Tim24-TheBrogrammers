using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;using ProjekatKino;
using ProjekatKino.Models;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App3
    {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
        {
        public BlankPage1 ()
            {
            this.InitializeComponent();
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += ThisPage_BackRequested;
            }
        private void ThisPage_BackRequested (object sender, BackRequestedEventArgs e)
            {
            if (Frame.CanGoBack)
                {
                Frame.Navigate(typeof(UposlenikPocetna));
                e.Handled = true;
                }
            }

        ////krsenje MVVM paterna zbog testa Azure baze podataka, metoda je dodana  zbog projektnog zadatka vezanog za Azure 

        //IMobileServiceTable<tabela> userTableObj = App.MobileService.GetTable<tabela>();
        //private void btnSpasi_Tapped (object sender, TappedRoutedEventArgs e)
        //    {
        //    try
        //        {
        //        Korisnik obj = new Korisnik();
        //        obj.ime = txtIme.Text;
        //        obj.prezime =
        //        obj.indeks = txtIndeks.Text;
        //        userTableObj.InsertAsync(obj);
        //        MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog studenta.");

        //        msgDialog.ShowAsync();
        //        }
        //    catch (Exception ex)
        //        {
        //        MessageDialog msgDialogError = new MessageDialog("Error : " +
        //       ex.ToString());
        //        msgDialogError.ShowAsync();
        //        }

        //    }
        }
    }
