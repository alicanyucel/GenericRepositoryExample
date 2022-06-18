using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IBookRepository:IRepoSitory<Book>
    {
        Task<string> GetFirstBookName();

    }
}
