using APILibrary.API;
using BansosKu.Model;
using BansosKu.Page.Home;
using BansosKu.Page.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BansosKu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        private MyAPI _api = new MyAPI();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            this.Close();
            register.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            var pw = new System.Net.NetworkCredential(string.Empty, tbPassword.SecurePassword).Password;
            if (tbNik.Text.Equals(""))
            {
                MessageBox.Show("NIK harus diisi!!");
            }else if (pw.Equals("")){
                MessageBox.Show("Password harus diisi!!");
            }
            else
            {
                var res = _api.Login(tbNik.Text,pw);
                if(res == false)
                {
                    MessageBox.Show("Login Gagal");
                }
                else
                {
                    MessageBox.Show("Login Berhasil");
                    Home home = new Home();
                    this.Close();
                    home.Show();
                }
            }
        }
    }

}
