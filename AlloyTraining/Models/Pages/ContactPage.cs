using System.ComponentModel.DataAnnotations;
using AlloyTraining.Business;
using AlloyTraining.Business.EditorDescriptors;
using AlloyTraining.Business.Rendering;
using EPiServer.Web;
using EPiServer.Core;
using AlloyTraining.Business.Selectors;
using EPiServer.Shell.ObjectEditing;

namespace AlloyTraining.Models.Pages
{
    /// <summary>
    /// Represents contact details for a contact person
    /// </summary>
    [SiteContentType(
        GroupName = Global.GroupNames.Specialized)]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-contact.png")]
    public class ContactPage : SitePageData, IContainerPage
    {
        [Display(GroupName = Global.GroupNames.Contact)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(GroupName = Global.GroupNames.Contact)]
        public virtual string Phone { get; set; }

        [Display(GroupName = Global.GroupNames.Contact)]
      //  [Business.EmailAddress]
      [UIHint(Global.SiteUIHints.Email)]
        public virtual string Email { get; set; }

        [Display(
            Name = "Region",
            GroupName = Global.GroupNames.Contact,
            Order = 10)]
        [SelectOneEnum(typeof(Region))]
        public virtual Region Region { get; set; }

        [Display(
            Name = "YouTube video",
            GroupName = Global.GroupNames.Contact,
            Order = 20)]
        // [SelectOne(SelectionFactoryType = typeof(YouTubeSelectionFactory))]
        [UIHint(Global.SiteUIHints.YouTube)]
        public virtual string YouTubeVideo { get; set; }

        [Display(
            Name = "Home city",
            GroupName = Global.GroupNames.Contact,
            Order = 30)]
        [SelectOne(SelectionFactoryType = typeof(CitySelectionFactory))]
        public virtual string HomeCity { get; set; }

        [Display(
            Name = "Other cities",
            GroupName = Global.GroupNames.Contact,
            Order = 40)]
        // [SelectMany(SelectionFactoryType = typeof(CitySelectionFactory))]
        [UIHint(Global.SiteUIHints.Cities)]
        public virtual string OtherCities { get; set; }

        public virtual PageReference contactsPageLink { get; set; }

    }
}
