using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net.Http.Headers;

namespace EFCoreExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //This AppDbContext is used to interact with our database
        //The constructror is used by our dependency manager to injectinto our class
        //We doi not have to instantiate the controller or provide the app db context into the constructor
        //This is managed by the Dependency Inbjection Container in program.cs (line 14/15)
        private readonly AppDbContext _context; //_differentiates from the constructor made below

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        //Get All Users
        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetUsers()
        {
            var users = _context.Users //This would return all the users from the Users DB Table
                .Select(u => new UserDTO
                {
                    UserId = u.UserId,
                    Name = u.Name,
                }).ToList();

            return users;
        }

        //Get User by Id
        [HttpGet("{UserId}")]
        public ActionResult<UserDTO> GetUserById(int UserId)
        {
            var user = _context.Users.Find(UserId);
            var userDto = new UserDTO{
                Name = user.Name,
                UserId = user.UserId
            };
            return userDto;
        }

        //Add User
        [HttpPost]
        public ActionResult<UserDTO> PostUser(UserDTO userDto)
        {
            var user = new User
            {
                Name = userDto.Name,
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            //return Ok(userDto);
            //return CreatedAtAction(nameof(GetUserById), new { id = user.UserId }, userDto); //FIXME: we commented this from example due to a Swagger 500 error tring to post User
            return CreatedAtAction(nameof(GetUserById), new { UserId = user.UserId }, userDto); //just userID and Name
            //return CreatedAtAction(nameof(GetUserById), new { UserId = user.UserId }, user); //returns full profile also
        }

        //Update User
        [HttpPut("{UserId}")]
        public ActionResult<UserDTO> UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);

            user.Name = UpdatedUser.Name;

            _context.Users.Update(user);
            _context.SaveChanges();

            return Ok(UpdatedUser);
        }

        //Delete User
        [HttpDelete("{UserId}")]
        public IActionResult DeleteUser(int UserId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            _context.Users.Remove(user);
            _context.SaveChanges();

            return Ok();
        }
    }
}
