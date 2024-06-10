using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Services
{
    /*
        The service class implements the IUserService interface.
        This means that all the declared methods in the interface must have some kind of implementation inside the service class.

        We are also using dependency injection to have access to the database context.

        Most of the core methods inside the service will just be moving the operations that were happening inside the controller endpoints into the service methods.

        Additional validations and checks are added to improve the stability of your application, such as:
        - Validating if the new data is in the right format.
        - Handling cases where an ID is provided for a user that doesn't exist.
        - Incorporating null checks in your service layer.
    */
    public class ProfileService : IProfileService
    {
        private readonly AppDbContext _context;

        // Constructor to inject the database context
        public ProfileService(AppDbContext context)
        {
            _context = context;
        }

        // Method to create a new profile based on the provided ProfileDTO
        public Profile CreateProfile(ProfileDTO ProfileDto)
        {
            if (ValidateNewProfile (ProfileDto))
            {
                var user = _context.Users.Find(ProfileDto.UserId);
                var profile = new Profile
                {
                    Bio = ProfileDto.Bio,
                    UserId = ProfileDto.UserId,
                    User = user,
                };

                _context.Profiles.Add(profile);
                _context.SaveChanges();

                return profile;
            }
            else
            {
                throw new Exception("Invalid Profile");
            }
        }  

        // Method to get a list of all profiles
        public IEnumerable<ProfileDTO> GetAllProfiles()
        {
            var profiles = _context.Profiles
            .Include(p => p.User)
            .Select(p => new ProfileDTO
            {
                Bio = p.Bio,
                UserId = p.User.UserId,
            }).ToList();

            return profiles;
        }

        // Method to get a specific profile by their ID
        public ProfileDTO GetProfileById(int ProfileId)
        {
            var profile = _context.Profiles.Find(ProfileId);
                if (profile != null)
                {
                    var profileDto = new ProfileDTO
                    {
                        Bio = profile.Bio,
                        UserId = profile.UserId
                    };

                    return profileDto;
                }
                else
                {
                    throw new Exception("Profile not found");
                }
        }

        // Method to update an existing [rofile] based on their ID and the provided updated ProfileDTO
        public void UpdateProfile(int ProfileId, ProfileDTO UpdatedProfile)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.ProfileId == ProfileId);

            if (profile != null)
            {
                profile.Bio = UpdatedProfile.Bio;

                _context.Profiles.Update(profile);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Profile not found");
            }
        }

        // Method to delete a profile based on their ID
        public void DeleteProfile(int ProfileId)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.ProfileId == ProfileId);

            if (profile != null)
            {
                _context.Profiles.Remove(profile);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Profile not found");
            }
        }

        // Private Helper method to validate the new profile data
        private bool ValidateNewProfile(ProfileDTO ProfileDto)
        {
            return !string.IsNullOrWhiteSpace(ProfileDto.Bio);
        }

    }
}
