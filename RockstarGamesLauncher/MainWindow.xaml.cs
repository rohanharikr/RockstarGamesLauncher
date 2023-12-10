using System.Windows;
using System.Windows.Input;
using RockstarGamesLauncher.Views;
using RockstarGamesLauncher.ViewModels;

namespace RockstarGamesLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void DragApp(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
