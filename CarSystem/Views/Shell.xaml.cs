using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using CarSystem.Utils;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CarSystem.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shell : Page
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationBar.IsPaneOpen = !NavigationBar.IsPaneOpen;
        }

        private void MapButton_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NavgateTo(DataContext, typeof(Map));
        }

        private void ParkingButton_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NavgateTo(DataContext, typeof(Parking));
        }

        private void RecorderButton_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NavgateTo(DataContext, typeof(Recorder));
        }

        private void MediaButton_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NavgateTo(DataContext, typeof(Media));
        }

        private void CarButton_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NavgateTo(DataContext, typeof(Car));
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NavgateTo(DataContext, typeof(Settings));
        }
    }
}
