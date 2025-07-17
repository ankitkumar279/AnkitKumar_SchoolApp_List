using AnkitKumar_SchoolApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnkitKumar_SchoolApp.Controllers
{
    public class TeacherPageController : Controller
    {
        private readonly SchoolDbContext _context;

        public TeacherPageController(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> List()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return View(teachers);
        }

        public async Task<IActionResult> Show(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }
    }
}
