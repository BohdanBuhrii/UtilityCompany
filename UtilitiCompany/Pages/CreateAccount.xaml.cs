using DataModels;
using Repository.ConcreteTablesLogic;
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

namespace UtilitiCompany.Pages
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : UserControl
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void UserNameTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            //UserNameLbl.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            using (UsersRepo usersRepo = new UsersRepo())
            {
                if (UserPasswordBox.Password != UserPasswordBox_Copy.Password) MessageBox.Show("Passwords are differnt");
                else if (usersRepo.EmailExist(EmailTB.Text)) MessageBox.Show("This Email used for another user");
                else
                {
                    usersRepo.AddUser(UserNameTB.Text, EmailTB.Text, UserPasswordBox.Password);
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new AccountCreated());
                }

            }
        }

        private void EmailTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            //EmailLbl.Visibility = Visibility.Collapsed;
        }
    }
}
