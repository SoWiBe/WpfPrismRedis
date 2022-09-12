using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;

namespace WprPrismRedis
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App 
    {

        protected override Window CreateShell()
        {
            var shell = Container.Resolve<Main>();
            return shell;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
