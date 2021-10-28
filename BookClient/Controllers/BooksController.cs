using BookClient.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BookClient.Controllers
{
  public class BooksController : Controller
  {
    public IActionResult Index()
    {
      var allBooks = Book.GetBooks();
      return View(allBooks);
    }

    [HttpPost]
    public async Task<IActionResult> Index(Book book)
    {
      await Book.Post(book);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var book = Book.GetDetails(id);
      return View(book);
    }

    public IActionResult Edit(int id)
    {
      var book = Book.GetDetails(id);
      return View(book);
    }

    [HttpPost]
    public async Task<IActionResult> Details(int id, Book book)
    {
      book.BookId = id;
      await Book.Put(book);
      return RedirectToAction("Details", id);
    }

    public async Task<IActionResult> Delete(int id)
    {
      await Book.Delete(id);
      return RedirectToAction("Index");
    }
  }
}