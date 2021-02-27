using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace DecorateWriter
{
    class DecorateWriter
    {
        private static string filepath = "output\\DECORATE.txt";

        public static void clear()
        {
            File.Delete(filepath);
        }
        public static void writeLine(string line)
        {
            File.AppendAllText(filepath, line + "\n");
        }

        public static void writeTabbedLine(string line, int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                line = "\t" + line;
            }
            writeLine(line);
        }
        public static void compress()
        {
            File.Delete("output.pk3");
            ZipFile.CreateFromDirectory(@".\output", @".\output.pk3");
        }
    }
}
