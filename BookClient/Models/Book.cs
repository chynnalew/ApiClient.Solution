using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookClient.Models
{
  public class Book
  {
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Rating { get; set; }
    public bool Read { get; set; }


    public static List<Book> GetBooks()
    {
      var apiCallTask = ApiHelper.GetAll();
      string result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse.ToString());

      return bookList;
    }
    public static Book GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      string result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      Book book = JsonConvert.DeserializeObject<Book>(jsonResponse.ToString());

      return book;
    }

    public async static Task Post(Book book)
    {
      string jsonBook = JsonConvert.SerializeObject(book);
      await ApiHelper.Post(jsonBook);
    }
    public async static Task Put(Book book)
    {
      string jsonBook = JsonConvert.SerializeObject(book);
      await ApiHelper.Put(book.BookId, jsonBook);
    }

    public async static Task Delete(int id)
    {
      await ApiHelper.Delete(id);
    }

  }
}