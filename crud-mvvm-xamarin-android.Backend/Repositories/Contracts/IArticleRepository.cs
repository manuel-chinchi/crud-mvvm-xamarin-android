﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using crud_mvvm_xamarin_android.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crud_mvvm_xamarin_android.Backend.Repositories.Contracts
{
    internal interface IArticleRepository : IBaseRepository<Article>
    {
    }
}