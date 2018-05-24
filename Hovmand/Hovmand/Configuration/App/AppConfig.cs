using Hovmand.Views.App;
using Hovmand.ViewModels.App;
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
