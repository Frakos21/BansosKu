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
      
        private MyAPI _api = new MyAPI();
        public Bansos1()
        {
            InitializeComponent();
            List<BansosModel> listItems = _api.GetAllBansos();     
            GroupBy.ItemsSource = listItems;

        }
     
        private void GroupBy_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
