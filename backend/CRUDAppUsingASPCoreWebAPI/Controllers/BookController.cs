using System.Text;
using CRUDAppUsingASPCoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CRUDAppUsingASPCoreWebAPI.Controllers;

public class BookController: Controller
{
    private String url = "http://localhost:5167/api/books/";
    private readonly HttpClient _client=new HttpClient();
    
    [HttpGet]
    public IActionResult BookStore()
    {
        List<Books> booksList = new List<Books>();
        var response = _client.GetAsync(url).Result;
        if (response.IsSuccessStatusCode)
        {
            string result = response.Content.ReadAsStringAsync().Result;
            var data = JsonConvert.DeserializeObject<List<Books>>(result);
            if (data!=null)
            {
                booksList = data;
            }
        }
        return View(booksList);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(Books books)
    {
        string data = JsonConvert.SerializeObject(books);
        var content = new StringContent(data, Encoding.UTF8, "application/json");
        HttpResponseMessage responseMessage = _client.PostAsync(url,content).Result;
        if (responseMessage.IsSuccessStatusCode)
        {
            TempData["insert_message"] = "Book Added....";
            return RedirectToAction("BookStore");
        }
        return View();
    }

   
}