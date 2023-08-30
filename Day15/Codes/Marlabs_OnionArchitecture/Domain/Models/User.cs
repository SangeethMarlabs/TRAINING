namespace Domain.Models
{
    public class User : BaseEntity
    {

        public string UserNmae { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserProfile UserProfile { get; set; } // foreign key
    }
}
