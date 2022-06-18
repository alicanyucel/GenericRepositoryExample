using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class BookRepository:GenericRepository<Book> , IBookRepository
    {

        public BookRepository(AppDbContext appDbContext):base(appDbContext)
        {


        }

        public async Task<string> GetFirstBookName()
        {
            return await GetAll().Select(x => x.Name).FirstOrDefaultAsync();
        }
    }
}
