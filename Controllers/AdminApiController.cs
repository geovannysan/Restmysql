using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Filesistem.Data.Models;

namespace Filesistem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminApiController : ControllerBase
    {
        
        private readonly Data.DataContext _dbcontext;
        public AdminApiController(Data.DataContext logger){
            _dbcontext = logger;
        }

        [HttpGet]
        [Route("Lsita")]
        public IActionResult Get(){
            List<Admin> admin = new List<Admin>();
            try
            {
                admin = _dbcontext.admin.ToList();
                
                return StatusCode(StatusCodes.Status200OK, new { mesaje = "ok", response = admin });
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

    }
}