using APILibrary.API;
using APILibrary.Model;
using BansosKu.Page.Pengaturan;
using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BansosKu.Page.Data_Page
{
    //Page data 
    public partial class Data : Window
    {
        private UserModel myUser;
        private UserModel updateUser = new UserModel();
        PengaturanPage set = new PengaturanPage();
        MyAPI _api = new MyAPI();

        // Constructor
        public Data()
        {
            InitializeComponent();
            getMyUser();
        }

        // Method Mengambil data user dari model
        private void getMyUser()
        {
            myUser = _api.getUserById(AppSettings.Default.id);
            tbNik.Text = myUser.NIK;
            tbNama.Text = myUser.Fullname;
            tbAlamat.Text = myUser.Alamat;
            tbKTP.Text = myUser.FotoKTP;
            tbRumah.Text = myUser.FotoRumah;
            tbPendapatan.Text = myUser.Pendapatan;
        }
        
        // Method Mengupdate data
        private void BtnUpadate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNik.Text) || string.IsNullOrEmpty(tbNama.Text) || string.IsNullOrEmpty(tbAlamat.Text) ||
                string.IsNullOrEmpty(tbKTP.Text) || string.IsNullOrEmpty(tbRumah.Text) || string.IsNullOrEmpty(tbPendapatan.Text))
            {
                MessageBox.Show("Mohon diisi semua field");
                return;
            }

            try
            {
                if (!IsNIKValid(tbNik.Text))
                {
                    MessageBox.Show("NIK tidak valid, silahkan diperiksa");
                }
                else if (!IsPasswordStrong(myUser.Password))
                {
                    MessageBox.Show("Password harus memiliki minimal 8 karakter dan mengandung huruf besar, huruf kecil, dan angka");
                }
                else
                {
                    updateUser.NIK = tbNik.Text;
                    updateUser.Fullname = tbNama.Text;
                    updateUser.Role = myUser.Role;
                    updateUser.Password = myUser.Password;
                    updateUser.Alamat = tbAlamat.Text;
                    updateUser.FotoKTP = tbKTP.Text;
                    updateUser.FotoRumah = tbRumah.Text;
                    updateUser.Pendapatan = tbPendapatan.Text;
                }
                var res = _api.updateUser(updateUser, myUser.Id);
                if (res != -1)
                {
                    MessageBox.Show("Update Berhasil");
                    this.Close();
                    set.Show();
                }
                else
                {
                    MessageBox.Show("Update Gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        // Method pengecekan NIK
        private bool IsNIKValid(string nik)
        {
            // Implementasikan validasi NIK sesuai kebutuhan Anda
            // Misalnya, cek panjang dan format NIK
            // Menggunakan regular expression atau aturan yang berlaku
            // NIK harus terdiri dari 16 angka
            return nik.Length == 16;
        }

        // Method pengecekan password
        private bool IsPasswordStrong(string password)
        {
            // Implementasikan validasi keamanan password
            // Password harus memiliki minimal 8 karakter,
            // termasuk setidaknya satu huruf besar, satu huruf kecil, dan satu angka
            return password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        // Method untuk kembali ke page pengaturan
        private void ButtonKembali_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            set.Show();
        }
    }
}
