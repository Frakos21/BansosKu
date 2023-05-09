using BansosKu.Page.Pengaturan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace BansosKu.Page.Home
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void imgHome_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void imgBansosKu_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void imgPengaturan_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void imgKeluar_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void imgRiwayat_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        //private void Image_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    Sidebar side = new Sidebar();
        //}
    }
}
