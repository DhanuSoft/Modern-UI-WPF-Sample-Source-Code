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
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Presentation;

namespace WPF_Modern_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentSource = MenuLinkGroups.First().Links.First().Source;/* Automatically select the firat page */
            AppearanceManager.Current.AccentColor = Colors.Green;

        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            //ModernDialog Dialog = new ModernDialog();
            //Dialog.Title = "DIALOG EXAMPLE";
            //Dialog.Buttons = new Button[] { Dialog.OkButton, Dialog.CancelButton };
            //Dialog.Content = "Testing a new DialogResult";
            //Dialog.ShowDialog();
        }
    }
}
