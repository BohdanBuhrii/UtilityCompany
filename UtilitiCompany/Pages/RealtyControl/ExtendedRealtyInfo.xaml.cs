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
    /// Interaction logic for ExtendedRealtyInfo.xaml
    /// </summary>
    public partial class ExtendedRealtyInfo : UserControl
    {
        Realty realty;

        public ExtendedRealtyInfo(Realty realty)
        {
            this.realty = realty;
            InitializeComponent();
            ChooseImage();

            using (MetersRepo metersRepo=new MetersRepo())
            {
                foreach (long meterId in realty.AvailableMeters)
                {
                    MetersList.Items.Add(new MeterInfo(metersRepo.GetMeterInfo(meterId)));
                }
            }
        }

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


        private void MetersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
