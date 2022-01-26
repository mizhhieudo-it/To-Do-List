using Student_Management.Interface;
using Student_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Management.Service.Repository
{
    public class StudentRepository : IRepository
    {
        public HashSet<Student> DataSource { get; set; } = new HashSet<Student> {   
            new Student { Id = 1, Name ="Nguyen Van a",BirthDay= DateTime.ParseExact("22/11/2009", "dd/MM/yyyy", null),Code="18210123321"},
            new Student { Id = 2, Name ="Nguyen Van b",BirthDay= DateTime.ParseExact("22/11/2009", "dd/MM/yyyy", null),Code="18210123321"},
            new Student { Id = 3, Name ="Nguyen Van c",BirthDay= DateTime.ParseExact("22/11/2009", "dd/MM/yyyy", null),Code="18210123321"},
            new Student { Id = 4, Name ="Nguyen Van d",BirthDay= DateTime.ParseExact("22/11/2009", "dd/MM/yyyy", null),Code="18210123321"},
        };

        public List<Student> GetAll()
        {
            return DataSource.ToList();
        }

        public Student GetByID(int id)
        {
            return DataSource.SingleOrDefault(x => x.Id == id);
        }
    }
}
