﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace TimeTrackerTutorial.PageModels.Base
{
    public class PageModelBase : BindableObject
    {
        string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
