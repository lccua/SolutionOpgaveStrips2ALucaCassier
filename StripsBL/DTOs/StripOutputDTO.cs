using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.DTOs
{
    public class StripOutputDTO
    {
        public StripOutputDTO(int id, string titel, int? nr, string url)
        {
            ID = id;
            Titel = titel;
            Nr = nr;
            Url = url;
        }

        public int ID { get; set; }
        public string Titel { get; set; }
        public int? Nr { get; set; }
        public string Url {  get; set; }
    }
}
