using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    public class KaartSpel
    {
        //fields
        public int aantalSpelers;
        List<SpeelKaart> AlleSpeelKaarten = new List<SpeelKaart>()
             

    }

    public class SpeelKaart : KaartSpel
    {
        //fields
        public int nummer;
    }

    public enum KaartType
    {
        Schoppen, Klaveren, Harten, Ruiten
    }
}
