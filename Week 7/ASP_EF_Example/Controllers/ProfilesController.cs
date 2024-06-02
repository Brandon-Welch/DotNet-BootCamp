using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProfilesController(AppDbContext context)
        {
            _context = context;
        }

        //Get All Profiles
        [HttpGet]
        public ActionResult<IEnumerable<ProfileDTO>> GetProfiles()
        {
            var profiles = _context.Profiles
                .Include(p => p.User)
                .Select(p => new ProfileDTO
                {
                    Bio = p.Bio,
                    UserId = p.User.UserId
                }).ToList();

            return profiles;
        }

        //Get Profile by Id
        [HttpGet("{ProfileId}")]
        public ActionResult<ProfileDTO> GetProfileById(int ProfileId)
        {
            var profile = _context.Profiles.Find(ProfileId);
            var profileDto = new ProfileDTO{
                Bio = profile.Bio,
                UserId = profile.UserId
            };
            return profileDto;
        }
        
        //Add Profile    
        [HttpPost]
        public ActionResult<ProfileDTO> PostProfile(ProfileDTO profileDto)
        {

            var user = _context.Users.Find(profileDto.UserId);
            var NewProfile = new Profile
            {
                Bio = profileDto.Bio,
                UserId = profileDto.UserId,
                User = user
            };

            _context.Profiles.Add(NewProfile);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProfiles), new { ProfileId = NewProfile.ProfileId }, profileDto);
        }

        //Update Profile
        [HttpPut("{ProfileId}")]
        public ActionResult<ProfileDTO> UpdateProfile(int ProfileId, ProfileDTO UpdatedProfile)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.ProfileId == ProfileId);

            profile.Bio = UpdatedProfile.Bio;

            _context.Profiles.Update(profile);
            _context.SaveChanges();

            return Ok(UpdatedProfile);
        }

        //Delete Profile
        [HttpDelete("{ProfileId}")]
        public IActionResult DeleteProfile(int ProfileId)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.ProfileId == ProfileId);
            _context.Profiles.Remove(profile);
            _context.SaveChanges();

            return Ok();
        }
    }
}
