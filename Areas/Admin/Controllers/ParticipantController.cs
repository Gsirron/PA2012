using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prototype.Areas.Admin.Models;
using Prototype.Areas.Identity.Data;
using Prototype.Models;

namespace Prototype.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ParticipantController : Controller

    {
        private readonly PrototypeContext _context;

        public ParticipantController(PrototypeContext context)
        {
            _context = context;
        }
        // GET: Participant

        public async Task<IActionResult> ListUsers(int? phase)
        {
            ViewData["Title"] = "Viewing All Participants";

            var participants = from m in _context.Participant
                               select m;
            if(phase == 1)
            {
                ViewData["Title"] = "Viewing All P1 Participants";
                participants = participants.Where(s => s.Participant_Phase == 1);
            }

            else if(phase == 2)
            {
                ViewData["Title"] = "Viewing All P2 Participants";
                participants = participants.Where(s => s.Participant_Phase == 2);
            }
            else if(phase == 3)
            {
                ViewData["Title"] = "Viewing All P2-A Participants";
                participants = participants.Where(s => s.Participant_Phase == 2 && s.Participant_Group == "A");
            }
            else if(phase == 4)
            {
                ViewData["Title"] = "Viewing All P2-B Participants";
                participants = participants.Where(s => s.Participant_Phase == 2 && s.Participant_Group == "B");
            }

            return View(await participants.ToListAsync());
        }
        
        public async Task <IActionResult> ListP1Users()
        {
            return RedirectToAction("ListUsers", new { phase = 1 });
        }

        public async Task<IActionResult> ListP2Users()
        {
            return RedirectToAction("ListUsers", new { phase = 2 });
        }

        public async Task<IActionResult> ListP2AUsers()
        {
            return RedirectToAction("ListUsers", new { phase = 3 });
        }

        public async Task<IActionResult> ListP2BUsers()
        {
            return RedirectToAction("ListUsers", new { phase = 4 });
        }


        public async Task<IActionResult> ListP2Usersz()
        {
            var participants = from m in _context.Participant
                               select m;

            participants = participants.Where(s => s.Participant_Phase == 2);

            return View("ListUsers", await participants.ToListAsync());
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Participant/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participant
                .FirstOrDefaultAsync(m => m.ParticipantId == id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        // GET: Participant/Create
        
        public IActionResult Create()
        {
            return View();
        }

        // POST: Participant/Create
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(ListUsers));
            }
            catch
            {
                return View();
            }
        }

        // GET: Participant/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participant
                .FirstOrDefaultAsync(m => m.ParticipantId == id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        // POST: Participant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Participant participant)
        {
            if (id != participant.ParticipantId)
            {
                return NotFound();
            }
            var participant2 = await _context.Participant.FindAsync(id);

            if (ModelState.IsValid)
            {
                participant2.Participant_Email = participant.Participant_Email;
                participant2.Participant_Group = participant.Participant_Group;
                participant2.Participant_Phase = participant.Participant_Phase;
                participant2.Participant_ResponseId = participant.Participant_ResponseId;

                try
                {
                    _context.Update(participant2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParticipantExists(participant.ParticipantId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));

            }
            return View(participant2);
        }
        // GET: Participant/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participant
                .FirstOrDefaultAsync(m => m.ParticipantId == id);
            if(participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        // POST: Participant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var participant = await _context.Participant.FindAsync(id);
            

            try
            {
                _context.Participant.Remove(participant);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private bool ParticipantExists(int id)
        {
                return _context.Participant.Any(e => e.ParticipantId == id);
        }
    }
}