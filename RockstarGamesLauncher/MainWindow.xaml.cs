using System.Windows;
using System.Windows.Input;
using RockstarGamesLauncher.ViewModels;

namespace RockstarGamesLauncher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void DragApp(object sender, MouseButtonEventArgs e) => DragMove();

        private void MinimizeApp(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void MaximizeApp(object sender, RoutedEventArgs e)
        {
            if(WindowState is WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void CloseApp(object sender, RoutedEventArgs e) => Close();
    }
}
