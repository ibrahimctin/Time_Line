﻿namespace Time_Line.Domain.Entities.DbModels.Identity
{
    public class AppUser:IdentityUser<string>
    {
        public virtual ICollection<AppUserRole> UserRoles { get; set; } = default!;
        public virtual List<RefreshToken>? RefreshTokens { get; set; }
        public DateTime AccountCreatedDate { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<SubComment> SubComments { get; set; }
    }
}
