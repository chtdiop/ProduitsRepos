using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Catalogue_Produits.Service
{
    public class ProduitServiceImpl : IProduitService
    {
        public ProduitsDbContext dbcontext { get; set; }
       // public Dictionary<int, Produit> produits = new Dictionary<int, Produit>();

        public ProduitServiceImpl(ProduitsDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
            Save(new Produit { Designation="HP 654", Prix=7000});
            Save(new Produit { Designation = "Imp Epson", Prix = 450 });
            Save(new Produit { Designation = "Ord LX 540", Prix = 6500 });
        }
        public void Delete(int id)
        {
            Produit produit = dbcontext.Produits.FirstOrDefault(p => p.ProduitID == id);
            dbcontext.Produits.Remove(produit);
            dbcontext.SaveChanges();
        }

        public IEnumerable<Produit> FindAll()
        {
            return dbcontext.Produits.ToList();
        }

        public Produit GetOne(int id)
        {
            //Produit p;
            //  produits.TryGetValue(id, out p);
            //  return p;
            return dbcontext.Produits.FirstOrDefault(p => p.ProduitID == id);
        }

        public IEnumerable<Produit> ProduitParMc(string mc)
        {
            // List<Produit> Prods = new List<Produit>();
            // foreach(var p in produits.Values)
            // {
            //  if (p.Designation.Contains(mc))
            //  {
            //     Prods.Add(p);
            // }
            //}
            return dbcontext.Produits.ToList().Where(p=>p.Designation.Contains(mc)) ;
         //  return  produits.Values.Where(p=>p.Designation.Contains(mc));
        }

        public Produit Save(Produit p)
        {

            // p.ProduitID = produits.Count + 1;
            // produits[p.ProduitID] = p;

            //  return p;
            dbcontext.Produits.Add(p);
            dbcontext.SaveChanges();
            return p;
        }
        
        public void Update(Produit p)
        {
            //  produits[p.ProduitID] = p;
            dbcontext.Produits.Update(p);
            dbcontext.SaveChanges();
            
        }
    }
}
