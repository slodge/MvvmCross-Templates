using System;
using System.Collections.Generic;

namespace MyApplication.Core.Services.First
{
    public interface IFirstService
    {
        void GetItems(string key, Action<List<SimpleItem>> onSuccess, Action<FirstServiceError> onError);
    }
}
