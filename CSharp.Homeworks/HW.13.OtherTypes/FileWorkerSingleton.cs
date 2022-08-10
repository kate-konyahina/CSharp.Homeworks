using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._13.OtherTypes
{
    public sealed class FileWorkerSingleton
    {
        private static readonly Lazy<FileWorkerSingleton> instance = new Lazy<FileWorkerSingleton>(() => new FileWorkerSingleton());

        public static FileWorkerSingleton Instance { get { return instance.Value; } }

        public string FilePath { get; private set; }

        public string Text { get; private set; }

        private FileWorkerSingleton()
        {
            FilePath = "test.txt";
            ReadTextFromFile();
        }

        public void WriteText(string text)
        {
            Text += text;
        }

        public void Save()
        {
            using(var writer = new StreamWriter(FilePath, false))
            {
                writer.Write(Text);
            }
        }

        private void ReadTextFromFile()
        {
            if (!File.Exists(FilePath))
            {
                Text = "";
            }
            else
            {
                using (var reader = new StreamReader(FilePath))
                {
                    Text=reader.ReadToEnd();
                }
            }
        }
    }
}
