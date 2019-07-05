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

namespace First
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
        private void CreateViewImageDynamically()
        {
            Image dynamicImage = new Image();
            dynamicImage.Stretch = Stretch.Fill;
            dynamicImage.StretchDirection = StretchDirection.Both;
            dynamicImage.Width = 300;
            dynamicImage.Height=200;

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\Luka\Desktop\MVVMIRC\MVVMSolution\First\money_heist.jpg");
            bitmap.EndInit();

            dynamicImage.Source = bitmap;

            LayoutRoot.Children.Add(dynamicImage);
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CreateViewImageDynamically();
        }
    }
}
