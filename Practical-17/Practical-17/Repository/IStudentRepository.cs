using Practical_17.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_17.Repository
{
   public  interface IStudentRepository
    {
        Task<List<Student>> GetAllStudentAsync();
      
        Task<Student> GetStudentByIDAsync(int id);
 
        Task<int> AddStudentAsync(Student st);
        Task UpdateStudentAsync(int id, Student st);
        Task DeleteStudentAsync(int id);
        
    }
}
