using Microsoft.EntityFrameworkCore;
using Practical_16.Contracts;
using Practical_16.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_16.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbcontext;

        public StudentRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<Student> AddAsync(Student entity)
        {
            await _dbcontext.AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            _dbcontext.Set<Student>().Remove(entity);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _dbcontext.Set<Student>().ToListAsync();
        }

        public async Task<Student> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await _dbcontext.Set<Student>().FindAsync(id);
        }

        public async Task UpdateAsync(Student entity)
        {
            _dbcontext.Update(entity);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
