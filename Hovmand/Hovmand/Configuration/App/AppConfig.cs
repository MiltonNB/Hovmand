using Hovmand.View.App;
using Hovmand.ViewModel.App;
using Windows.UI.Xaml.Controls;
using Hovmand.View.Domain;

namespace Hovmand.Configuration.App
{
    public class AppConfig
    {
        public static void Setup(Page mainPage, Frame appFrame)
        {
            appFrame.Navigate(typeof(LeadsPage));
            ((AppViewModel)mainPage.DataContext).SetAppFrame(appFrame);
        }
    }
}
