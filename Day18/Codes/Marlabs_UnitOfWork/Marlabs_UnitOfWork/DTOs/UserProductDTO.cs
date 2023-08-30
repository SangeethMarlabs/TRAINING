using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_UnitOfWork.DTOs
{
    public class UserProductDTO
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserContactNo { get; set; }
        public string UserAddress { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDesc { get; set; }
    }
}
