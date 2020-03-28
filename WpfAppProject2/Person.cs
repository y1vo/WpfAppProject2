using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppProject2
{
    public class Person : Data
    {
        private string filePath = @"C:\Users\w4\Desktop\Exam WPF\WpfAppProject2\SaveLog.txt";
        public string FilePath { get => filePath; }
        private string template;
        public string Template { get => template; set => template = value; }

        private List<string> personalData = new List<string>();

        public void SaveDataToLog()
        {
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);

            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine(Template);
                streamWriter.WriteLine(base.Fullname);
                streamWriter.WriteLine(base.Birthday);
                streamWriter.WriteLine(base.Address);
                streamWriter.WriteLine(base.Phone);
                streamWriter.WriteLine(base.Mail);
                streamWriter.WriteLine(base.Aim);
                streamWriter.WriteLine(base.Age);
                streamWriter.WriteLine(base.AboutMe);
                streamWriter.WriteLine(base.Achievement);
                streamWriter.WriteLine(base.Activity);
                streamWriter.WriteLine(base.Biography);
                streamWriter.WriteLine(base.Citizenship);
                streamWriter.WriteLine(base.Education);
                streamWriter.WriteLine(base.Experience);
                streamWriter.WriteLine(base.Language);
                streamWriter.WriteLine(base.Recommendation);
                streamWriter.WriteLine(base.Relocation);
                streamWriter.WriteLine(base.Salary);
                streamWriter.WriteLine(base.Skill);
            }
        }

        /* Эта часть в работе.*/
        public void ReceiveDataFromLog()
        {
            string[] items;
            string[] separator = { "\r\n" };
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);

            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                items = streamReader.ReadToEnd().Split(separator, StringSplitOptions.RemoveEmptyEntries);                
            }

            for (int i = 1; i < items.Length; i++)
            {
                personalData.Add(items[i]);
            }
        }
    }
}