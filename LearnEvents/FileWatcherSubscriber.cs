using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEvents
{
    public class FileWatcherSubscriber
    {
        private FileWatcherSender _fileWatcherSender;
        private bool subscribed;
        public FileWatcherSubscriber(FileWatcherSender fileWatcherSender)
        {
            _fileWatcherSender = fileWatcherSender;

        }
        public void Start()
        {
            if (subscribed)
            {
                return;
            }

            _fileWatcherSender.FileNumberChanged += OnFileNumberChanged;
            subscribed = true;
        }

        public void Stop()
        {
            if (!subscribed)
            {
                return;
            }
            _fileWatcherSender.FileNumberChanged -= OnFileNumberChanged;
            subscribed = false;
        }

        private void OnFileNumberChanged(object? sender, int fileCount)
        {
            Console.WriteLine($"Current file count is {fileCount}");
        }
    }
}
