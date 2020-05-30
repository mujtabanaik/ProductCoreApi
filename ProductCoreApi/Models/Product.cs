using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCoreApi.Models
{
    [Table("Product", Schema = "dbo")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public float mrc { get; set; }
        public float nrc { get; set; }
        public float discount { get; set; }
        public string createdBy { get; set; }
        public DateTime creadtedDate { get; set; } = DateTime.UtcNow;
    }
}
