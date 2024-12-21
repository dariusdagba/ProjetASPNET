using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetEcommerce.Data;
using ProjetEcommerce.Models;

namespace ProjetEcommerce.Controllers
{
    public class LigneCommandesController : Controller
    {
        private readonly ProjetEcommerceContext _context;

        public LigneCommandesController(ProjetEcommerceContext context)
        {
            _context = context;
        }

        // GET: LigneCommandes
        public async Task<IActionResult> Index()
        {
            return View(await _context.LigneCommandes.ToListAsync());
        }

        // GET: LigneCommandes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ligneCommande = await _context.LigneCommandes
                .FirstOrDefaultAsync(m => m.LigneCommandeId == id);
            if (ligneCommande == null)
            {
                return NotFound();
            }

            return View(ligneCommande);
        }

        // GET: LigneCommandes/Create
        public IActionResult Create()
        {
            ViewBag.Produits = new SelectList(_context.Produits, "ProduitId", "ProduitNom");
            ViewBag.Commandes = new SelectList(_context.Commandes, "CommandeId", "DateCommande");
            return View();
        }

        // POST: LigneCommandes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("LigneCommandeId,CommandeId,ProduitId,Quantite")] LigneCommande ligneCommande)
        {
            Console.WriteLine("Entering Create POST method");

            if (ModelState.IsValid)
            {
                try
                {
                _context.Add(ligneCommande);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("ModelState is not valid");
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    { Console.WriteLine(error.ErrorMessage); }
                }
            }
            ViewBag.Produits = new SelectList(_context.Produits, "ProduitId", "ProduitNom",ligneCommande.ProduitId);
            ViewBag.Commandes = new SelectList(_context.Commandes, "CommandeId", "DateCommande",ligneCommande.CommandeId);
            return View(ligneCommande);
        }

        // GET: LigneCommandes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ligneCommande = await _context.LigneCommandes.FindAsync(id);
            if (ligneCommande == null)
            {
                return NotFound();
            }
            ViewBag.Produits = new SelectList(_context.Produits, "ProduitId", "ProduitNom", ligneCommande.ProduitId);
            ViewBag.Commandes = new SelectList(_context.Commandes, "CommandeId", "DateCommande", ligneCommande.CommandeId);
            return View(ligneCommande);
        }

        // POST: LigneCommandes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LigneCommandeId,CommandeId,ProduitId,Quantite")] LigneCommande ligneCommande)
        {
            if (id != ligneCommande.LigneCommandeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ligneCommande);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LigneCommandeExists(ligneCommande.LigneCommandeId))
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
            ViewBag.Produits = new SelectList(_context.Produits, "ProduitId", "ProduitNom", ligneCommande.ProduitId);
            ViewBag.Commandes = new SelectList(_context.Commandes, "CommandeId", "DateCommande", ligneCommande.CommandeId);
            return View(ligneCommande);
        }

        // GET: LigneCommandes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ligneCommande = await _context.LigneCommandes
                .FirstOrDefaultAsync(m => m.LigneCommandeId == id);
            if (ligneCommande == null)
            {
                return NotFound();
            }

            return View(ligneCommande);
        }

        // POST: LigneCommandes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ligneCommande = await _context.LigneCommandes.FindAsync(id);
            if (ligneCommande != null)
            {
                _context.LigneCommandes.Remove(ligneCommande);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LigneCommandeExists(int id)
        {
            return _context.LigneCommandes.Any(e => e.LigneCommandeId == id);
        }
    }
}
