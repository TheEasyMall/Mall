using Mall.Commons.Enums;
using MayNghien.Infrastructure.Models.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Models.Entities
{
    public class Tenant : BaseEntity
    {
        public string Name { get; set; }
        public TenantTypes Type { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Category>? Categories { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<Staff>? Staff { get; set; }
    }
}
