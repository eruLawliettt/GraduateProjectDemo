using Microsoft.AspNetCore.Identity;
using GraduateProjectDemo.Models;

namespace GraduateProjectDemo.Services;

public interface IUserService
{
    List<UserModel> GetUsers();
}