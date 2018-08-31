using ANVI6NavigationSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ANVI6NavigationSample.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomerView : Page
    {
        ObservableCollection<Customer> customersList { get; set; }

        public CustomerView()
        {
            this.InitializeComponent();

            Customer almir = new Customer
            {
                FirstName = "Almir",
                LastName = "Vuk",
                Company = "AV Development",

            };

            Customer emir = new Customer
            {
                FirstName = "Emir",
                LastName = "Cajic",
                Company = "Freelance",

            };

            customersList = new ObservableCollection<Customer>();

            customersList.Add(almir);
            customersList.Add(emir);
        }
    }

      
}
