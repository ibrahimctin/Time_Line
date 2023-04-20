namespace Time_Line.Domain.Application.Abstraction.Persistence.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
