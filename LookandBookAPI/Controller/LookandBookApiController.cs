using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LookandBookAPI.Models;
using LookandBookAPI.Data;

namespace LookandBookAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookandBookApiController : ControllerBase
    {
        private readonly ApiContext _context;

        public LookandBookApiController(ApiContext context)
        {
            _context = context;
        }
    }
}
