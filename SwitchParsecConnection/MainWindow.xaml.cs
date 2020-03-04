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

namespace SwitchParsecConnection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnApplyParsecSettings_Click(object sender, RoutedEventArgs e)
        {
            if (rdDefaultHomeParsec.IsChecked == true)
            {

                //reboot parsec with 
                /*
                  app_run_level = 3
                    encoder_bitrate = 50
                    encoder_vbv_max = 1500
                    encoder_min_bitrate = 40
                 */
                ConfigureParsecSettings.ConfigureParsec(Properties.Resources.HomeParsecSettings);
                var msg = RebootParsec.BootupParsec();

                txtMsgStatus.Text = msg;
            }
            else if (rdSlowerHomeParsec.IsChecked == true)
            {

                //reboot parsec with 
                /*
                  app_run_level = 3
                    encoder_bitrate = 50
                    encoder_vbv_max = 1500
                    encoder_min_bitrate = 10
                 */

                ConfigureParsecSettings.ConfigureParsec(Properties.Resources.HomeSlowerParsecSettings);
                var msg = RebootParsec.BootupParsec();

                txtMsgStatus.Text = msg;
            }

            else if (rdWorkParsec.IsChecked == true)
            {
                //reboot parsec with 
                /*
                  app_run_level = 3
                    encoder_bitrate = 50
                    #encoder_vbv_max = 1500
                    #encoder_min_bitrate = 40
                 */
                ConfigureParsecSettings.ConfigureParsec(Properties.Resources.WorkParsecSettings);
                var msg = RebootParsec.BootupParsec();

                txtMsgStatus.Text = msg;
            }

            else
            {
                
                txtMsgStatus.Text ="Select a choice from above.";
            }
        }
    }
}
