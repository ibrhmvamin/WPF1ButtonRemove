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

namespace WpfApp1
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

        private void ClickMe(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                byte r=(byte)Random.Shared.Next(0, 255);
                byte g=(byte)Random.Shared.Next(0, 255);
                byte b=(byte)Random.Shared.Next(0, 255);
                btn.Background = new SolidColorBrush(Color.FromRgb(r,g,b));
                MessageBox.Show($"Content : {btn.Content} ; Height ; {btn.Height} ; Width ; {btn.Width} Color : {btn.Background}");
            }
        }

        private void RightButtonClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                gr.Children.Remove(btn);
                MainWindow1.Title=btn.Content.ToString();
            }
        }
    }
}
