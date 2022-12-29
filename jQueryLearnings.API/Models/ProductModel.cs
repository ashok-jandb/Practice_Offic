using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jQueryLearnings.API.Models
{
    [Table("ProductModel", Schema = "SalesLT")]
    public class ProductModel
    {
        public int ProductModelId { get; set; }
        public string Name { get; set; }
    }
}
