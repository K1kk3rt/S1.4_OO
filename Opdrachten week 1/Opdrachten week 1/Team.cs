using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenA
{
    class Team
    {
        int aantalProgrammeurs = 4;
        List<Programmeur> programmeurs = new List<Programmeur>();

        //Zet toegevoegde programmeurs uit main in list
        public void AddProgrammeur(Programmeur p)
        {
            for(int i = 0; i < aantalProgrammeurs; i++)
            {
                programmeurs[0] = p;
            }
        }

        //Print list
        public void PrintAlleTeamLeden()
        {
            for (int i = 0; i < 4; i++)
            {
                programmeurs[i].Print(programmeurs[i]);
            }
        }


    }
}
