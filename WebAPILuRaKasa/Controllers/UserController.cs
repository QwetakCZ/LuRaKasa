using DTOLuRaKasa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPILuRaKasa.Data;

namespace WebAPILuRaKasa.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public UserController(ApplicationDBContext context)
        {
            _context = context;
        }


        [HttpGet(Name = "GetAllUsers")]
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
