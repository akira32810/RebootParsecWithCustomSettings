
using System.Windows;


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

        private void MIHomeSwitch_Click(object sender, RoutedEventArgs e)
        {
            ConfigureParsecSettings.ConfigureParsec(Properties.Resources.HomeParsecSettings);
            var msg = RebootParsec.BootupParsec();

            txtMsgStatus.Text = msg;
        }

        private void MIHomeLowSwitch_Click(object sender, RoutedEventArgs e)
        {
            ConfigureParsecSettings.ConfigureParsec(Properties.Resources.HomeSlowerParsecSettings);
            var msg = RebootParsec.BootupParsec();

            txtMsgStatus.Text = msg;
        }

        private void MIWorkSwitch_Click(object sender, RoutedEventArgs e)
        {
            ConfigureParsecSettings.ConfigureParsec(Properties.Resources.WorkParsecSettings);
            var msg = RebootParsec.BootupParsec();

            txtMsgStatus.Text = msg;
        }



        private void MIQuit_Click(object sender, RoutedEventArgs e)
        {
     

            if (MessageBox.Show("Close Application?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No, MessageBoxOptions.DefaultDesktopOnly) == MessageBoxResult.No)
            {
                //do nothing
              
            }
            else
            {  
                //do yes stuff
                System.Windows.Application.Current.Shutdown();
              
            }


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
