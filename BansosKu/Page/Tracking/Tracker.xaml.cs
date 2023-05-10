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

namespace BansosKu.Page.Tracking
{
    /// <summary>
    /// Interaction logic for Tracker.xaml
    /// </summary>
    public partial class Tracker : Window
    {
        public Tracker()
        {
            InitializeComponent();
        }
        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Tracker1 home = new Tracker1();
            this.Close();
            home.Show();
        }
        private void back_Click (object sender, RoutedEventArgs e)
        {
            Tracker1 home = new Tracker1();
            this.Close();
            home.Show();
        }
    }
}
