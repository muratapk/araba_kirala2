using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;


namespace araba_kirala.Models
{
    public class Rentals
    {
        [Key]
        public int ID { get; set; }
        public int? CarsID { get; set; }
        public int? UserID { get; set; }
        public string RentDate { get; set; } = string.Empty;
        public string ReturnDate { get; set; } = string.Empty;
        public int ? TotalPrice { get; set; }
        virtual public Users? Users { get; set; }
        //bir kullanıcı sadece bir araç kiralayabilir
        virtual public Cars? Cars { get; set; }

    }
}
