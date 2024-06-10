using EFCoreExample.DTOs;
using EFCoreExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        /*
            We do not want to have the context object (database object) inside the controller.
            Instead, we will be using a service class to manage all of our database interactions and anything else that we need to do,
                - For example, converting objects from DTOs to entities and vice versa.
                - Input validation/data validation can be done here as well.

            Just like how we used the dependency container to manage our database context object, we will be using the container to manage the dependency injection for our services.

            The main thing you need to do is first create the interface and the classes for the services you will use.
            Then you need to add it to the Program.cs configurations.

            /// Program.cs
                ...
                builder.Services.AddScoped<IUserService, UserService>();
                ...
            ///

            Then you need to create a field inside the classes that you want to use the service, typically setting it as a private readonly field.

            In the constructor for the class, use the interface as the parameter for the field you wish to add.
        */

        // Private readonly field for the user service
        private readonly IUserService _userService;

        // Constructor to inject the user service
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: /Users
        // Action method to handle GET requests to retrieve all users
        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        // GET: /Users/{UserId}
        // Action method to handle GET requests to retrieve a user by their ID
        [HttpGet("{UserId}")]
        public ActionResult<UserDTO> GetUserById(int UserId)
        {
            var user = _userService.GetUserById(UserId);
            return user;
        }

        // POST: /Users
        // Action method to handle POST requests to create a new user
        [HttpPost]
        public ActionResult<UserDTO> PostUser(UserDTO userDto)
        {
            var user = _userService.CreateUser(userDto);
            return CreatedAtAction(nameof(GetUserById), new { UserId = user.UserId }, userDto);
        }

        // PUT: /Users/{UserId}
        // Action method to handle PUT requests to update an existing user
        [HttpPut("{UserId}")]
        public ActionResult<UserDTO> UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            _userService.UpdateUser(UserId, UpdatedUser);
            return Ok(UpdatedUser);
        }

        // DELETE: /Users/{UserId}
        // Action method to handle DELETE requests to delete a user by their ID
        [HttpDelete("{UserId}")]
        public IActionResult DeleteUser(int UserId)
        {
            _userService.DeleteUser(UserId);
            return Ok();
        }
    }
}
