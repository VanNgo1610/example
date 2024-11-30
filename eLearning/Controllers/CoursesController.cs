using eLearning.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace eLearning.Controllers
{
    public class CoursesController : Controller
    {
        private readonly List<CoursesModel> _courses = new List<CoursesModel>
        {
            new CoursesModel { Id = 1, Name = "C# for Beginners", Category = "Programming", Level = "Beginner", Price = 99.99, Description = "Learn the basics of C#." },
            new CoursesModel { Id = 2, Name = "Advanced JavaScript", Category = "Programming", Level = "Advanced", Price = 149.99, Description = "Deep dive into JavaScript." },
            new CoursesModel { Id = 3, Name = "UI/UX Design", Category = "Design", Level = "Intermediate", Price = 79.99, Description = "Master UI/UX principles." },
            new CoursesModel { Id = 4, Name = "Data Science with Python", Category = "Data Science", Level = "Intermediate", Price = 199.99, Description = "Learn data analysis and visualization." },
        };

        public IActionResult Index(string searchTerm, string category, string level, double? minPrice, double? maxPrice)
        {
            // search and filter courses
            var filteredCourses = _courses.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                filteredCourses = filteredCourses.Where(c => c.Name.Contains(searchTerm, System.StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(category))
            {
                filteredCourses = filteredCourses.Where(c => c.Category.Equals(category, System.StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(level))
            {
                filteredCourses = filteredCourses.Where(c => c.Level.Equals(level, System.StringComparison.OrdinalIgnoreCase));
            }

            if (minPrice.HasValue)
            {
                filteredCourses = filteredCourses.Where(c => c.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                filteredCourses = filteredCourses.Where(c => c.Price <= maxPrice.Value);
            }

            return View(filteredCourses.ToList());
        }
    }
}
