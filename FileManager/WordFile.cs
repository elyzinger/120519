using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class WordFile : MyFile, IWordCounter
    {
        public string text { get; set; }
        public WordFile(string textFile, int fileSize, bool readOnly, bool archiveFile) : base(fileSize, readOnly, archiveFile)
        {
            this.text = textFile;
        }

        
        public int NumberOfWords
        {
            get
            {
                return text.Split(' ').Length;

            }
        }
        public int NumberOfPages
        {
            get
            {
                return text.Split(' ').Length / 10;
            }

        } 


        public string this[int indexer] 
        {
            get { return this[indexer]; }
            set { this[indexer] = value; }
        }

        public override void PrintFile()
        {
            for(int i = 0; i < text.Split(' ').Length; i++)
            {
                Console.WriteLine(text.Split(' ')[i]);
            } 
        }

       
    }
}
