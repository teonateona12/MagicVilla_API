using MagicVilla_VilaAPI.Models.Dto;
using System.Reflection.Metadata.Ecma335;

namespace MagicVilla_VilaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO { Id = 1, Name = "Pool View" },
            new VillaDTO { Id = 2, Name = "Beach View" }
        };
    }
}
     