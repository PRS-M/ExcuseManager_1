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
        public DateTime lastUsedDateTime { get; set; }
        public string Description { get; set; }
        public string Result { get; set; }
        public string ExcusePath { get; set; }

        public void OpenFile(string fileName)
        {

        }

        public void Save(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Result);
                writer.WriteLine(lastUsedDateTime.ToString());
            }
        }
    }
}
