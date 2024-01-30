using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joshy_api.Models
{
    public class Products
    {
        private enum ProductCategories
        {
            HealthCare,
            LifeStyle,
            Beauty,
            Gifts,
            Perfume_scents,
            SkinCare
        }
        public Guid Id{get; set;}
        public required string ProductName{get; set;}
        [Column(TypeName = "decimal(7, 2)")]
        public int Price{get; set;}

    }
}