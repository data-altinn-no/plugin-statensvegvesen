using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altinn.Dan.Plugin.Statensvegvesen.Models
{
    public class Verksted
    {
        public string organisasjonsnr { get; set; }
        public int godkjenningsnr { get; set; }
        public string navn { get; set; }
        public string avdelingsnavn { get; set; }
        public string besoksAdresse { get; set; }
        public string besoksPostnummer { get; set; }
        public string besoksPoststed { get; set; }
        public object internettadresse { get; set; }
        public string kundetelefon { get; set; }
        public string tilgjengelighet { get; set; }
        public List<Godkjenninger> godkjenninger { get; set; }
        public object responskode { get; set; }
    }

    public class Godkjenninger
    {
        public string godkjenningsType { get; set; }
        public bool mobileTjenester { get; set; }
    }



}
