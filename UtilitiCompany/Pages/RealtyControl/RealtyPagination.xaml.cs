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

namespace UtilitiCompany.Pages.RealtyControl
{
    /// <summary>
    /// Interaction logic for RealtyPagination.xaml
    /// </summary>
    public partial class RealtyPagination : UserControl
    {
        private List<Realty> realties;
        private int currentIndex;
        private long user_id;

        

        public RealtyPagination(long user_id)
        {
            currentIndex = 1;
            this.user_id = user_id;
            InitializeComponent();
            //RealtyList.Items.Add(new RealtyInfo(new Realty { address = "test address", district = "test district", status="all good"}));
            using (RealtyRepo realtyRepo = new RealtyRepo())
            {
                var realties = realtyRepo.GetByOwner(user_id);
                foreach (Realty r in realties)
                {
                    if (currentIndex == 2) break;
                    RealtyList.Items.Add(new RealtyInfo(r));
                }
            }
        }

        private void ChangePage()
        {

        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            ChangePage();
        }
    }
}
