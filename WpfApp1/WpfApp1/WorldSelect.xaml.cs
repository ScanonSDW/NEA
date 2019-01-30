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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for WorldSelect.xaml
    /// </summary>
    public partial class WorldSelect : Window
    {
        public WorldSelect()
        {
            InitializeComponent();
        }

        private void btnWorld1_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new SelectLevel();
            newForm.Show();
            this.Close();
        }

        private void btnWorld2_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new SelectLevel();
            newForm.Show();
            this.Close();
        }

        private void btnWorld3_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new SelectLevel();
            newForm.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow();
            newForm.Show();
            this.Close();
        }
    }
}
