using Hovmand.View.App;
using Hovmand.ViewModel.App;
using Windows.UI.Xaml.Controls;

namespace Hovmand.Configuration.App
{
    public class AppConfig
    {
        public static void Setup(Page mainPage, Frame appFrame)
        {
            appFrame.Navigate(typeof(OverviewPage));
            ((AppViewModel)mainPage.DataContext).SetAppFrame(appFrame);
        }
    }
}
