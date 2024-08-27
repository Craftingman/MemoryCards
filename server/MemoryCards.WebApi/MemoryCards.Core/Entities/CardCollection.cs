using MemoryCards.Core.Common;

namespace MemoryCards.Core.Entities
{
    public class CardCollection : BaseEntity
    {
        public string Name { get; set; }

        public Guid OwnerId { get; set; }
        public AppUser Owner { get; set; }
    }
}
