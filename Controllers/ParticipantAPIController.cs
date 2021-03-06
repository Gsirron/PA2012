﻿using System;
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



        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSurveyResponse(int id,Participant participant)
        {
            if(id !=participant.ParticipantId)
            {
                return BadRequest();
            }

            _context.Attach(participant);

            _context.Entry(participant).Property("Participant_ResponseId").IsModified = true;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!ParticiapntItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        private bool ParticiapntItemExists(long id)
        {
            return _context.Participant.Any(e => e.ParticipantId == id);
        }
    }


    }