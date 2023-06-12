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
    //page register akun
    public partial class Register : Window
    {

        MainWindow main = new MainWindow();
        MyAPI _api = new MyAPI();
        public Register()
        {
            InitializeComponent();
        }
        
        //method action untuk pindah ke login page
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            main.Show();
        }

        //method untuk register akun
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string nik = TBNIK.Text.Trim();
            string nama = TBNama.Text.Trim();
            string password = TBPassword.Password.Trim();
            string confirmPassword = TBComfirm.Password.Trim();

            if (string.IsNullOrEmpty(nik) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Semua harus diisi, silahkan diperiksa");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Password tidak sama dengan Confirm Password, silahkan diperiksa");
            }
            else if (!IsNIKValid(nik))
            {
                MessageBox.Show("NIK tidak valid, silahkan diperiksa");
            }
            else if (!IsPasswordStrong(password))
            {
                MessageBox.Show("Password harus memiliki minimal 8 karakter dan mengandung huruf besar, huruf kecil, dan angka");
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

        //method pengecekan NIK
        private bool IsNIKValid(string nik)
        {
            // Implementasikan validasi NIK sesuai kebutuhan Anda
            // Misalnya, cek panjang dan format NIK
            // Menggunakan regular expression atau aturan yang berlaku
            // NIK harus terdiri dari 16 angka
            return nik.Length == 16;
        }

        //method pengecekan password
        private bool IsPasswordStrong(string password)
        {
            // Implementasikan validasi amannya password
            // password harus memiliki minimal 8 karakter,
            // termasuk setidaknya satu huruf besar, satu huruf kecil, dan satu angka
            return password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        //method untuk menghilangkan text di textfield ketika di klik
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && (textBox.Text == "Masukan NIK" || textBox.Text == "Masukan Nama" || textBox.Text == "Masukan Password" || textBox.Text == "Masukan Ulang Password"))
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        //method untuk memunculkan text di textfield ketika tidak di klik
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
