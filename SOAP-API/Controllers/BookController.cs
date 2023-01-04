using BookServiceReference;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SOAP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            BookServiceClient client = new BookServiceClient(BookServiceClient.EndpointConfiguration.BasicHttpBinding_IBookService);
            Debug.WriteLine(client);
            Debug.WriteLine(client.Endpoint.Name);
            Debug.WriteLine(client.Endpoint);
            Debug.WriteLine(BookServiceClient.EndpointConfiguration.BasicHttpBinding_IBookService);

            await client.OpenAsync();
            var result = await client.GetAllBooksAsync();
            await client.CloseAsync();
            return Ok(result);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateBook(Book book)
        {
            BookServiceClient client = new BookServiceClient(BookServiceClient.EndpointConfiguration.BasicHttpBinding_IBookService);
            Debug.WriteLine(client);
            Debug.WriteLine(client.Endpoint.Name);
            Debug.WriteLine(client.Endpoint);
            Debug.WriteLine(BookServiceClient.EndpointConfiguration.BasicHttpBinding_IBookService);

            await client.OpenAsync();
            var result = await client.UpdateBookAsync(book);
            await client.CloseAsync();
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> AddBook(Book book)
        {
            BookServiceClient client = new BookServiceClient(BookServiceClient.EndpointConfiguration.BasicHttpBinding_IBookService);
            Debug.WriteLine(client);
            Debug.WriteLine(client.Endpoint.Name);
            Debug.WriteLine(client.Endpoint);
            Debug.WriteLine(BookServiceClient.EndpointConfiguration.BasicHttpBinding_IBookService);

            await client.OpenAsync();
            var result = await client.AddBookAsync(book);
            await client.CloseAsync();
            return Ok(result);
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteBook(int Id)
        {
            BookServiceClient client = new BookServiceClient(BookServiceClient.EndpointConfiguration.BasicHttpBinding_IBookService);
            Debug.WriteLine(client);
            Debug.WriteLine(client.Endpoint.Name);
            Debug.WriteLine(client.Endpoint);
            Debug.WriteLine(BookServiceClient.EndpointConfiguration.BasicHttpBinding_IBookService);

            await client.OpenAsync();
            var result = await client.DeleteBookAsync(Id);
            await client.CloseAsync();
            return Ok(result);
        }
    }
}
