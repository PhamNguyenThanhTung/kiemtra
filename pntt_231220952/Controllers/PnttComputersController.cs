using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pntt_231220952.Models;

namespace pntt_231220952.Controllers
{
    public class PnttComputersController : Controller
    {
        private readonly pnttDBContext _context;

        public PnttComputersController(pnttDBContext context)
        {
            _context = context;
        }

        // GET: PnttComputers
        public async Task<IActionResult> pnttIndex()
        {
            return View(await _context.pnttComputers.ToListAsync());
        }

        // GET: PnttComputers/Details/5
        public async Task<IActionResult> pnttDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pnttComputer = await _context.pnttComputers
                .FirstOrDefaultAsync(m => m.PnttComId == id);
            if (pnttComputer == null)
            {
                return NotFound();
            }

            return View(pnttComputer);
        }

        // GET: PnttComputers/Create
        public IActionResult pnttCreate()
        {
            return View();
        }

        // POST: PnttComputers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> pnttCreate([Bind("PnttComId,PnttComName,PnttComPrice,PnttComImage,PnttComStatus")] PnttComputer pnttComputer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pnttComputer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pnttComputer);
        }

        // GET: PnttComputers/Edit/5
        public async Task<IActionResult> pnttEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pnttComputer = await _context.pnttComputers.FindAsync(id);
            if (pnttComputer == null)
            {
                return NotFound();
            }
            return View(pnttComputer);
        }

        // POST: PnttComputers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> pnttEdit(int id, [Bind("PnttComId,PnttComName,PnttComPrice,PnttComImage,PnttComStatus")] PnttComputer pnttComputer)
        {
            if (id != pnttComputer.PnttComId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pnttComputer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PnttComputerExists(pnttComputer.PnttComId))
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
            return View(pnttComputer);
        }

        // GET: PnttComputers/Delete/5
        public async Task<IActionResult> pnttDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pnttComputer = await _context.pnttComputers
                .FirstOrDefaultAsync(m => m.PnttComId == id);
            if (pnttComputer == null)
            {
                return NotFound();
            }

            return View(pnttComputer);
        }

        // POST: PnttComputers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> pnttDeleteConfirmed(int id)
        {
            var pnttComputer = await _context.pnttComputers.FindAsync(id);
            if (pnttComputer != null)
            {
                _context.pnttComputers.Remove(pnttComputer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PnttComputerExists(int id)
        {
            return _context.pnttComputers.Any(e => e.PnttComId == id);
        }
    }
}
