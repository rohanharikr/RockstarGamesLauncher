using System.Windows;
using System.Windows.Input;
using RockstarGamesLauncher.Views;

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
            Main.Content = new GamesView();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new SettingsView();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new GamesView();
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GoToStorePage(object sender, RoutedEventArgs e)
        {
            Main.Content = new StoreView();
        }
    }
}
