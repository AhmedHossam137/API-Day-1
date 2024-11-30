using apii_day_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apii_day_1.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/courses")]
    [ApiController]

    public class courseController : ControllerBase
    {
        static List<course> mycourses = new List<course>()
        {
            new course(){id=1 , name="python",duaration="2 weeks"},
            new course(){id=2 , name="c++",duaration="4 weeks"},
            new course(){id=3 , name="database",duaration="3 weeks"},
        };
        [HttpGet]

        public List<course> getall()
        {
            return mycourses;
        }
        //[HttpGet]
        //[Route("api/courses/{id}")]
        // [HttpGet("api/students/{id}")]
        [HttpGet("{name}")]//httpget+"api/students/2"
        public course getbyname(string name)
        {
            return mycourses.Find(n => n.name == name);
        }
       
        
        
        [HttpPost]//httppost+"api/courses"
        public List<course> add(course c)
        {
            mycourses.Add(c);
            return mycourses;
        }








    }
}
