using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace LearnEvents
{
    public class FileWatcherService : BackgroundService
    {
        int currentFileCount;
        private FileWatcherSender _fileWatcherSender;

        public FileWatcherService(FileWatcherSender fileWatcherSender)
        {
            _fileWatcherSender = fileWatcherSender;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
           StartTimer();
            return Task.CompletedTask;
        }

        private void StartTimer()
        {
            
            var dir = new DirectoryInfo("C:/learning");
            if (!dir.Exists)
            {
                dir.Create();
            }

            currentFileCount = dir.GetFiles().Count();
            var timer = new Timer(TimeSpan.FromSeconds(5));
            timer.Elapsed += OnTimerElapsed;
            timer.Start();

        }
        private void OnTimerElapsed(object? sender, ElapsedEventArgs e)
        {
            var newFileCount = Directory.GetFiles("C:/learning").Count();
            if (newFileCount == currentFileCount)
            {
                return;
            }

            currentFileCount = newFileCount;
            _fileWatcherSender.FileCountReceived(currentFileCount);
        }
    }
}
