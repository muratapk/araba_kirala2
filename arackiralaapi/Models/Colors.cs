using System.ComponentModel.DataAnnotations;

namespace arabakiralaapi.Models
{
    public class Colors
    {
        [Key]
        public int ColorID { get; set; }
        public string ColorName { get; set; } = string.Empty;
        
    }
}
