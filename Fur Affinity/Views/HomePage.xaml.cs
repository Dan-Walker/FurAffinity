using System;

using Fur_Affinity.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Fur_Affinity.Views
{
    public sealed partial class HomePage : Page
    {
        private HomeViewModel ViewModel
        {
            get { return DataContext as HomeViewModel; }
        }

        public HomePage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
