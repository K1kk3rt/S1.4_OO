using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    struct PersoonStruct
    {
        public string naam;
        public int leeftijd;

        public PersoonStruct (string naam, int leeftijd)
        {
            this.naam = naam;
            this.leeftijd = leeftijd;
        }
    }
}
