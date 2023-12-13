using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RockstarGamesLauncher.Controls
{
    /// <summary>
    /// Interaction logic for Slider.xaml
    /// </summary>

    public partial class Carousel : UserControl
    {
        private int currentElement = 0;
        private double cardWidth = 250;
        private double cardMargin = 10;

        public Carousel()
        {
            InitializeComponent();
        }

        public IEnumerable Feed
        {
            get { return (IEnumerable)GetValue(FeedProperty); }
            set { SetValue(FeedProperty, value); }
        }

        public static readonly DependencyProperty FeedProperty =
            DependencyProperty.Register("Feed", typeof(IEnumerable), typeof(Carousel), new PropertyMetadata());


        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            if (currentElement < CarouselStack.Items.Count - 1)
            {
                currentElement++;
                AnimateCarousel();
            }
        }

        private void PrevButtonClick(object sender, RoutedEventArgs e)
        {
            if (currentElement > 0)
            {
                currentElement--;
                AnimateCarousel();
            }
        }

        private void AnimateCarousel()
        {
            Storyboard storyboard = (this.Resources["CarouselStoryboard"] as Storyboard);
            DoubleAnimation animation = storyboard.Children.First() as DoubleAnimation;
            animation.Duration = TimeSpan.FromSeconds(0.2);
            QuadraticEase easingFunction = new QuadraticEase();
            easingFunction.EasingMode = EasingMode.EaseInOut;
            animation.EasingFunction = easingFunction;
            animation.To = -(cardWidth + cardMargin) * currentElement;
            storyboard.Begin();
        }
    }
}
