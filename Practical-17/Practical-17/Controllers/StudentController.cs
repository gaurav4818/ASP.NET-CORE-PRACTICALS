using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practical_17.Data;
using Practical_17.Models;
using Practical_17.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_17.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentrepository;
        private readonly IMapper _mapper;
        public StudentController(IStudentRepository studentrepository,IMapper mapper)
        {
            _studentrepository = studentrepository;
            _mapper = mapper;
        }
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<StudentViewModel>>> getallstudent()
        {
            var result = _mapper.Map<List<StudentViewModel>>(await _studentrepository.GetAllStudentAsync());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getstudentbyid([FromRoute] int id)
        {
            var result = await _studentrepository.GetStudentByIDAsync(id);
            return Ok(result);
        }
        [HttpPost("")]
        public async Task<IActionResult> addstudent([FromBody] Student model)
        {
            var id = await _studentrepository.AddStudentAsync(model);
            return CreatedAtAction(nameof(getstudentbyid), new { id = id, Controller = "Student" }, id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> updatestudent([FromRoute] int id, [FromBody] Student model)
        {
            await _studentrepository.UpdateStudentAsync(id, model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deletestudent([FromRoute] int id)
        {
            await _studentrepository.DeleteStudentAsync(id);
            return Ok();
        }
    }
}
