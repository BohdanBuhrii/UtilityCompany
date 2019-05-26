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
using UtilitiCompany.Pages.MeterControl;

namespace UtilitiCompany.Pages.RealtyControl
{
    /// <summary>
    /// Interaction logic for RealtyInfo.xaml
    /// </summary>
    public partial class RealtyInfo : UserControl
    {
        private Realty realty;

        private MetersWindow metersWindow;
        private void ChooseImage()
        {
            //System.Windows.Media.ImageSourceConverter("../../Images/RealtyImages/");
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            string[] types = new string[] { "cityscape", "factory", "flat", "mansion" };

            if (types.Contains(realty.Type))
            {
                image.UriSource = new Uri(
                  "pack://application:,,,/AssemblyName;../../Images/RealtyImages/" + realty.Type + ".png");
            }
            else
            {
                image.UriSource = new Uri(
                    "pack://application:,,,/AssemblyName;../../Images/RealtyImages/unknown.png");
            }


            image.EndInit();
            RealtyImage.Source = image;
        }

        public RealtyInfo(Realty realty)
        {
            InitializeComponent();

            this.realty = realty;
            AddressLbl.Content = realty.Address;
            DistrictLbl.Content = realty.District;
            StatusLbl.Content = realty.Status; //todo label coloring
            ChooseImage();
        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {
            //MainGrid.Children.Clear();
            //MainGrid.Children.Add(new ExtendedRealtyInfo(realty));
            var a = (Grid)((ListBox)this.Parent).Parent;
            a.Children.Clear();
            a.Children.Add(new ExtendedRealtyInfo(realty));
           // metersWindow = new MetersWindow(realty); ////!!!!!!!!!!!!!!!!!
        }
    }
}
