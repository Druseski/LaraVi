using LaraViEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaraVi.Models
{
    public class ProductViewModel
    {
             
        public string Name { get; set; }
       
        public DateTime BestBefore { get; set; }

        public DateTime DateManifactured { get; set; }

        public double Price { get; set; }
       
        public string Manifacturer { get; set; }
       
        public string Discription { get; set; }

        public int UserID { get; set; }

        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        public Category Category { get; set; }

        public string Shipping { get; set; }

        public string PhotoURL { get; set; }

        public int SoldItems { get; set; }

        public double Rating { get; set; }

        public DateTime DateAdded { get; set; }

        public string CountryOfOrigin { get; set; }

        public bool Popularity { get; set; }

        public bool ByWeight { get; set; }

        public bool ByPeace { get; set; }

        public string CategoryNameDTO { get; set; }
    }
}
