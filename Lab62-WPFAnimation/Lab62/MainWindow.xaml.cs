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
using System.Windows.Media.Animation;
namespace Lab62

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

        private void alice_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation myWidthAnimation = new DoubleAnimation();
            DoubleAnimation myHeightAnimation = new DoubleAnimation();

            myWidthAnimation.From = alice.Width;
            myWidthAnimation.To = alice.Width + 50;
            myWidthAnimation.Duration = TimeSpan.FromSeconds(1);

            myHeightAnimation.From = alice.Height;
            myHeightAnimation.To = alice.Height + 20;
            myHeightAnimation.Duration = TimeSpan.FromSeconds(2);

            alice.Content = "Alice is getting bigger.";
            alice.BeginAnimation(Button.WidthProperty, myWidthAnimation);
            alice.BeginAnimation(Button.HeightProperty, myHeightAnimation);

        }
    }
}
