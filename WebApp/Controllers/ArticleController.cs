using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;

namespace CleanBlog.Controllers;

public class ArticleController : Controller
{
    private readonly AppDbContext _context;

    public ArticleController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Detail(int id)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction("index", "Home");
        }
        var article = _context.Articles.Include(x=>x.Author).FirstOrDefault(x => x.Id == id);
        return View(article);
    }
}
