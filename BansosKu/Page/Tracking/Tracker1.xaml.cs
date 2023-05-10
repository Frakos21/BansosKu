using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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
using static System.Net.Mime.MediaTypeNames;
using APILibrary.API;
using APILibrary.Model;
using System.Text.RegularExpressions;
using BansosKu.Page.Home;

namespace BansosKu.Page.Tracking
{
    /// <summary>
    /// Interaction logic for Tracker1.xaml
    /// </summary>
    public partial class Tracker1 : Window
    {
        private MyAPI _api = new MyAPI();

        public Tracker1()
        {
            AppSettings.Default.id = 1;
            InitializeComponent();
            List<TrxBansosModel> listItems = _api.GetAllBansosUser(AppSettings.Default.id);
            lvBansos.ItemsSource = listItems;

        }

        private void lvBansos_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            this.Close();
            home.Show();
        }
    }
    }
