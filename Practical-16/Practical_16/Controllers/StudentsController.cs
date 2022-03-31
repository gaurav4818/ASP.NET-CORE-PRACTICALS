using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practical_16.Contracts;
using Practical_16.Data;

namespace Practical_16.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
       
        private readonly IStudentRepository _student;

        public StudentsController(IStudentRepository student)
        {
            _student = student;
        }
       

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var student = await _student.GetAllAsync();
            return View(student);
        }
        [Authorize(Roles = "Student,User")]

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _student.GetAsync(id);
                
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        [Authorize(Roles="User")]

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DOB,Age")] Student student)
        {
            if (ModelState.IsValid)
            {
                await _student.AddAsync(student);
              
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
        [Authorize(Roles = "User")]
        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _student.GetAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DOB,Age")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   await _student.UpdateAsync(student);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _student.Exists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
        [Authorize(Roles = "User")]

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _student.GetAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _student.DeleteAsync(id);
           
            return RedirectToAction(nameof(Index));
        }

  
    }
}
