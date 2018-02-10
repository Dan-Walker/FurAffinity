using System;

using Fur_Affinity.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Fur_Affinity.Views
{
    public sealed partial class NotificationsPage : Page
    {
        private NotificationsViewModel ViewModel
        {
            get { return DataContext as NotificationsViewModel; }
        }

        public NotificationsPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
