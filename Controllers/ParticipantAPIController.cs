using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prototype.Areas.Admin.Models;
using Prototype.Models;


namespace Prototype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantAPIController : ControllerBase
    {

        private readonly PrototypeContext _context;

        public ParticipantAPIController(PrototypeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Participant>>> GetParticipant()
        {
            return await _context.Participant.ToListAsync();
        }

       

        /*  public async Task<ActionResult<IEnumerable<Participant>>> AddParticipantResponse(String email)
         {
              if (String.IsNullOrEmpty(email))
              {
                  return BadRequest();
              }

              //var Participant =await _context.Participant.FindAsync(email);

             // if 

              return

          }*/
    }


    }