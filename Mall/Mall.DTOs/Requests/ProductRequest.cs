using Mall.Commons.Enums;
using MayNghien.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.DTOs.Requests
{
    public class ProductRequest : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Address Address { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
