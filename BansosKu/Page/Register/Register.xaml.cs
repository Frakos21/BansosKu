using APILibrary.API;
using Newtonsoft.Json;
using RestSharp;
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

namespace BansosKu.Page.Register
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {

        MainWindow main = new MainWindow();
        MyAPI _api = new MyAPI();
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            main.Show();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (!TBPassword.Text.Equals(TBComfirm.Text))
            {
                MessageBox.Show("Password tidak sama dengan Confirm Password, silahkan di periksa");
            }
            else
            {
                var res = _api.RegisterUser(TBNIK.Text,TBNama.Text,TBPassword.Text);
                if (res == -2)
                {
                    MessageBox.Show("Registrasi Gagal, NIK Sudah Terdaftar");
                }
                else if (res == -1)
                {
                    MessageBox.Show("Registrasi Gagal");
                }
                else
                {
                    MessageBox.Show("Registrasi Berhasil");
                    this.Close();
                    main.Show();
                }
            }
          
        }

       
    }
}
