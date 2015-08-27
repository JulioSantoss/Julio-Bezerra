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

namespace Agenda
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

        private void Register_Edit(object sender, RoutedEventArgs e)
        {
            Register_Edit RegisterWindow = new Register_Edit();
            this.Close();
            RegisterWindow.Show();

        }

        private void View_Remove(object sender, RoutedEventArgs e)
        {
            View ViewWindow = new View();
            this.Close();
            ViewWindow.Show();
        }
    }
}
