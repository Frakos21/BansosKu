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
using APILibrary.API;
using APILibrary.Model;

namespace BansosKu.Page.BansosPage
{
    /// <summary>
    /// Interaction logic for Bansos1.xaml
    /// </summary>
    public partial class Bansos1 : Window
    {
        private MyAPI _api;

        public Bansos1()
        {
            InitializeComponent();
            InitializeApi();
            LoadData();
        }

        private void InitializeApi()
        {
            string apiKey = GetApiKey();
            _api = new MyAPI(apiKey);
        }

        private void LoadData()
        {
            try
            {
                List<BansosModel> listItems = _api.GetAllBansos();
                GroupBy.ItemsSource = listItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Kesalahan", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string GetApiKey()
        {
            string apiKey = "APIKeyKu";
            // TODO: Implementasikan logika untuk mendapatkan kunci API dari sumber yang aman
            // Misalnya, Anda dapat menyimpan kunci API dalam file konfigurasi yang terenkripsi atau menggunakan layanan manajemen kunci.
            // Hindari menyimpan kunci API secara langsung di dalam kode.
            return apiKey;
        }

        private void GroupBy_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            
        }
    }
}
