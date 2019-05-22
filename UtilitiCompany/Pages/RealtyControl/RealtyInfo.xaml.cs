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

namespace UtilitiCompany.Pages.RealtyControl
{
    /// <summary>
    /// Interaction logic for RealtyInfo.xaml
    /// </summary>
    public partial class RealtyInfo : UserControl
    {
        private Realty realty;
        public RealtyInfo(Realty realty)
        {
            InitializeComponent();
            this.realty = realty;
            AddressLbl.Content = realty.address;
            DistrictLbl.Content = realty.district;
            StatusLbl.Content = realty.status; //todo label coloring
        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
