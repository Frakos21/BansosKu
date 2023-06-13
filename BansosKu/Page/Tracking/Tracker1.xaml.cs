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
using APILibrary.API;
using APILibrary.Model;
using System.Text.RegularExpressions;
using BansosKu.Page.Home;

namespace BansosKu.Page.Tracking
{
    public partial class Tracker1 : Window
    {
        private MyAPI _api = new MyAPI();

        //Menampilkan daftar item TrxBansosModel pada lvBansos
        public Tracker1()
        {
            AppSettings.Default.id = 1;
            InitializeComponent();
            List<TrxBansosModel> listItems = _api.GetAllBansosUser<TrxBansosModel>(AppSettings.Default.id);
            lvBansos.ItemsSource = listItems;
        }
        
        //prosedur ntuk scroll pada Listview dengan nama lvBansos
        private void lvBansos_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        //prosedur untuk kembali ke page home dan menutup page saat ini
        private void back_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            this.Close();
            home.Show();
        }

        // Method untuk validasi input
        private bool ValidateInput(string input)
        {
            string pattern = @"^[a-zA-Z0-9]+$";
            return Regex.IsMatch(input, pattern);
        }

        // Method untuk menghindari serangan SQL injection
        private string SanitizeInput(string input)
        {
            return input.Replace("'", "''");
        }

        // Method untuk menghindari serangan cross-site scripting (XSS)
        private string EscapeOutput(string output)
        {
            return System.Net.WebUtility.HtmlEncode(output);
        }
    }
}
