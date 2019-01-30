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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginClicked(object sender, RoutedEventArgs e)
        {
            var newForm = new Login();
            newForm.Show();
            this.Close();
        }

        private void registerClicked(object sender, RoutedEventArgs e)
        {
            var newForm = new Register();
            newForm.Show();
            this.Close();
        }
    }
}
