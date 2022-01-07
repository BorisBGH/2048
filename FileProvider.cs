using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public static class FileProvider
    {

        public static void SaveToFile(string fileName, string value)
        {
            StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();    

        }

        public static string GetValue(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string value = reader.ReadToEnd();
           
            reader.Close();
            return value;

        }


    }
}
