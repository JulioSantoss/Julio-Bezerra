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

namespace Agenda
{
    /// <summary>
    /// Interaction logic for Register_Edit.xaml
    /// </summary>
    public partial class Register_Edit : Window
    {
        Contacts Contact = new Contacts();
       
        public Register_Edit()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            this.Close();
            MainWindow.Show();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Contact._name = Tb_NameInsert.Text;
            Contact._Telephone = Tb_TelephoneInsert.Text;
            Contact._Cellphone = Tb_CellphoneInsert.Text;
            Contact._Adress._Street = Tb_CityInsert.Text;
            Contact._Adress._Neighborhood = Tb_NeighborhoodInsert.Text;
            Contact._Adress._HouseNumber = int.Parse(Tb_HouseNumberInsert.Text);
            Contact._Adress._City = Tb_CityInsert.Text;
            Contact._Adress._State = Tb_StateInsert.Text;
            Contact._Adress._Country = Tb_CountryInsert.Text;
            Contact._Adress._ZipCode = Tb_ZipcodeInsert.Text;
                          
        }
        string teste = "";
        private void ClearTextBt(object sender, RoutedEventArgs e)
        {
            TextBox current = (sender as TextBox);
            teste = current.Text;
            current.Text = "";
           
        }

        private void esse(object sender, RoutedEventArgs e)
        {
            TextBox current = (sender as TextBox);
            if(current.Text == "")
            {
                current.Text = teste;
            }
        }

       


    }
}
