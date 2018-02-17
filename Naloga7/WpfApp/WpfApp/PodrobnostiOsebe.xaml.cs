using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for PodrobnostiOsebe.xaml
    /// </summary>
    public partial class PodrobnostiOsebe : Window
    {
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        public PodrobnostiOsebe()
        {
            InitializeComponent();
        }

        private void bttPrikazi_Click(object sender, RoutedEventArgs e)
        {
            localhost.Oseba o2 = services.getOsebaIme(txtBimeOsebe.Text);

            label.Content = o2.ime + " " + o2.priimek + " " + o2.letoRojstva;

        }
    }
}
