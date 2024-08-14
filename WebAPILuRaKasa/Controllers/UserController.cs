using DTOLuRaKasa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPILuRaKasa.Data;
using Microsoft.AspNetCore.Identity;



namespace WebAPILuRaKasa.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDBContext _context;

        public UserController(ApplicationDBContext context, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
            _signInManager = signInManager;
        }
        [HttpGet("Ahoj")]
        public string GetAhoj()
        {
            return "Ahoj z WebAPI";
        }

        [HttpGet("Login")]
        public async Task<string> Login(string username, string password)
        {
            
            var user = await _userManager.FindByNameAsync(username);
            if (user == null) { return "Uzivatel nenalezen"; }

            var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

            if (result.Succeeded)
                return user.Id;
            else
                return "Spatne zadane heslo";


            
           
        }
       

        [HttpGet("AllUsers")]
        public List<UserDTO> GetAllUsers()
        {
            var users = new List<UserDTO>();

            users = _context.AspNetUsers.Select(u => new UserDTO
            {
                id = u.Id,
                name = u.UserName,
                email = u.Email
            }).ToList();
           
         

            return users;
        }
    }
}
