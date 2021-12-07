using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataSample.Models;
using System;
using System.Collections.Generic;

namespace ODataSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [EnableQuery]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return Ok(new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Muhammadkarim To'xtaboyev",
                    Grade = 120
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Javohir Buzrukoaav",
                    Grade = 100
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Samandar Uralov",
                    Grade = 200
                }
            });
        }
    }
}
