using System.ComponentModel.Composition;
using System.Windows;

namespace finTrader
{
    /// <summary>
    /// Interaction logic for AppShell.xaml
    /// </summary>
    [Export]
    public partial class AppShell : Window
    {
        public AppShell()
        {
            InitializeComponent();
        }
    }
}
