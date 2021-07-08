using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using xlabapi.Data;
using xlabapi.Model;

namespace xlabapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class XlabAPIController : ControllerBase
    {

        private readonly XlabContext _context;

        private readonly ILogger<XlabAPIController> _logger;

        public XlabAPIController(ILogger<XlabAPIController> logger, XlabContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Leedsbeerquest>>> Get()
        {
            return await _context.Leedsbeerquests.ToListAsync();
        }
    }
}
