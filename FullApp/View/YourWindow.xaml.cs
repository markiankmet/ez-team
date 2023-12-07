using FontAwesome.Sharp;
using FullApp.ViewModel;
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
using System.Windows.Shapes;
using WpfAnimatedGif;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FullApp.View
{
    /// <summary>
    /// Interaction logic for YourWindow.xaml
    /// </summary>
    public partial class YourWindow : Window
    {
        public YourWindow()
        {
            InitializeComponent();
            string gifPath = "https://i0.wp.com/www.printmag.com/wp-content/uploads/2021/02/4cbe8d_f1ed2800a49649848102c68fc5a66e53mv2.gif?fit=476%2C280&ssl=1";

            // Створіть новий об'єкт BitmapImage
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(gifPath);
            bitmap.EndInit();

            // Призначте BitmapImage об'єкту Image
            gifImage.Source = bitmap;
            MessageBox.Show("Show");
            // Додайте обробник подій, щоб гарантувати відтворення анімації
            gifImage.Loaded += GifImage_Loaded;
        }

        private void GifImage_Loaded(object sender, RoutedEventArgs e)
        {
            // Відтворення анімації після завантаження зображення
            //ImageBehavior.SetAnimatedSource(gifImage, new BitmapImage(new Uri("https://i0.wp.com/www.printmag.com/wp-content/uploads/2021/02/4cbe8d_f1ed2800a49649848102c68fc5a66e53mv2.gif?fit=476%2C280&ssl=1")));
        }
        public void btnMaximize_Click(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
