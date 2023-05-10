using APILibrary.API;
using APILibrary.Model;
using BansosKu.Page.Data_Page;
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
            myUser =  _api.getUserById(AppSettings.Default.id);
            if(myUser.Id == null)
            {
                lblNama.Content = "-";
            }
            else
            {
                lblNama.Content = myUser.Fullname.ToUpper();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data data = new Data();
            this.Close();
            data.Show();
        }
    }
}
