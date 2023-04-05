using CleanBlog.Models;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;

namespace CleanBlog.Controllers;

public class ContactController : Controller
{
    private readonly AppDbContext _context;

    public ContactController(AppDbContext context)
    {
        _context = context;
    }

    // GET
    public IActionResult Index()
    {
    
        return View();
    }

    [HttpPost]
    public IActionResult Index(Contact contact)
    {
        if (!ModelState.IsValid)
        {
            return View(contact);
        }
        var _contact = _context.Contacts.Add(contact);
        _context.SaveChanges();
        return RedirectToAction("Index" , "Home");
    }
}