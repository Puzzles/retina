/* Retina is a WPF based IRC client currently in development.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Retina
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Core core = new Core();
            messageList.Items.Add("Core Initializing...");
            try
            {
                core.init();
                messageList.Items.Add("Initialized Successfully.");
            }
            catch
            {
                messageList.Items.Add("There was an error, not implemented yet?");
            }
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            Core.handleMessage(this,sendBox.Text);
            sendBox.Clear();
        }
    }
}
