using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectGuestBookProj
{
    internal class Program
    {
        static void Main(string[] args)
        {


            GuestLogic.WelcomeMessage();

            var (partyGroupNames, totalGuests) = GuestLogic.GetAllGuests();

            GuestLogic.PrintTotalGuestAndSize(partyGroupNames, totalGuests);

            Console.ReadLine();

        }


    }
}
