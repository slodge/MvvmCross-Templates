﻿using System.Collections.Generic;
using System.Windows.Input;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using MyApplication.Core.Services.First;

namespace MyApplication.Core.ViewModels
{
    public class HomeViewModel : ViewModel
    {
        private string _key;
        public string Key
        {
            get { return _key; }
            set { _key = value; RaisePropertyChanged(() => this.Key); }
        }

        private List<SimpleItem> _items;
        public List<SimpleItem> Items
        {
            get { return _items; }
            set { _items = value; RaisePropertyChanged(() => this.Items); }
        }

        public ICommand FetchItemsCommand
        {
            get
            {
                return new MvxCommand(DoFetchItems);
            }
        }

        private void DoFetchItems()
        {
            var service = Mvx.Resolve<IFirstService>();
            service.GetItems(this.Key, OnSuccess, OnError);
        }

        private void OnSuccess(List<SimpleItem> simpleItems)
        {
            Items = simpleItems;
        }

        private void OnError(FirstServiceError firstServiceError)
        {
            ReportError("Sorry - a problem occurred - " + firstServiceError.ToString());
        }
    }
}
