using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibraryWeb.Pages.BookList
{
    public class IndexModel : PageModel
    {
        #region Fields

        private readonly ApplicationDbContext _db;

        #endregion

        #region Properties

        public IEnumerable<Book> Books { get; set; }

        #endregion

        #region Constructors

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        #endregion

        #region Methods

        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }

        #endregion
    }
}
