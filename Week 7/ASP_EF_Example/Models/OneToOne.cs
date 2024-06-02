namespace EFCoreExample.Models
{
    //EF requires us to create entitites
    //These entities are essential class based representations of our data in XXXXXXXXX //TODO: check Brians notes for last part
    
    //This file holds our one to one relationships
    //It does not need to all be in the same file
    //This is done as another way to organize your code, it is all in the same namespace so it doesnt matter what files they are in
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        // This establishes a one-to-one relationship to the other class Entitiy (Profile class)
        //User is connected to one Profile, and a Profile is conencted to one User
        //A User can exist without a Profile, but a Profile cannot exist without a User
        public Profile Profile { get; set; }
    }

    public class Profile
    {
        public int ProfileId { get; set; }
        public string Bio { get; set; }
        //As Profile class contains the foreigh key for user, we need to provide a field for the key inside the Profile class (UserID)
        public int UserId { get; set; }
        //This establishes a one-to-one relationship to the other entitity by creating a dependency within it
        public User User { get; set; }
    }
}
