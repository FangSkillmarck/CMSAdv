using AlloyTraining.Business.EditorDescriptors;
using EPiServer.Core;
using EPiServer.Find.Blocks.Models;
using EPiServer.Shell.ObjectEditing;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    /// <summary>
    /// Used primarily for publishing news articles on the website
    /// </summary>
    [SiteContentType(
        GroupName = Global.GroupNames.News,
        GUID = "AEECADF2-3E89-4117-ADEB-F8D43565D2F4")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-article.png")]
    public class ArticlePage : StandardPage
    {
        //  [SelectOne(SelectionFactoryType = typeof(ContactPageSelectionFactory))]
        [UIHint(Global.SiteUIHints.Contact)]
        public virtual PageReference Author { get; set; }
    }
}
