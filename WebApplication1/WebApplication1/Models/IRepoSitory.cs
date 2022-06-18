using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IRepoSitory<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Create( TEntity entity);
        Task Update(int id,TEntity entity);
        Task Delete(int id);

    }
}
