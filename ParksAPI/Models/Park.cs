using System.ComponentModel.DataAnnotations;

namespace ParksAPI.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [Required]
        [StringLength(30)]
        public string ParkName { get; set; }
        [Required]
        public string ParkLocation { get; set; }
        public string Description { get; set; }

    }
}
