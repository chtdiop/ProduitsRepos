using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_Catalogue_Produits.Service;

namespace Project_Catalogue_Produits.Controllers
{
    public class ProduitController : Controller
    {
       public IProduitService metier { get; set; }
        public ProduitController(IProduitService metier)
        {
            this.metier = metier;
        }
        public IActionResult Index()
        {

            IEnumerable<Produit> Prods = metier.FindAll();
            ViewBag.produits = Prods;
            return View("Produits", Prods);
        }

        public IActionResult chercher(string motcle)
        {
            
            if (motcle==null)
            {
                ModelState.AddModelError("motcle", "il faut saisir le mot clé");
            }
            if (ModelState.IsValid)
            {
                IEnumerable<Produit> Prods = metier.ProduitParMc(motcle);
               // ViewBag.produits = Prods;
                ViewBag.motcle = motcle;
                return View("Produits", Prods);
            }
           ViewBag.produits = metier.FindAll();
            return View("Produits", metier.FindAll());
        }

        public IActionResult FormProduit()
        {
            Produit produit = new Produit();
            
            return View(produit);
        }
        [HttpPost]
        public IActionResult SaveProduit(Produit p)
        {
            if (ModelState.IsValid)
            {
                metier.Save(p);
                ViewBag.produits = metier.FindAll();
                return View("Produits", metier.FindAll());
            }
            return View("FormProduit");
        }
       [HttpGet]
        public IActionResult Delete(int id)
        {
            metier.Delete(id);
           // ViewBag.produits = metier.FindAll();
            return RedirectToAction("Index", ViewBag.produits);
           
        }

        public IActionResult Edit(int id)
        {
            Produit p = metier.GetOne(id);
            
            // ViewBag.produits = metier.FindAll();
            return View(p);

        }

        public IActionResult Update(Produit p)
        {
            metier.Update(p);

            ViewBag.produits = metier.FindAll();
            return View("Produits", ViewBag.produits);

        }
    }
}