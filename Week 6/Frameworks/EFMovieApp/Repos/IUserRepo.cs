/*
    Coding to Interfaces - practice wherein we will start these "classes" that are functionality focused (REpos, Services, Controllers, etc)
        We Will opt to Outline their Functionality through an Interface, first.

    The Overall Goal is to promote Flexibility/Reusability.
        If we ever need to change implementations, you can simply create a new class that implements the SAME interface thereby letting us know
                it will service all the same INTENTIONS.
    


*/
using Microsoft.Identity.Client;

interface IUserRepo
{
    public void AddUser (User u); //abstract method
    public User? GetUser(int id);
    public List<User> GetAllUsers();
    public void UpdateUser(User u);
    public void DeleteUser(int id);
    public void Save();

}