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
using System.ServiceModel;
using Windows.ApplicationModel.AppService;
using Windows.System.RemoteSystems;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Xml;
using UWP.ServiceReference2;
using System.Xml.Serialization;
using NAudio.Wave;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    
    public sealed partial class BlankPage1 : Page
    {
        string let;
        WebServiceSoapClient services = new WebServiceSoapClient();
        Letalisce letalisce;
        public BlankPage1()
        {
            this.InitializeComponent();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var parameters = e.Parameter;

            /*WebServiceTransfer.TransferSoapClient tsc = new WebServiceTransfer.TransferSoapClient();
            var response = await tsc.HelloWorldAsync();
            textBlock.Text = response.Body.HelloWorldResult;*/



            //ServiceReference2.GetLeltalisceDrzavaResponse response = await services.GetLeltalisceDrzavaAsync(parameters.ToString());

            
            GetLeltalisceDrzavaResponse result = await services.GetLeltalisceDrzavaAsync(parameters.ToString());
            string[] tmp = result.Body.GetLeltalisceDrzavaResult.ToArray();
            listBoxLet.ItemsSource = tmp;


        }
        private async void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            let = listBoxLet.SelectedItem.ToString();

            GetLetalisceByCodeResponse result = await services.GetLetalisceByCodeAsync(let);
            string tmp = result.Body.GetLetalisceByCodeResult;

            XmlSerializer deserializer = new XmlSerializer(typeof(Letalisce));
            using (StringReader reader = new StringReader(result.Body.GetLetalisceByCodeResult))
            {
                letalisce = (Letalisce)deserializer.Deserialize(reader);
            }

            txtBoxOpis.Text = letalisce.Opis;
            txtBDrzava.Text = letalisce.Country;
            txtBMesto.Text = letalisce.City;
            txtBNadmorska.Text = letalisce.NadmorskaVisina.ToString() + "m";
            txtBdolzina.Text = letalisce.DolzinaLSteze.ToString() + "m";
            
        }

        private void bttNazaj_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void bttPlay_Click(object sender, RoutedEventArgs e)
        {
            MemoryStream ms = new MemoryStream(letalisce.Glas);
            //SoundPlayer sound = new SoundPlayer(ms);
            //sound.LoadAsync();
            //sound.Play();

        }
    }
}
