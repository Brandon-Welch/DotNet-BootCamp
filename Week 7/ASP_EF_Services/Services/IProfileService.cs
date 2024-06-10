using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Services
{
    /*
        We use an interface because the Dependency Injection (DI) container prefers having the most generic version of the dependency to work with.
        The DI container will look for any instances of this interface and use the provided implementation to inject it where it is needed.

        An interface is a contract for a class. It lays out the required methods that any class must implement if it chooses to use the interface.
    */
    public interface IProfileService
    {
        // Method to get a list of all profiles
        IEnumerable<ProfileDTO> GetAllProfiles();

        // Method to get a specific profile by their ID
        ProfileDTO GetProfileById(int ProfileId);

        // Method to create a new profile based on the provided ProfileDTO
        Profile CreateProfile(ProfileDTO ProfileDto);

        // Method to update an existing profile based on their ID and the provided updated ProfileDTO
        void UpdateProfile(int ProfileId, ProfileDTO UpdatedProfile);

        // Method to delete a profile based on their ID
        void DeleteProfile(int ProfileId);
    }
}
