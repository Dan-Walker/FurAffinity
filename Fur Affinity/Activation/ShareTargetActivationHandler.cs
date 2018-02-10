using System;
using System.Threading.Tasks;

using Fur_Affinity.Views;

using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Fur_Affinity.Activation
{
    internal class ShareTargetActivationHandler : ActivationHandler<ShareTargetActivatedEventArgs>
    {
        protected override async Task HandleInternalAsync(ShareTargetActivatedEventArgs args)
        {
            // Activation from ShareTarget opens the app as a new modal window which requires a new activation.
            var frame = new Frame();
            Window.Current.Content = frame;
            frame.Navigate(typeof(ShareTargetPage), args.ShareOperation);
            Window.Current.Activate();

            await Task.CompletedTask;
        }
    }
}
