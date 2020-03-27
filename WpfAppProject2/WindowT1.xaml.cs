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
    /// Логика взаимодействия для WindowT1.xaml
    /// </summary>
    public partial class WindowT1 : Window
    {
        private ActiveStage activeStage = new ActiveStage(); 
        public WindowT1()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            /*
             * здесь удалются все данные с текстбоксов, закрывается текущий шаблон и открывается меню шаблонов.
             * 
             * так как у нас сохраняется окно которое пользователь посещял до закрытия 
             * то при попытке начать сначала возникает конфликт с главным окном (смотреть конструктор условие if).
             * Конфликт устранил путем удаления файла с папки. То же самое сделал и для других шаблонов.
             */
            this.ClearValue(TextBox.TextProperty);
            this.Close();

            MainWindow mainWindow = new MainWindow();

            File.Delete(activeStage.FilePath);
            if (!File.Exists(activeStage.FilePath)) 
            { 
                mainWindow.Show();
            }
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            WindowSaveInFormat window = new WindowSaveInFormat();
            this.Close();
            window.Show();
        }

        public override string ToString()
        {
            return "ФИО: " + txtBox1;
        }
    }
}
