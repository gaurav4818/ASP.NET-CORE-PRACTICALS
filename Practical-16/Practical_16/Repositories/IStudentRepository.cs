using Practical_16.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_16.Contracts
{
    public interface IStudentRepository
    {
        Task<Student> GetAsync(int? id);
        Task<List<Student>> GetAllAsync();
        Task<Student> AddAsync(Student entity);

        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(Student entity);
    }
}
