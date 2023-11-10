using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsClientWPFReeksView.Model
{
    public class ReeksOutputUI
    {
        public int id { get; set; }
        public string naam { get; set; }
        public List<StripOutputUI> strips { get; set; } = new List<StripOutputUI>();
    }
}
