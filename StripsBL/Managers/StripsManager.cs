using StripsBL.DTOs;
using StripsBL.Exceptions;
using StripsBL.Interfaces;
using StripsBL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StripsBL.Model;

namespace StripsBL.Managers
{
    public class StripsManager
    {
        private IStripsRepository stripsRepository;

        public StripsManager(IStripsRepository stripsRepository)
        {
            this.stripsRepository = stripsRepository;
        }

        public List<Strip> GeefStripsReeks(int reeksId)
        {
            try
            {
                return stripsRepository.GeefStripsReeks(reeksId);
            }
            catch (Exception ex) { throw new Exception("GeefStripsReeks", ex); }
        }

        public Reeks GetReeks(int reeksId) 
        {
            try
            {
                return stripsRepository.GetReeks(reeksId);
            }
            catch (Exception ex) { throw new Exception("GetReeks", ex); }
        }


    }
}
