using MayNghien.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.DTOs.Requests
{
    public class CategoryRequest : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPresent { get; set; }
    }
}
