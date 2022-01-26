using Microsoft.AspNetCore.Mvc;
using Student_Management.Interface;
using Student_Management.Service.Repository;

namespace Student_Management.Controllers
{
    public class StudentController : Controller
    {
        private readonly IRepository _repository;
        public StudentController(IRepository  repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var listStudent = _repository.GetAll();
            return View(listStudent);
        }
    }
}
