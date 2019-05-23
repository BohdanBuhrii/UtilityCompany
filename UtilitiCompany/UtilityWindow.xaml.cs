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
using System.Windows.Shapes;
using UtilitiCompany.Pages;

namespace UtilitiCompany
{
    /// <summary>
    /// Interaction logic for UtilityWindow.xaml
    /// </summary>
    public partial class UtilityWindow : Window
    {
        public UtilityWindow(User user)
        {
            InitializeComponent();
            MainGrid.Children.Add(new MainPage(user));
        }

        private void Window_Expanded(object sender, RoutedEventArgs e)
        {

        }
    }
}
