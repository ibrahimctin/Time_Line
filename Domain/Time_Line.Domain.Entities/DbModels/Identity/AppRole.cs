namespace Time_Line.Domain.Entities.DbModels.Identity
{
    public class AppRole:IdentityRole<string>
    {
        public virtual ICollection<AppUserRole>? UserRoles { get; set; }

    }
}
