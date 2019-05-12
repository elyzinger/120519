using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    abstract class MyFile : IFileAttributes
    {
        readonly string filePath = "";
        const bool hebrewFile = true;
        public int FileSize { get;private set; }
        public bool IsReadOnly { get; private set; }
        public bool IsArchiveFile  { get; private set; }
        public bool HasVirus { get; private set; }
        List<string> paths = new List<string>();
    
        public MyFile(string filePath)
        {
            this.filePath = filePath;
        }

        public MyFile(int fileSize, bool readOnly, bool archiveFile)
        {
            
            paths.Add(filePath);
            FileSize = fileSize;
            IsReadOnly = readOnly;
            IsArchiveFile = archiveFile;
        }

        public string FilePath
        {
            get
            {
                return filePath;
            }
        }
        public abstract void PrintFile();
        

        
    }
}
