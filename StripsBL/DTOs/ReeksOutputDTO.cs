using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StripsBL.Model;

namespace StripsBL.DTOs
{
    public class ReeksOutputDTO
    {
        public ReeksOutputDTO()
        {
                
        }

        public ReeksOutputDTO(int id, string naam, string url, List<StripOutputDTO> strips)
        {
            ID = id;
            Naam = naam;
            Url = url;
            Strips = strips;
        }
        public int ID { get; set; }
        public string Naam { get; set; }
        public string Url { get; set; }
        public List<StripOutputDTO> Strips { get; set; } = new List<StripOutputDTO>();
    }
}
