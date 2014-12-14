﻿using System.Windows;
using SleepWatcher.Infrastructure;

namespace SleepWatcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AutoMapperConfiguration.Configure();
            DispatcherUnhandledException += (sender, args) => MessageBox.Show("Something went wrong!\nApplication will close now...");
        }
    }
}
