namespace LoginAPI.DTOs;

/*
    DTO is what you expect to receive from the client and what you expect ot return ot the client
    Most of the time you are going to be doing CRUD on your models, but sometimes you client might expect 
        some kinda of data that doesn't map 1-1 to a single model

        Ex: if User wants all their info related to their profile but you have 2 models (login data and profile data)
            you may create a DTO that combines both models
    The service layer is there to connect the 2 together. The DTO (data transfer object) is just there to transfer
        data between the layers of the app
    It is designed to be very flexible, to suit the needs of your application
*/

public class UserDTO
{
    public string Username {get;set;}
    public string Password {get;set;}
    public string Email {get;set;}
}

public class UserLoginDTO
{
    public string Username {get;set;}
    public string Password {get;set;}
}