using System.Net.Mail;
using StripsBL.DTOs;
using StripsBL.Managers;
using StripsBL.Model;

namespace StripsREST.Mappers
{
    public class MapFromDomain
    {
        public static ReeksOutputDTO MapFromReeksDomain(string url, Reeks reeks, StripsManager stripsManager)
        {
            try
            {
                string reeksURL = $"{url}/Reeks/{reeks.ID}";

                List<StripOutputDTO> strips = stripsManager.GeefStripsReeks(reeks.ID).Select(x => new StripOutputDTO(x.ID, x.Titel, x.Nr, url + $"/strip/{x.ID}")).ToList();


                ReeksOutputDTO dto = new ReeksOutputDTO(reeks.ID, reeks.Naam, reeksURL, strips);
                return dto;
            }

            catch (Exception ex) { throw new Exception("MapFromReeksDomain", ex); }
        }
    }
}
