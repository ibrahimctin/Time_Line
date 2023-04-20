namespace Time_Line.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public WriteRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            model.Id ??= Guid.NewGuid().ToString();
            var result = await Table.AddAsync(model);
            return result.State == EntityState.Added;
        }

        
        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            datas.ForEach(x => x.Id = Guid.NewGuid().ToString());
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T model)
        {
            var result = Table.Remove(model);
            return result.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var result = await Table.FirstOrDefaultAsync(p => p.Id == id);
            if (result != null)
            {
                Table.Remove(result);
                return true;
            }
            return false;

        }

        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public bool Update(T model)
        {
            var result = Table.Update(model);
            return result.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
    }
}
