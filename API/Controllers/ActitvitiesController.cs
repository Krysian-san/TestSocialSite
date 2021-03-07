using System.Collections.Generic;
using Domain;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Controllers
{
    public class ActitvitiesController : BaseApiContoller
    {

        private readonly DataContext _contetx;
        public ActitvitiesController(DataContext context)
        {
            _contetx = context;
        }        

        [HttpGet]

        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _contetx.Activities.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _contetx.Activities.FindAsync(id);
        }
    }
}