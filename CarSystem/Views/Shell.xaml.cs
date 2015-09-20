using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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
            this.InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationBar.IsPaneOpen = !NavigationBar.IsPaneOpen;
        }

        private void MapButton_Click(object sender, RoutedEventArgs e)
        {
            var frame = DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(Map))
            {
                frame.Navigate(typeof(Map));
            }
        }

        private void ParkingButton_Click(object sender, RoutedEventArgs e)
        {
            var frame = DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(Parking))
            {
                frame.Navigate(typeof(Parking));
            }
        }
    }
}
