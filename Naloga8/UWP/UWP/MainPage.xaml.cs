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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    
    public sealed partial class MainPage : Page
    {
        ServiceReference1.GlobalWeatherSoapClient services2 = new ServiceReference1.GlobalWeatherSoapClient();
        ServiceReference2.WebServiceSoapClient services = new ServiceReference2.WebServiceSoapClient();
        string drzava = null;
        public MainPage()
        {
            this.InitializeComponent();
            setPodatki();


        }
        private void setPodatki()
        {
            List<string> str = new List<string>();
            str.Add("Slovenia");
            str.Add("France");
            str.Add("Belgium");
            str.Add("Spain");
            str.Add("Italy");

            listboxDrzave.ItemsSource = str;
        }
        public string getDrzava()
        {
            return drzava;
        }
        private void listboxDrzave_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                drzava = listboxDrzave.SelectedItem.ToString();

                this.Frame.Navigate(typeof(BlankPage1), drzava);
            
        }
    }
}
