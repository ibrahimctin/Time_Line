namespace Time_Line.Domain.Enitities.DbModels.Identity
{
    public class AppUserRole:IdentityUserRole<string>
    {
       
        public virtual AppUser User { get; set; } = default!;
        public virtual AppRole Role { get; set; } = default!;
    }
}
