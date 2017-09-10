using AlloyTraining.Models;
using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;

namespace AlloyTraining.Business.Selectors
{
    public class YouTubeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return EpiserverYouTube.Videos;
        }
    }
}