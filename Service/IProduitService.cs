using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Catalogue_Produits.Service
{
   public interface IProduitService
    {
        Produit Save(Produit p);
        IEnumerable<Produit> FindAll();
        IEnumerable<Produit> ProduitParMc(string mc);
        Produit GetOne(int id);
        void Update(Produit p);
        void Delete(int id);
    }
}
