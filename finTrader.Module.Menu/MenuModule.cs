using finTrader.Module.Menu.Views;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace finTrader.Module.Menu
{
    [ModuleExport(typeof(MenuModule))]    
    public class MenuModule : IModule
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public MenuModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion("MenuRegion", typeof(UserMenu));
        }
    }
}
