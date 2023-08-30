using System.ComponentModel.DataAnnotations;
namespace Marlabs_LoginService.Model
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}
