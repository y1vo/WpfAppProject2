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
using System.Windows.Shapes;

namespace WpfAppProject2
{
    /// <summary>
    /// Логика взаимодействия для WindowT4.xaml
    /// </summary>
    public partial class WindowT4 : Window
    {
        private ActiveStage activeStage = new ActiveStage();
        public WindowT4()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.ClearValue(TextBox.TextProperty);
            this.Close();

            MainWindow mainWindow = new MainWindow();

            File.Delete(activeStage.FilePath);
            if (!File.Exists(activeStage.FilePath)) { mainWindow.Show(); }
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            WindowSaveInFormat window = new WindowSaveInFormat();
            this.Close();
            window.Show();
        }
    }
}
