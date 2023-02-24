using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext context;

        public UsersController(DataContext context)
        {
            this.context = context;
        }

    [HttpGet]
    public  async Task< ActionResult<IEnumerable<Appuser>>> GetUsers()
    {
        var users = await context.Users.ToListAsync();
        return users;
    }

[HttpGet("{id}")]
public  async Task<ActionResult<Appuser>> GetUser(int id)
    {
        var user = await context.Users.FindAsync(id);
        return user;
    }
       
    }
}