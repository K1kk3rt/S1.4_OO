using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtenA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Voeg programmeurs toe aan het team
            Team team = new Team();
            team.AddProgrammeur(new Programmeur("Jip", Specialiteit.PHP));
            team.AddProgrammeur(new Programmeur("Janneke", Specialiteit.Java));
            team.AddProgrammeur(new Programmeur("Else", Specialiteit.Csharp));
            team.AddProgrammeur(new Programmeur("Henk", Specialiteit.HTML));

            team.PrintAlleTeamLeden();


            Console.ReadKey();
        }
    }
}
