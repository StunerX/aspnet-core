﻿using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Scraper.Web.Views
{
    public abstract class ScraperRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ScraperRazorPage()
        {
            LocalizationSourceName = ScraperConsts.LocalizationSourceName;
        }
    }
}
