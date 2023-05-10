using APILibrary.API;
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

namespace BansosKu.Page.Data_Page
{
    /// <summary>
    /// Interaction logic for Data.xaml
    /// </summary>
    public partial class Data : Window
    {
        MyAPI _api = new MyAPI();
        public Data()
        {
            InitializeComponent();
        }

        private void BtnKirim_Click(object sender, RoutedEventArgs e)
        {
            if (tbNama.Text.Equals("") || tbNik.Text.Equals("") || tbAlamat.Text.Equals("")||tbPendapatan.Text.Equals(""))
            {
                MessageBox.Show("Mohon diisi semuanya");
            }
            else
            {
                
            }
        }

    }
}
