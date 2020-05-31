using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DndCharacterSheet.IOC;
using DndCharacterSheet.Views.Windows;

namespace DndCharacterSheet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //EventLog.Initialize(this.logPath);

            IocContainer.Build();

            // Set the starting window
            this.MainWindow = IocContainer.ResolveWindow(typeof(MainWindow));
            this.MainWindow.Show();
        }
    }
}
