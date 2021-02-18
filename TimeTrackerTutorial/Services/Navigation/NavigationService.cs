﻿using System;
using System.Threading.Tasks;
using TimeTrackerTutorial.PageModels.Base;
using Xamarin.Forms;

namespace TimeTrackerTutorial.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        public NavigationService()
        {
        }

        public Task GoBackAsync()
        {
            return App.Current.MainPage.Navigation.PopAsync();
        }

        public Task NavigateToAsync<TPageModelBase>(object navigationData = null, bool setRoot = false)
        {
            var page = PageModelLocator.CreatePageFor(typeof(TPageModelBase));

            if (setRoot)
            {
                App.Current.MainPage = new NavigationPage(page);
            }
            else
            {
                if (App.Current.MainPage is NavigationPage navPage)
                {
                    return navPage.PushAsync(page);
                }
                else
                {
                    App.Current.MainPage = new NavigationPage(page);
                }
            }
            return Task.CompletedTask;
        }
    }
}
