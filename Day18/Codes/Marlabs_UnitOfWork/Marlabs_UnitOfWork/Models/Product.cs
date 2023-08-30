namespace Marlabs_UnitOfWork.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
        public string ProductCategory { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDesc { get; set; }
        public User user { get; set; }
    }
}
