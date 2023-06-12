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
using APILibrary.API;
using APILibrary.Model;
using BansosKu.Page.Home;
using BansosKu.Page.Tracking;

namespace BansosKu.Page.BansosPage
{
    /// <summary>
    /// Interaction logic for Bansos1.xaml
    /// </summary>
    public partial class Bansos1 : Window
    {
      
        private MyAPI _api = new MyAPI();
        public Bansos1()
        {
            InitializeComponent();
            List<BansosModel> listItems = _api.GetAllBansos<BansosModel>();     
            GroupBy.ItemsSource = listItems;
        }
     
        private void GroupBy_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            HomePage home = new HomePage();
            this.Close();
            home.Show();
        }

        private void Path_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Tracker track = new Tracker();
            this.Close();
            track.Show();
        }
    }
}
