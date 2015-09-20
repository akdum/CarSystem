using System;
using Windows.UI.Xaml.Controls;

namespace CarSystem.Utils
{
    public static class Navigation
    {
        public static void NavgateTo(object dataContext, Type pageType)
        {
            var frame = dataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != pageType)
            {
                frame.Navigate(pageType);
            }
        }
    }
}
