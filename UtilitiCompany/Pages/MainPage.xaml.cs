using DataModels;
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
using UtilitiCompany.Pages.RealtyControl;

namespace UtilitiCompany.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        private User user;
        public MainPage(User user)
        {
            this.user = user;
            InitializeComponent();
            UserNameLbl.Content = user.Name;
            RealtyGrid.Children.Add(new RealtyPagination(user.Id));
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new Authentication());
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            RealtyGrid.Children.Clear();
            RealtyGrid.Children.Add(new RealtyPagination(user.Id));
        }

        private void PaymentBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
