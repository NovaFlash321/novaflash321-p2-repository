using Microsoft.AspNetCore.Mvc;
using JAConsoleBL;
using JAModel;
using Microsoft.Extensions.Caching.Memory;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IJABL _bl;

        public ItemController(IJABL bl)
        {
            _bl = bl;

        
        }

        


        [HttpGet("GetUsers")]
        public async Task<List<users>> GetAllUsersAsync()
        {
            return await _bl.GetAllUsersAsync(); 
        }

        [HttpGet("SearchUser/{username}")]
        public async Task<List<users>> SearchUser(string username)
        {
            return await _bl.SearchUsers(username);
        }


        [HttpGet("GetAdmins")]
        public async Task<List<UserPass>> GetAllAdminsAsync()
        {
            return await _bl.GetAllAdminsAsync();
        }



        [HttpPost("CreateNewUser")]
        public async Task CreateNewUserAsync(UserPass _tempUser)
        {
            await _bl.CreateNewUserAsync(_tempUser);
        }

        [HttpPost("CreateNewAdmin")]
        public async Task CreateNewAdminAsync(UserPass _admin)
        {
            await _bl.CreateNewAdminAsync(_admin);
        }
    }

    
}
