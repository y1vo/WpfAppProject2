using Microsoft.Win32;
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
        public Person person = new Person();
        private string template = "1";

        public WindowT1()
        {
            InitializeComponent();

            if (File.Exists(person.FilePath)) { person.ReceiveDataFromLog(); }
            else { return; }
        }

        private void SendData()
        {
            person.Template = template;
            person.Fullname = this.fullname.Text;
            person.Birthday = this.birthday.Text;
            person.Address = this.address.Text;
            person.Phone = this.phone.Text;
            person.Mail = this.mail.Text;
            person.Aim = this.aim.Text;
            person.Experience = this.experience.Text;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {       
            SendData();
            person.SaveDataToLog();
            this.Close();
            Environment.Exit(0);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Show();

            /*MainWindow mainWindow = new MainWindow();*/

            File.Delete(person.FilePath);
            /*if (!File.Exists(person.FilePath))
            {
                mainWindow.Show();
            }*/
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