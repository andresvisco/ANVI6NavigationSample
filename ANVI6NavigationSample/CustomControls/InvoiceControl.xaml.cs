using System;
using System.Collections.Generic;
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

namespace ANVI6NavigationSample.CustomControls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InvoiceControl : UserControl
    {
        public InvoiceControl()
        {
            this.InitializeComponent();
        }

        public string IdInvoice
        {
            get { return (string)GetValue(IdInvoiceProperty); }
            set { SetValue(IdInvoiceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IdInvoice.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IdInvoiceProperty =
            DependencyProperty.Register("IdInvoice", typeof(string), typeof(InvoiceControl), null);


        public string Descripcion
        {
            get { return (string)GetValue(DescripcionProperty); }
            set { SetValue(DescripcionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Descripcion.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescripcionProperty =
            DependencyProperty.Register("Descripcion", typeof(string), typeof(InvoiceControl), null);
    }
}
