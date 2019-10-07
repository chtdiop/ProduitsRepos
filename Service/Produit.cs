using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Catalogue_Produits.Service
{
    [Table("Produits")]
    public class Produit
    {
        
        [Display(Name="ID Produit")]
        public int ProduitID { get; set; }
        [Required]
        [MinLength(6), MaxLength(25)]
        public string Designation { get; set; }
        [Required]
        [Range(200, 5000)]
        public int Prix { get; set; }

    }
}
