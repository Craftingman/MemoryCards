using MemoryCards.Core.Common;

namespace MemoryCards.Core.Entities
{
    public class Card : BaseEntity
    {
        public Guid CardCollectionId { get; set; }
        public CardCollection CardCollection { get; set; }

        public ICollection<CardContent> Contents { get; set; } = new List<CardContent>();
    }
}
