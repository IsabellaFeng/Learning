using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEvents
{
    public class FileWatcherSender
    {
        public event EventHandler<int>? FileNumberChanged;
        public void FileCountReceived(int fileCount)
        {
            FileNumberChanged?.Invoke(null, fileCount);
        }

    }
} 
