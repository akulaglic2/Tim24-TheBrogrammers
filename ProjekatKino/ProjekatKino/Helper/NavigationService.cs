﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjekatKino.Helper
    {
    public class NavigationService : INavigacija
        {
        //obicna navigacija bez parametra
        public void Navigate (Type sourcePage)
            {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage);
            }
        //navigacija na page ali da se proslijedi parametar stranici
        public void Navigate (Type sourcePage, object parameter)
            {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage, parameter);
            }
        //poziv da se vrati na predhodnu stranicu
        public void GoBack ()
            {
            var frame = (Frame)Window.Current.Content;
            frame.GoBack();
            }
        }
    }
