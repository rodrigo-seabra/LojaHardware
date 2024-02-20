using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LojaDeHardware.Models;

namespace LojaDeHardware.Controllers
{
    public class MeioPagamentoController : Controller
    {
        private readonly Contexto _context;

        public MeioPagamentoController(Contexto context)
        {
            _context = context;
        }

        // GET: MeioPagamento
        public async Task<IActionResult> Index()
        {
              return _context.MeioPagamento != null ? 
                          View(await _context.MeioPagamento.ToListAsync()) :
                          Problem("Entity set 'Contexto.MeioPagamento'  is null.");
        }

        // GET: MeioPagamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MeioPagamento == null)
            {
                return NotFound();
            }

            var meioPagamento = await _context.MeioPagamento
                .FirstOrDefaultAsync(m => m.MeioPagamentoId == id);
            if (meioPagamento == null)
            {
                return NotFound();
            }

            return View(meioPagamento);
        }

        // GET: MeioPagamento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MeioPagamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MeioPagamentoId,MeioPagamentoTipo")] MeioPagamento meioPagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meioPagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meioPagamento);
        }

        // GET: MeioPagamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MeioPagamento == null)
            {
                return NotFound();
            }

            var meioPagamento = await _context.MeioPagamento.FindAsync(id);
            if (meioPagamento == null)
            {
                return NotFound();
            }
            return View(meioPagamento);
        }

        // POST: MeioPagamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MeioPagamentoId,MeioPagamentoTipo")] MeioPagamento meioPagamento)
        {
            if (id != meioPagamento.MeioPagamentoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meioPagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeioPagamentoExists(meioPagamento.MeioPagamentoId))
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
            return View(meioPagamento);
        }

        // GET: MeioPagamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MeioPagamento == null)
            {
                return NotFound();
            }

            var meioPagamento = await _context.MeioPagamento
                .FirstOrDefaultAsync(m => m.MeioPagamentoId == id);
            if (meioPagamento == null)
            {
                return NotFound();
            }

            return View(meioPagamento);
        }

        // POST: MeioPagamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MeioPagamento == null)
            {
                return Problem("Entity set 'Contexto.MeioPagamento'  is null.");
            }
            var meioPagamento = await _context.MeioPagamento.FindAsync(id);
            if (meioPagamento != null)
            {
                _context.MeioPagamento.Remove(meioPagamento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeioPagamentoExists(int id)
        {
          return (_context.MeioPagamento?.Any(e => e.MeioPagamentoId == id)).GetValueOrDefault();
        }
    }
}
