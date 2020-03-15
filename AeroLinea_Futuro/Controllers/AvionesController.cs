using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AeroLinea_Futuro.Models;

namespace AeroLinea_Futuro.Controllers
{
    public class AvionesController : Controller
    {
        private readonly AvionesContext _context;

        public AvionesController(AvionesContext context)
        {
            _context = context;
        }

        // GET: Aviones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aviones.ToListAsync());
        }

        // GET: Aviones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aviones = await _context.Aviones
                .FirstOrDefaultAsync(m => m.AvionID == id);
            if (aviones == null)
            {
                return NotFound();
            }

            return View(aviones);
        }

        // GET: Aviones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aviones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AvionID,Fabricante,Modelo,Capacidad")] Aviones aviones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aviones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aviones);
        }

        // GET: Aviones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aviones = await _context.Aviones.FindAsync(id);
            if (aviones == null)
            {
                return NotFound();
            }
            return View(aviones);
        }

        // POST: Aviones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AvionID,Fabricante,Modelo,Capacidad")] Aviones aviones)
        {
            if (id != aviones.AvionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aviones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvionesExists(aviones.AvionID))
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
            return View(aviones);
        }

        // GET: Aviones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aviones = await _context.Aviones
                .FirstOrDefaultAsync(m => m.AvionID == id);
            if (aviones == null)
            {
                return NotFound();
            }

            return View(aviones);
        }

        // POST: Aviones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aviones = await _context.Aviones.FindAsync(id);
            _context.Aviones.Remove(aviones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AvionesExists(int id)
        {
            return _context.Aviones.Any(e => e.AvionID == id);
        }
    }
}
