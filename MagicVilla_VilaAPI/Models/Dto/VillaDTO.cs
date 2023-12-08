using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VilaAPI.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
