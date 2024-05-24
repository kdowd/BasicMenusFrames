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

namespace MenusFrames
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

        private void NavigateToPage(object sender, RoutedEventArgs e)
        {
            var t = sender as Control;

            if (t != null)
            {
                //MessageBox.Show(t.Name);


                switch (t.Name)
                {
                    case "One":
                        pageFrame.Source = new Uri("Page1.xaml", UriKind.Relative);
                        break;
                    case "Two":
                        pageFrame.Source = new Uri("Page2.xaml", UriKind.Relative);
                        break;
                    default:
                        MessageBox.Show("Should not get to here");
                        break;
                }

            }



        }
    }
}
