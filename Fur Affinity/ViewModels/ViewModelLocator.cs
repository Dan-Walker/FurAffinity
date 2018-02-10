using System;

using Fur_Affinity.Services;
using Fur_Affinity.Views;

using GalaSoft.MvvmLight.Ioc;

using Microsoft.Practices.ServiceLocation;

namespace Fur_Affinity.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            if (SimpleIoc.Default.IsRegistered<NavigationServiceEx>())
            {
                return;
            }

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<HomeViewModel, HomePage>();
            Register<ForumsViewModel, ForumsPage>();
            Register<InfoViewModel, InfoPage>();
            Register<SettingsViewModel, SettingsPage>();
            Register<UriSchemeExampleViewModel, UriSchemeExamplePage>();
            Register<ShareTargetViewModel, ShareTargetPage>();
            Register<NotificationsViewModel, NotificationsPage>();
        }

        public NotificationsViewModel NotificationsViewModel => ServiceLocator.Current.GetInstance<NotificationsViewModel>();

        public ShareTargetViewModel ShareTargetViewModel => ServiceLocator.Current.GetInstance<ShareTargetViewModel>();

        public UriSchemeExampleViewModel UriSchemeExampleViewModel => ServiceLocator.Current.GetInstance<UriSchemeExampleViewModel>();

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public InfoViewModel InfoViewModel => ServiceLocator.Current.GetInstance<InfoViewModel>();

        public ForumsViewModel ForumsViewModel => ServiceLocator.Current.GetInstance<ForumsViewModel>();

        public HomeViewModel HomeViewModel => ServiceLocator.Current.GetInstance<HomeViewModel>();

        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
