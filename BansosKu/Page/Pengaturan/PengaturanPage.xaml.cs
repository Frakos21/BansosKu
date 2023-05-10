using APILibrary.API;
using APILibrary.Model;
using BansosKu.Page.Data_Page;
using BansosKu.Page.Home;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

namespace BansosKu.Page.Pengaturan
{
    /// <summary>
    /// Interaction logic for Pengaturan.xaml
    /// </summary>
    public partial class PengaturanPage : Window
    {
        private UserModel myUser;
        private MyAPI _api = new MyAPI();
        public PengaturanPage()
        {
            InitializeComponent();
            getDataUser();
        }

        private void getDataUser()
        {
            Contract.Requires(AppSettings.Default.id > 0, "ID user harus valid");

            try
            {
                myUser = _api.getUserById(AppSettings.Default.id);
                Contract.Assert(myUser != null, "Gagal mendapatkan data user");

                if (myUser.Id == null)
                {
                    lblNama.Content = "-";
                }
                else
                {
                    lblNama.Content = myUser.Fullname.ToUpper();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data data = new Data();
            this.Close();
            data.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            this.Close();
            home.Show();
        }
    }
}
