using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppProject2
{
    public class Person : Data
    {
        private string filePath = "SaveLog.txt";

        public string FilePath { get => filePath; }

        public void SaveTextToLog()
        {
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);

            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
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

        public override string ToString()
        {
            return "ФИО: " + base.fullname + "Birthday: " + base.birthday + "Address: " + base.address + "Phone: " + base.phone +
                   "Mail: " + base.mail + "Aim: " + base.aim + "Age: " + base.age + "About me: " + base.aboutMe +
                   "Achievement: " + base.achievement + "Activity: " + base.activity + "Biography: " + base.biography +
                   "Citizenship: " + base.citizenship + "Education: " + base.education + "Experience: " + base.experience +
                   "Language: " + base.language + "Recommendation: " + base.recommendation + "Relocation: " + base.relocation +
                   "Salary: " + base.salary + "Skill: " + base.skill;
        }
    }
}