using APILibrary.API;
using APILibrary.Model;
using BansosKu.Page.Pengaturan;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace BansosKu.Page.Data_Page
{
    /// <summary>
    /// Interaction logic for Data.xaml
    /// </summary>
    public partial class Data : Window
    {
        private UserModel myUser;
        private UserModel updateUser = new UserModel();
        PengaturanPage set = new PengaturanPage();
        MyAPI _api = new MyAPI();
        public Data()
        {
            InitializeComponent();
            getMyUser();
        }

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

        private void BtnKirim_Click(object sender, RoutedEventArgs e)
        {
            Debug.Assert(tbNik.Text !="", "NIK harus diisi");
            Debug.Assert(tbNama.Text != "", "Nama harus diisi");
            Debug.Assert(tbAlamat.Text != "", "Alamat harus diisi");
            Debug.Assert(tbKTP.Text != "", "Foto KTP harus diisi");
            Debug.Assert(tbRumah.Text != "", "Foto Rumah harus diisi");
            Debug.Assert(tbPendapatan.Text != "", "Pendapatan harus diisi");
            try
            {
                if (tbNama.Text.Equals("-") || tbNik.Text.Equals("-") || tbAlamat.Text.Equals("-") || tbPendapatan.Text.Equals("-") || tbKTP.Text.Equals("-")|| tbRumah.Text.Equals("-"))
                {
                    MessageBox.Show("Mohon diisi semuanya");
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

                    var res = _api.updateUser(updateUser, myUser.Id);
                    if(res != -1) {
                        MessageBox.Show("Update Berhasil");
                        this.Close();
                        set.Show();
                    }
                    else
                    {
                        MessageBox.Show("Update Gagal");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            set.Show();
        }
    }
}
