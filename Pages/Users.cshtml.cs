using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using GraduateProjectDemo.Models;
using GraduateProjectDemo.Services;

namespace GraduateProjectDemo.Pages;

[Authorize(Policy="MyPollicy0")]
public class UsersModel : PageModel
{
    public List<UserModel> Users { get; set; }
    private readonly ILogger<PrivacyModel> _logger;
    private readonly IUserService _userService;

    public UsersModel(ILogger<PrivacyModel> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    
    public void OnGet()
    {
        Users = _userService.GetUsers();
    }
}