using Microsoft.Win32;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для WindowT5.xaml
    /// </summary>
    public partial class WindowT5 : Window
    {
        public Person person = new Person();
        private string template = "5";
        public WindowT5()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            //this.ClearValue(TextBox.TextProperty);
            this.Close();
            this.Owner.Show();

            //MainWindow mainWindow = new MainWindow();

            /*File.Delete(person.FilePath);
            if (!File.Exists(person.FilePath)) {*/ //mainWindow.Show(); /*}*/
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            WindowSaveInFormat window = new WindowSaveInFormat();
            window.Owner = this;
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