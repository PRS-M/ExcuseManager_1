using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExcuseManager_1
{
    class Excuse
    {
        public DateTime LastUsedDateTime { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        public void OpenFile(string excusePath)
        {
            this.ExcusePath = excusePath;

            using (StreamReader reader = new StreamReader(excusePath))
            {
                Description = reader.ReadLine();
                Result = reader.ReadLine();
                LastUsedDateTime = Convert.ToDateTime(reader.ReadLine());
            }
        }

        public void Save(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Result);
                writer.WriteLine(LastUsedDateTime.ToString());
            }
        }
    }
}
