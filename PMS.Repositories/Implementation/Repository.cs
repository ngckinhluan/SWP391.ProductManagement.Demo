using Microsoft.EntityFrameworkCore;
using PMS.BusinessObjects.Context;
using PMS.Repositories.Interface;

namespace PMS.Repositories.Implementation;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly MyDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(MyDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

    public async Task<T?> GetByIdAsync(string id) => await _dbSet.FindAsync();

    public async Task InsertAsync(T entity) => await _dbSet.AddAsync(entity);
    
    public void Update(T entity) => _dbSet.Update(entity);

    public void Delete(T entity) => _dbSet.Remove(entity);
    
}