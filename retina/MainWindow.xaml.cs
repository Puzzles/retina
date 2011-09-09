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

namespace retina
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

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            this.messageBox.Text = this.messageBox.Text + "\n" + sendBox.Text;
            sendBox.Clear();
            
        }

        private void sendBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Do spellcheck logic?
        }

        private void memberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Do hover-over logic? (Ident information?)
        }

        private void channelTabs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Do change-tab logic.
        }

        private void editMenu_Click(object sender, RoutedEventArgs e)
        {
            // Do edit menu logic.
        }

        private void preferencesMenu_Click(object sender, RoutedEventArgs e)
        {
            // Do preferences menu logic.
        }
    }
}
