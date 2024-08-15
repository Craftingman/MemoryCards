using MemoryCards.Core.Common;

namespace MemoryCards.Core.Entities
{
    public class Card : BaseEntity
    {
        public ICollection<CardContent> Contents { get; set; } = new List<CardContent>();
    }
}
