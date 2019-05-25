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

namespace UtilitiCompany.Pages.MeterControl
{
    /// <summary>
    /// Interaction logic for MeterInfo.xaml
    /// </summary>
    public partial class MeterInfo : UserControl
    {
        Meter meter;
        public MeterInfo(Meter meter)
        {
            this.meter = meter;
            InitializeComponent();
            ChooseImage();
            IdLbl.Content += meter.Id.ToString();
            DateLbl.Content += meter.LastCheckDate.ToString();
            ReadingsTb.Text = meter.CurrentReadings.ToString();
        }

        private void ChooseImage()
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(
                  "pack://application:,,,/AssemblyName;../../Images/ServiceImages/" + meter.KindOfServices + ".png");
            image.EndInit();
            ServiceImage.Source = image;
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            using (MetersRepo metersRepo = new MetersRepo())
            {
                try
                {
                    metersRepo.UpdateCurrentReadings(meter.Id, Convert.ToDecimal(ReadingsTb.Text));
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }
    }
}
