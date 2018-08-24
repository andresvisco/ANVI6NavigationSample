using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ANVI6NavigationSample
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

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {

            



                if (args.IsSettingsInvoked)
                {
                    ContentFrame.Navigate(typeof(UISettings));
                }
                else
                {
                    var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
                    NavView_Navigate(item as NavigationViewItem);
                }
            }
            private void NavView_Navigate(NavigationViewItem item)
            {

                switch (item.Tag)
                {
                    case "apps":

                        ContentFrame.Navigate(typeof(View1));
                        break;
                    


                }
            }

            private void NavView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {

        }
    }
}
