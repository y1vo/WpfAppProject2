using Microsoft.Win32;
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

namespace WpfAppProject2
{
    /// <summary>
    /// Логика взаимодействия для WindowT3.xaml
    /// </summary>
    public partial class WindowT3 : Window
    {
        public WindowT3()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            WindowSaveInFormat window = new WindowSaveInFormat();
            this.Close();
            window.Show();
        }
        private void BtnAddPic_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.BMP; *.JPG; *.PNG; *.JPEG)|*.BMP; *.JPG; *.PNG; *.JPEG)| All files (*.*)|*.*";
            if (openFile.ShowDialog() == true)
            {
                string str = openFile.FileName;
                img1.Source = new BitmapImage(new Uri(str));
            }

        }

    }
}
