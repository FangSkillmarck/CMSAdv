using EPiServer.Core;

namespace AlloyTraining.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
