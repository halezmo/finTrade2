using Prism.Mef;
using System.ComponentModel.Composition.Hosting;

namespace finTrader
{
    class BootStrapper : MefBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<AppShell>();
        }
        protected override void InitializeModules()
        {
            base.InitializeModules();
            App.Current.MainWindow = (AppShell)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            var mainDirectoryCatalog = new DirectoryCatalog(".");         
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(BootStrapper).Assembly));
            AggregateCatalog.Catalogs.Add(mainDirectoryCatalog);
            base.ConfigureAggregateCatalog();
        }
    }
}
