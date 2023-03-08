using GraduateProjectDemo.Models;
using Microsoft.AspNetCore.Identity;

namespace GraduateProjectDemo.Services;

public class UserService : IUserService
{
    private readonly UserManager<IdentityUser> _userManager;
    public List<UserModel> GetUsers()
    {
        List<UserModel> userModels = new();
        foreach(var item in _userManager.Users)
        {
            userModels.Add(new UserModel   
            {
                Nickname = item.UserName,
                Email = item.Email,
                PhoneNumber = item.PhoneNumber
            });
        }
        return userModels;
    }

    public UserService(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }
}