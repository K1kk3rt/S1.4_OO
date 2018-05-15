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
        List<SpeelKaart> alleSpeelKaarten = new List<SpeelKaart>();

        //constructor
        public KaartSpel(int aantalSpelers)
        {
            this.aantalSpelers = aantalSpelers;
        }

        private void InitialiseerKaarten()
        {
            for(int i = 0; i < 53; i++)
            {
                SpeelKaart speelKaart = new SpeelKaart();
                alleSpeelKaarten.Add(speelKaart.MaakSpeelKaart(speelKaart, i));
            }
        }

        public void Print()
        {
            int count = 0;
            do
            {
                InitialiseerKaarten();
                alleSpeelKaarten.Add(new SpeelKaart(""));
                count++;
            }
            while (count < aantalSpelers);
            

            for (int i = 0; i < alleSpeelKaarten.Count; i++)
            {
                Console.WriteLine(alleSpeelKaarten[i].kaartType + " " + alleSpeelKaarten[i].nummer);
            }
        }

    }

    public class SpeelKaart
    {
        //fields
        public string nummer;
        public KaartType? kaartType = null;

        //constructor for empty list slot
        public SpeelKaart(string nummer)
        {
            this.nummer = nummer;
            this.kaartType = null;
        }

        public SpeelKaart()
        {

        }

        public SpeelKaart MaakSpeelKaart(SpeelKaart speelKaart, int i)
        {
                if (i <= 12)
                {
                    int nummer = i + 2;
                    speelKaart.kaartType = (KaartType)0;
                    speelKaart.nummer = String(nummer);
                }
                if (12 < i && i <= 26)
                {
                    int nummer = i - 12;
                    speelKaart.kaartType = (KaartType)1;
                    speelKaart.nummer = String(nummer);
                }
                if (26 < i && i <= 39)
                {
                    int nummer = i - 25;
                    speelKaart.kaartType = (KaartType)2;
                    speelKaart.nummer = String(nummer);
                }
                if (39 < i && i <= 53)
                {
                    int nummer = i - 38;
                    speelKaart.kaartType = (KaartType)3;
                    speelKaart.nummer = String(nummer);
                }

            return speelKaart;
        }
        string String(int nummer)
        {
            string s = "";

            if (nummer == 11)
            {
                s = "Boer";
                return s;
            }
            if (nummer == 12)
            {
                s = "Vrouw";
                return s;
            }
            if (nummer == 13)
            {
                s = "Heer";
                return s;
            }
            if (nummer == 14)
            {
                s = "Aas";
                return s;
            }

            s = nummer.ToString();
            return s;


        }
    }

    

    public enum KaartType
    {
        Schoppen, Klaveren, Harten, Ruiten
    }
}
