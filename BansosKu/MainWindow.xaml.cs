using BansosKu.Model;
using BansosKu.Page.Home;
using BansosKu.Page.Register;
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
     
        public MainWindow()
        {
            InitializeComponent();
            Masyarakat m = new Masyarakat();
            m.Id = 1;
            m.Fullname = "Tangguh";
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            this.Close();
            register.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            this.Close();
            home.Show();
        }
    }

}
