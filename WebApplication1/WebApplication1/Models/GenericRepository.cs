using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class GenericRepository<TEntity> : IRepoSitory<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository( AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task Create(TEntity entity)
        {
            await _appDbContext.Set<TEntity>().AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _appDbContext.Set<TEntity>().Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _appDbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _appDbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id==id);

        }

        public async Task Update(int id, TEntity entity)
        {
            _appDbContext.Set<TEntity>().Update(entity);
           await _appDbContext.SaveChangesAsync();
        }
    }
}
