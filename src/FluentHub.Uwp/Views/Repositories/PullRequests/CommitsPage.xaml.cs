﻿using FluentHub.Uwp.Services;
using FluentHub.Uwp.ViewModels.Repositories.PullRequests;
using Microsoft.Extensions.DependencyInjection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using muxc = Microsoft.UI.Xaml.Controls;

namespace FluentHub.Uwp.Views.Repositories.PullRequests
{
    public sealed partial class CommitsPage : Page
    {
        public CommitsPage()
        {
            InitializeComponent();

            var provider = App.Current.Services;
            ViewModel = provider.GetRequiredService<CommitsViewModel>();
            navigationService = provider.GetRequiredService<INavigationService>();
        }

        private readonly INavigationService navigationService;
        public CommitsViewModel ViewModel { get; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            PullRequest param = e.Parameter as PullRequest;

            DataContext = e.Parameter;

            var currentItem = navigationService.TabView.SelectedItem.NavigationHistory.CurrentItem;
            currentItem.Header = $"{param.Title} · #{param.Number}";
            currentItem.Description = currentItem.Header;
            currentItem.Url = $"https://github.com/{param.Repository.Owner.Login}/{param.Repository.Name}/pull/{param.Number}";
            currentItem.Icon = new muxc.ImageIconSource
            {
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Commits.png"))
            };

            var command = ViewModel.RefreshPullRequestPageCommand;
            if (command.CanExecute(param))
                command.Execute(param);
        }
    }
}