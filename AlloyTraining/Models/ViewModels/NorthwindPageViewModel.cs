using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.NorthwindEntities;
using EPiServer.Core;

namespace AlloyTraining.Models.ViewModels
{
    public class NorthwindPageViewModel : IPageViewModel<NorthwindPage>
    {
        public NorthwindPageViewModel(NorthwindPage currentPage)
        {
            this.CurrentPage = currentPage;
            this.CategoryLinks = new Dictionary<string, string>();
        }


        public Dictionary<string, string> CategoryLinks { get; set; }
        public NorthwindPage CurrentPage { get; set; }

        public Category Category { get; set; }

        public LayoutModel Layout { get; set; }

        public IContent Section { get; set; }
    }
}