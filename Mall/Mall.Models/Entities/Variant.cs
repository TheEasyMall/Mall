using MayNghien.Infrastructure.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Models.Entities
{
    public class Variant : BaseEntity
    {
        public string? Type { get; set; }
        public double Price { get; set; }

        [ForeignKey("Product")]
        public Guid? ProductId { get; set; }
        public Product? Product { get; set; }

        public ICollection<Cart>? Carts { get; set; }
    }
}
