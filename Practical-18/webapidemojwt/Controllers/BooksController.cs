using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapidemojwt.Data;
using webapidemojwt.Repository;

namespace webapidemojwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    

    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookrepository;
      public BooksController(IBookRepository bookrepository)
        {
            _bookrepository = bookrepository;
        }
        [HttpGet("")]
        public async Task<IActionResult> getallbook()
        {
            var result = await _bookrepository.GetAllBooksAsync();
            return Ok(result);
        }
       [Authorize(Roles ="User")]
        [HttpGet("{id}")]
        public async Task<IActionResult> getbookbyid([FromRoute] int id)
        {
            var result = await _bookrepository.GetBookByIdAsync(id);
            return Ok(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("")]
        public async Task<IActionResult> addnewbook([FromBody] Books newbook)
        {
            var id = await _bookrepository.AddBookAsync(newbook);
            return CreatedAtAction(nameof(getbookbyid),new { id = id, Controller="books"},id);
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> updatebook([FromRoute] int id,[FromBody] Books bookmodel)
        {
            await _bookrepository.UpdateBookAsync(id,bookmodel);
            return Ok();
        }
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "User")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> deletebook([FromRoute] int id)
        {
            await _bookrepository.DeleteBookAsync(id);
            return Ok();
        }

    }
}
