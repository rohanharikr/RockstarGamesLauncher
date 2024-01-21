using System.Collections;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace RockstarGamesLauncher.Controls
{
    public partial class Carousel : UserControl
    {
        #region Dependency properties
        public IEnumerable Feed
        {
            get { return (IEnumerable)GetValue(FeedProperty); }
            set { SetValue(FeedProperty, value); }
        }
        public static readonly DependencyProperty FeedProperty =
            DependencyProperty.Register("Feed", typeof(IEnumerable), typeof(Carousel), new PropertyMetadata(null, new PropertyChangedCallback(FeedPropertyChanged)));
        #endregion

        int currentElement = 0;

        //TBD Get this from XAML
        readonly double cardWidth = 250;
        readonly double cardMargin = 10;

        public Carousel()
        {
            InitializeComponent();
        }

        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            if (currentElement < CarouselStack.Items.Count - 1)
            {
                currentElement++;
                UpdateCarousel();
            }
        }

        private void PrevButtonClick(object sender, RoutedEventArgs e)
        {
            if (currentElement > 0)
            {
                currentElement--;
                UpdateCarousel();
            }
        }

        private void OpenFeedPost(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            Uri link = (Uri)button.Tag;
            Process.Start(new ProcessStartInfo(link.ToString()) //Open link in browser
            {
                UseShellExecute = true
            });
        }

        private void UpdateCarousel(bool animate = true)
        {
            //TBD Handle exceptions
            Storyboard storyboard = (this.Resources["CarouselStoryboard"] as Storyboard);
            DoubleAnimation animation = storyboard.Children.First() as DoubleAnimation;
            animation.Duration = TimeSpan.FromSeconds(animate ? 0.2 : 0);
            QuadraticEase easingFunction = new()
            {
                EasingMode = EasingMode.EaseInOut
            };
            animation.EasingFunction = easingFunction;
            animation.To = -(cardWidth + cardMargin) * currentElement;
            storyboard.Begin();
        }

        private static void FeedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Carousel carousel = (Carousel)d;
            carousel.currentElement = 0;
            carousel.UpdateCarousel(false);
        }
    }
}
