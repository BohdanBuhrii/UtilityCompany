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
using DataModels;

namespace UtilitiCompany.Pages
{
    /// <summary>
    /// Interaction logic for Authentication.xaml
    /// </summary>
    public partial class Authentication : UserControl
    {
        UtilityWindow mainWindow;
        public Authentication()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            using (UsersRepo users = new UsersRepo())
            {
                if (!users.EmailExist(EmailTB.Text))
                {
                    MessageBox.Show("Uncorrect email");
                }
                else
                {
                    User user = users.GetUserByEmail(EmailTB.Text);

                    if (user.hash_password == "")
                    {
                        MessageBox.Show("User not found");
                    }
                    else if (user.hash_password == HashHelper.GetHashStringSHA256(UserPasswordBox.Password))
                    {
                        if (user.access_level == "admin")
                        {
                            //MessageBox.Show("Hello Admin");
                            MainGrid.Children.Clear();
                            MainGrid.Children.Add(new AdminControl.AdminControl());
                        }
                        else
                        {
                            MainGrid.Children.Clear();
                            //MainGrid.Children.Add(new MainPage(user));
                            mainWindow=new UtilityWindow(user);
                            Window.GetWindow(this).Close();
                            mainWindow.ShowDialog();
                            
                            //MessageBox.Show("Sucsess");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uncorent password");
                    }
                }
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
