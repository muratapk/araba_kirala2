using System.ComponentModel.DataAnnotations;

namespace araba_kirala.Models
{
    public class Brands
    {
        [Key]
        public int BrandID { get; set; }
        [Required(ErrorMessage="Marka İsmini Boş Bırakmazsınız")]
        [StringLength(10,ErrorMessage ="10 Karakter Olmalı")]
        public string BrandName { get; set; } = string.Empty;
        [Required(ErrorMessage ="Boş Bırakılmaz")]
        public string Model { get; set; } = string.Empty;
        public int? ModelYear { get; set; } 
        public int? DailyPrice { get; set; }
        virtual public ICollection<Cars>? Cars { get; set; }
        //bir aracın birden fazla Markası olabilir

    }
}
