using Marlabs_UnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_UnitOfWork.DTOs
{
    public class UserProductListDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserContactNo { get; set; }
        public string UserAddress { get; set; }
        public List<ProductDTO> lstProduct { get; set; }
    }
}
