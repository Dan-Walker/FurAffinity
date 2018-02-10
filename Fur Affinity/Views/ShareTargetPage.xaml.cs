using System;

using Fur_Affinity.ViewModels;

using Windows.ApplicationModel.DataTransfer.ShareTarget;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Fur_Affinity.Views
{
    // TODO WTS: This page exists purely as an example of how to launch a specific page
    // in response to a protocol launch and pass it a value. It is expected that you will
    // delete this page once you have changed the handling of a protocol launch to meet your
    // needs and redirected to another of your pages.
    public sealed partial class ShareTargetPage : Page
    {
        private ShareTargetViewModel ViewModel
        {
            get { return DataContext as ShareTargetViewModel; }
        }

        public ShareTargetPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await ViewModel.LoadAsync(e.Parameter as ShareOperation);
        }
    }
}
