using System.ComponentModel.DataAnnotations;

namespace araba_kirala.Models
{
    public class Colors
    {
        [Key]
        public int ColorID { get; set; }
        public string ColorName { get; set; } = string.Empty;
        virtual public List<Cars>? Cars { get; set; }
    }
}
