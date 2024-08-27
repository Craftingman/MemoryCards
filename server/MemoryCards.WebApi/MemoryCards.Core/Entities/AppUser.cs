using Microsoft.AspNetCore.Identity;

namespace MemoryCards.Core.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public ICollection<CardCollection> CardCollections { get; set; }
    }
}
