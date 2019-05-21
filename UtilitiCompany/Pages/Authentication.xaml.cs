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
using Repository.ConcreteTablesLogic;
using Helper;

namespace UtilitiCompany.Pages
{
    /// <summary>
    /// Interaction logic for Authentication.xaml
    /// </summary>
    public partial class Authentication : UserControl
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            using (UsersRepo users = new UsersRepo())
            {
                string hash_password = (string)users.ExecuteScalar(
                    string.Format("SELECT hash_password FROM users WHERE email = '{0}'",
                    EmailTB.Text));
                if (hash_password == "")
                {
                    MessageBox.Show("User not found");
                }
                else if (hash_password == HashHelper.GetHashStringSHA256(UserPasswordBox.Password))
                {
                    MessageBox.Show("Sucsess");

                }
                else
                {
                    MessageBox.Show("Uncorent password");
                }
                //PasswordTB.Text;
            }

        }

        private void NoAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            //this.GetUIParentCore().SetCurrentValue(,new CreateAccount());
            
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new CreateAccount());
        }
    }
}
