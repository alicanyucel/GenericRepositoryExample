using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    public class AlicanController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public AlicanController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IActionResult> Index()
        {
            var book = new Book { Name = "Nutuk", Author = "M.K.Atatürk" };
            var book2 = new Book { Name = "Geometri", Author = "M.K.Atatürk" };
            var book3 = new Book { Name = "Cumhuriyet", Author = "AliCan" };
            var book4 = new Book { Name = "Çay", Author = "M.K" };
            await _bookRepository.Create(book);
            await _bookRepository.Create(book2);
            await _bookRepository.Create(book3);
            await _bookRepository.Create(book4);
            var model = _bookRepository.GetAll();
            return View(model);

        }
    }
}