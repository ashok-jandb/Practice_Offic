using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jQueryLearnings.API.Models
{
    [Table("ProductCategory", Schema = "SalesLT")]
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
    }
}
