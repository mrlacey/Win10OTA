using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace RunWithCustomisationsEverywhere
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = Windows.UI.Core.AppViewBackButtonVisibility.Collapsed;
        }

        private void SecondPageTapped(object sender, TappedRoutedEventArgs e)
        {
            #region ..
            var printerSupported = Windows.Foundation.Metadata.ApiInformation
                .IsApiContractPresent("Windows.Devices.Printers.PrintersContract", 1, 0);

            MyLogger.Log(this, printerSupported);
            #endregion

            this.Frame.Navigate(typeof(SecondPage));
        }

        private void HomeButtonTapped(object sender, TappedRoutedEventArgs e)
        {
            this.TheSplitView.IsPaneOpen = true;
        }
    }
}
