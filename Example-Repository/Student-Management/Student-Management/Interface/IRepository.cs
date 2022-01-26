using Student_Management.Models;
using System.Collections.Generic;

namespace Student_Management.Interface
{
    public interface IRepository
    {
        public HashSet<Student> DataSource { get; set; }
        public Student GetByID(int id);
        public List<Student> GetAll();
    }
}
