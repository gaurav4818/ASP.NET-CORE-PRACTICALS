using Microsoft.EntityFrameworkCore;
using Practical_17.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_17.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _context;
        public StudentRepository(StudentContext context)
        {
            _context = context;

        }
        public async Task<int> AddStudentAsync(Student st)
        {
            _context.Students.Add(st);
            await _context.SaveChangesAsync();

            return st.Id;
        }

        public async Task DeleteStudentAsync(int id)
        {
            var s = await _context.Students.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (s != null)
            {
                _context.Students.Remove(s);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Student>> GetAllStudentAsync()
        {
            var students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task<Student> GetStudentByIDAsync(int id)
        {
            var s = await _context.Students.Where(x => x.Id == id).FirstOrDefaultAsync();
            return s;
        }

        public async Task UpdateStudentAsync(int id, Student st)
        {
            var s = await _context.Students.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (s != null)
            {
                s.Id = id;
                s.Name = st.Name;
                s.Age = st.Age;
               
                await _context.SaveChangesAsync();
            }
        }
       
    }
}
