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
    public partial class PengaturanPage : Window
    {
        private enum PageState
        {
            Home,
            Data,
            Sandi,
            Nama,
            Bantuan,
            Kontak
        }

        private PageState currentState;
        private UserModel myUser;
        private MyAPI _api = new MyAPI();

        public PengaturanPage()
        {
            InitializeComponent();
            InitializePage();
        }

        private void InitializePage()
        {
            currentState = PageState.Home;
            getDataUser();
        }

        private void getDataUser()
        {
            Contract.Requires(AppSettings.Default.id > 0, "ID user harus valid");

            try
            {
                myUser = _api.getUserById(AppSettings.Default.id);
                Contract.Assert(myUser != null, "Gagal mendapatkan data user");
                Contract.Ensures(myUser.Id != null || lblNama.Content.Equals("-"), "Nama harus ditampilkan");

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

        private void UpdatePageState(PageState state)
        {
            currentState = state;
            // Atur tampilan UI sesuai dengan currentState
            switch (currentState)
            {
                case PageState.Home:
                    HomePage homePage = new HomePage();
                    this.Close();
                    homePage.Show();
                    break;
                case PageState.Data:
                    // Atur tampilan untuk halaman Data
                    Data datapage = new Data();
                    this.Close();
                    datapage.Show();
                    break;
                case PageState.Sandi:
                    // Atur tampilan untuk halaman Sandi
                    break;
                case PageState.Nama:
                    // Atur tampilan untuk halaman Nama
                    break;
                case PageState.Bantuan:
                    // Atur tampilan untuk halaman Bantuan
                    break;
                case PageState.Kontak:
                    // Atur tampilan untuk halaman Kontak
                    break;
                default:
                    break;
            }
        }

        private void Button_Click_Data(object sender, RoutedEventArgs e)
        {
            UpdatePageState(PageState.Data);
        }

        private void Button_Click_Home(object sender, RoutedEventArgs e)
        {
            UpdatePageState(PageState.Home);
        }

        private void Button_Click_Sandi(object sender, RoutedEventArgs e)
        {
            UpdatePageState(PageState.Sandi);
            MessageBox.Show("Coming Soon");
        }

        private void Button_Click_Nama(object sender, RoutedEventArgs e)
        {
            UpdatePageState(PageState.Nama);
            MessageBox.Show("Coming Soon");
        }

        private void Button_Click_Bantuan(object sender, RoutedEventArgs e)
        {
            UpdatePageState(PageState.Bantuan);
            MessageBox.Show("Coming Soon");
        }

        private void Button_Click_Kontak(object sender, RoutedEventArgs e)
        {
            UpdatePageState(PageState.Kontak);
            MessageBox.Show("Coming Soon");
        }
    }
}
