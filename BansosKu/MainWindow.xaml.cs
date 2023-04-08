using BansosKu.Model;
using BansosKu.Repository;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BansosKu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IMasyarakatRepository masyarakatRepository;

        public MainWindow(IMasyarakatRepository masyarakatRepository)
        {
            InitializeComponent();
<<<<<<< HEAD
            this.masyarakatRepository = masyarakatRepository;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

=======

            //BitmapImage image = new BitmapImage();

            // Set URI sumber gambar
            /*
            image.BeginInit();
            image.UriSource = new Uri("/resources/images/logo.png", UriKind.RelativeOrAbsolute);
            image.EndInit();

            myLogo.Source = image;
            */
>>>>>>> dede
        }
    }

}
