using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CarSystem
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationBar.IsPaneOpen = !NavigationBar.IsPaneOpen;
        }

        private void MenuHighlight_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            var panel = sender as StackPanel;
            if (panel != null) panel.Background = new SolidColorBrush(Colors.LightBlue);
        }

        private void MenuHighlight_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            var panel = sender as StackPanel;
            if (panel != null) panel.Background = new SolidColorBrush(Colors.Gray);
        }
    }
}
