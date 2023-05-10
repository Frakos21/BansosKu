using BansosKu.Page.BansosPage;
using BansosKu.Page.Pengaturan;
using System.Windows.Input;
using System.Windows;

namespace BansosKu.Page.Home
{
    public enum HomePageState
    {
        Default,
        Bansos,
        Pengaturan,
        Keluar
    }

    public partial class HomePage : Window
    {
        private HomePageState currentState;

        public HomePage()
        {
            InitializeComponent();
            currentState = HomePageState.Default;
        }

        private void ChangeState(HomePageState newState)
        {
            currentState = newState;
            // Lakukan perubahan UI atau tindakan lain berdasarkan state baru
            switch (currentState)
            {
                case HomePageState.Default:
                    // Tampilkan halaman default
                    break;
                case HomePageState.Bansos:
                    Bansos1 bansosPage = new Bansos1();
                    this.Close();
                    bansosPage.Show();
                    break;
                case HomePageState.Pengaturan:
                    PengaturanPage pengaturanPage = new PengaturanPage();
                    this.Close();
                    pengaturanPage.Show();
                    break;
                case HomePageState.Keluar:
                    AppSettings.Default.id = 0;
                    MainWindow login = new MainWindow();
                    login.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void imgHome_Click(object sender, MouseButtonEventArgs e)
        {
            ChangeState(HomePageState.Default);
        }

        private void imgBansosKu_Click(object sender, MouseButtonEventArgs e)
        {
            ChangeState(HomePageState.Bansos);
        }

        private void imgPengaturan_Click(object sender, MouseButtonEventArgs e)
        {
            ChangeState(HomePageState.Pengaturan);
        }

        private void imgKeluar_Click(object sender, MouseButtonEventArgs e)
        {
            ChangeState(HomePageState.Keluar);
        }

        private void imgRiwayat_Click(object sender, MouseButtonEventArgs e)
        {
            // Tidak ada perubahan state untuk aksi ini
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            // Tidak ada perubahan state untuk aksi ini
        }
    }
}
