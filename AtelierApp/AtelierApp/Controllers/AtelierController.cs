using Microsoft.AspNetCore.Mvc;
using AtelierApp.Data;
using AtelierApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AtelierApp.Controllers
{
    public class AtelierController : Controller
    {
        private readonly AtelierContext _context;
        public AtelierController(AtelierContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            return View( await _context.Ateliers.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atelier= await _context.Ateliers.FirstOrDefaultAsync(m=>m.Id==id);

            if (atelier == null)
            {
                return NotFound();
            }
            return View(atelier);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Id, Nom, Description, Prix")] Atelier atelier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atelier);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(atelier);
        }

        public async Task<IActionResult> Edit(int? id) 
        {
            if (id == null)
            {
                return NotFound();
            }
            var atelier = await _context.Ateliers.FindAsync(id);
            if (atelier == null) 
            { 
                return NotFound();
            }
            return View(atelier);
        }

        public async Task<IActionResult> Edit(int id, [Bind("Id, Nom, Description, Prix")] Atelier atelier)
        {

            if(id!=atelier.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid) 
            {
                try
                {
                    _context.Update(atelier);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if (!AtelierExists(atelier.Id))
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
            return View(atelier);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atelier = await _context.Ateliers.FirstOrDefaultAsync(m => m.Id == id);

            if (atelier == null)
            {
                return NotFound();
            }
            return View(atelier);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var atelier = await _context.Ateliers.FindAsync(id);
            _context.Ateliers.Remove(atelier);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtelierExists(int id)
        {
            return _context.Ateliers.Any(e=>e.Id==id);
        }




    }
}
