using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaxWorkout.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MaxWorkout.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {

        private static List<UserDTO> listUsers = new List<UserDTO>() {
            new UserDTO()
            {
                Name = "Jose",
                Email = "jmelero08@gmail.com",
                Password = "Password123",
                Gender = "Male",
                Weight = 220,
                Height = 71,
                BenchMax = 200,
                DeadliftMax = 315,
                SquatMax = 315
            },
            new UserDTO()
            {
                Name = "Jasmine",
                Email = "jtsomething@gmail.com",
                Password = "Bella123",
                Gender = "Female",
                Weight = 150,
                Height = 60,
                BenchMax = 100,
                DeadliftMax = 135,
                SquatMax = 150
            },
        };

        [HttpGet]
        public IActionResult GetUsers()
        {
            if(listUsers.Count > 0)
            {
                return Ok(listUsers);
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetUsers(int id)
        {
            if (id >= 0 && id < listUsers.Count)
            {
                return Ok(listUsers[id]);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddUser(UserDTO user)
        {
            listUsers.Add(user);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, UserDTO user)
        {
            if (id >= 0 && id < listUsers.Count)
            {
                listUsers[id] = user;
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (id >= 0 && id < listUsers.Count)
            {
                listUsers.RemoveAt(id);
            }

            return NoContent();
        }


    }
}

