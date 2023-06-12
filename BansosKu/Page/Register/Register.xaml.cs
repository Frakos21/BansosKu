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
using System.Diagnostics.Contracts;
using System.Diagnostics;

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
            string nik = TBNIK.Text.Trim();
            string nama = TBNama.Text.Trim();
            string password = TBPassword.Password.Trim();
            string confirmPassword = TBComfirm.Password.Trim();

            Contract.Requires(!string.IsNullOrEmpty(nik));
            Contract.Requires(!string.IsNullOrEmpty(nama));
            Contract.Requires(!string.IsNullOrEmpty(password));
            Contract.Requires(!string.IsNullOrEmpty(confirmPassword));

            if (password != confirmPassword)
            {
                MessageBox.Show("Password tidak sama dengan Confirm Password, silahkan diperiksa");
            }
            else if (string.IsNullOrEmpty(nik) || string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Semua harus diisi, silahkan diperiksa");
            }
            else
            {
                var res = _api.RegisterUser(nik, nama, password);
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



        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && (textBox.Text == "Masukan NIK" || textBox.Text == "Masukan Nama" || textBox.Text == "Masukan Password" || textBox.Text == "Masukan Ulang Password"))
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "TBNIK")
                {
                    textBox.Text = "Masukan NIK";
                }
                else if (textBox.Name == "TBNama")
                {
                    textBox.Text = "Masukan Nama";
                }else if (textBox.Name == "TBPassword")
                {
                    textBox.Text = "Masukan Password";
                }else if (textBox.Name == "TBComfirm")
                {
                    textBox.Text = "Masukan Password Ulang";
                }
                textBox.Foreground = Brushes.LightGray;
            }
        }
    }
}
