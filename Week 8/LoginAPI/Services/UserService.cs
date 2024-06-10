using LoginAPI.Data;

namespace LoginAPI.Services;

public class UserService: IUserService
{
    private readonly AppDbContext _context;
    public UserService(AppDbContext context)
    {
        
    }
}