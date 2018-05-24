using Hovmand.Configuration.App;
using Windows.UI.Xaml.Controls;

namespace Hovmand.View.App
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            AppConfig.Setup(this, AppFrame);
        }
    }
}
