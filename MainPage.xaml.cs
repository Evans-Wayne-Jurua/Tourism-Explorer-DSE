using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tourism_Explorer_Desktop_Application
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavigationViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
            NavigationViewItem item = sender as NavigationViewItem;

            // Tags
            string tag = null;

            if (item != null)
            {
                if (item.Tag != null)
                {
                    tag = item.Tag.ToString();
                }
            }


            switch (tag)
            {
                case "Dash":
                    TourismContent.Navigate(typeof(Dashboard));
                    break;

                case "mp":
                    TourismContent.Navigate(typeof(Destinations));
                    break;

                case "wld":
                    TourismContent.Navigate(typeof(Experiences));
                    break;

                case "bk":
                    TourismContent.Navigate(typeof(Bookings));
                    break;

                case "ct":
                    TourismContent.Navigate(typeof(ContactUs));
                    break;

                case "Settings":
                    TourismContent.Navigate(typeof(SettingsPage));
                    break;

                case "Logout":
                    
                    break;
            }
        }
    }


    }
