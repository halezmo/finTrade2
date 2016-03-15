using finTrader.Module.Menu.ViewModels;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace finTrader.Module.Menu.Views
{
    /// <summary>
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    [Export]
    public partial class UserMenu : UserControl
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        [Import]
        public UserMenuViewModel ViewModel
        {
            get { return this.DataContext as UserMenuViewModel; }
            set { this.DataContext = value; }
        }
    }
}
