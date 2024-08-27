using MemoryCards.Core.Common;

namespace MemoryCards.Core.Entities
{
    public class Card : BaseEntity
    {
        public Guid CardCollectionId { get; set; }
        public CardCollection CardCollection { get; set; }

        public ICollection<CardContent> FrontSideContents { get; set; } = new List<CardContent>();
        public ICollection<CardContent> BackSideContents { get; set; } = new List<CardContent>();
    }
}
