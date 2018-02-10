using System;

using Fur_Affinity.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Fur_Affinity.Views
{
    public sealed partial class ForumsPage : Page
    {
        private ForumsViewModel ViewModel
        {
            get { return DataContext as ForumsViewModel; }
        }

        public ForumsPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
