using StripsBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.DTOs
{
    public class ReeksInputDTO
    {
        public ReeksInputDTO(string naam)
        {
            Naam = naam;
        }
        public ReeksInputDTO(int iD, string naam)
        {
            ID = iD;
            Naam = naam;
        }
        public int ID { get; set; }
        public string Naam { get; set; }
        public List<Strip> Strips { get; set; } = new List<Strip>();
    }
}
