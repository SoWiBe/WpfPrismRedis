using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WprPrismRedis.Views;

namespace WprPrismRedis.Module
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("MainRegion", typeof(TabView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            throw new NotImplementedException();
        }
    }
}
