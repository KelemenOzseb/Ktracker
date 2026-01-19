using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using Data.Repository;

namespace KTrack.Controllers
{
    public class UserController : ControllerBase
    {
        UserManager<User> userManager;
        Repository<User> userRepository;
    }
}
