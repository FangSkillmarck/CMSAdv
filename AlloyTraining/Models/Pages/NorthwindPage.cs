using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.Pages
{
    [SiteContentType(DisplayName = "Northwind",
        Description = "A page that lists categories from the Northwind database.")]
    [SiteImageUrl]
    public class NorthwindPage : SitePageData
    {
    }
}