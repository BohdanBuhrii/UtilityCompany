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
using UtilitiCompany.Pages.MeterControl;

namespace UtilitiCompany.Pages.RealtyControl
{
    /// <summary>
    /// Interaction logic for RealtyPagination.xaml
    /// </summary>
    public partial class RealtyPagination : UserControl
    {
        private long offset;
        private long totalNumberOfItems;
        private long userId;


        public RealtyPagination(long userId)
        {
            offset = 0;
            using (RealtyRepo realtyRepo = new RealtyRepo())
            {
                totalNumberOfItems = (long)realtyRepo.ExecuteScalar("SELECT COUNT(*) FROM realty");
            }
            this.userId = userId;
            InitializeComponent();
            ReplaseItems(5);
            
        }

        private void ReplaseItems(int numberOfItems)
        {
            RealtyList.Items.Clear();
            using (RealtyRepo realtyRepo = new RealtyRepo())
            {
                List<Realty> realties = realtyRepo.GetByOwner(userId, numberOfItems, offset);
                foreach (Realty r in realties)
                {
                    RealtyList.Items.Add(new RealtyInfo(r));
                }
            }
        }

        
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            offset -= 5;
            ReplaseItems(5);
            if (offset == 0) BackBtn.Visibility = Visibility.Collapsed;

            NextBtn.Visibility = Visibility.Visible;
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            offset += 5;
            ReplaseItems(5);
            if (offset >= totalNumberOfItems - 5) NextBtn.Visibility = Visibility.Collapsed;

            BackBtn.Visibility = Visibility.Visible;
        }
    }
}
