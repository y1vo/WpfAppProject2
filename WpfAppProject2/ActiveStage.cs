using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Controls;
using System.Windows;

namespace WpfAppProject2
{
    public class ActiveStage
    {
        private string filePath = "ActiveStageSaveLog.txt";

        public string FilePath { get => filePath; }

        public void SaveTextToLog(object obj)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);

            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {

            }
        }
    }
}