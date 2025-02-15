
using System.ComponentModel.DataAnnotations;

namespace araba_kirala.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }=string.Empty;
        public string Email { get; set; }= string.Empty;
        public string Password { get; set; } = string.Empty;
        virtual public List<Rentals>? Rentals { get; set; }
        //bir kullanıcı birden fazla araç kirayabilir
    }
}
