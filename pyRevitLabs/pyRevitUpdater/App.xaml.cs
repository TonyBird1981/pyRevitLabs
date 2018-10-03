﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using pyRevitLabs.CommonCLI;

namespace pyRevitUpdater {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStartup(object sender, StartupEventArgs e) {
            //if (e.Args.Length > 0) {
                ConsoleProvider.Attach();
                PyRevitUpdaterCLI.ProcessArguments(e.Args);
                ConsoleProvider.Detach();
            //}

            Environment.Exit(0);
        }
    }
}