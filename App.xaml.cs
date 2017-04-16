using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApplication2.test;

namespace WpfApplication2
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            mainService = new MainService();
            mainService.Run();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            mainService.Quit();

            base.OnExit(e);  
        }

        public MainService mainService;
    }
}
