using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppProject2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object userChoice;
        private ActiveStage activeStage = new ActiveStage();
        public object UserChoice { get => userChoice; set => userChoice = value; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnT1_Click(object sender, RoutedEventArgs e)
        {
            WindowT1 window = new WindowT1();
            this.Close();
            window.Show();
            userChoice = new WindowT1();
        }

        private void BtnT2_Click(object sender, RoutedEventArgs e)
        {
            WindowT2 window = new WindowT2();
            this.Close();
            window.Show();
            userChoice = new WindowT2();
        }

        private void BtnT3_Click(object sender, RoutedEventArgs e)
        {
            WindowT3 window = new WindowT3();
            this.Close();
            window.Show();
            userChoice = new WindowT3();
        }

        private void BtnT4_Click(object sender, RoutedEventArgs e)
        {
            WindowT4 window = new WindowT4();
            this.Close();
            window.Show();
            userChoice = new WindowT4();
        }

        private void BtnT5_Click(object sender, RoutedEventArgs e)
        {
            WindowT5 window = new WindowT5();
            this.Close();
            window.Show();
            userChoice = new WindowT5();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            File.Delete(activeStage.FilePath);
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            //здесь будет открываться последнее окно
            /*
            Window1 window = new Window1();
            window.Show();
            */
        }
    }
}