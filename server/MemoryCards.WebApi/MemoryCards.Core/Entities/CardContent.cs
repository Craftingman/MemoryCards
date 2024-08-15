using MemoryCards.Core.Common;
using MemoryCards.Core.Enums;

namespace MemoryCards.Core.Entities
{
    public class CardContent : BaseEntity
    {
        public CardContentType ContentType { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
