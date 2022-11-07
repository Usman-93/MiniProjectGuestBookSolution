using System;
using System.Collections.Generic;

namespace MiniProjectGuestBookProj
{
    public static class GuestLogic
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("*******************************");
            Console.WriteLine();
        }

        private static string GetPartyName()
        {
            Console.Write("What is your party/group name: ");
            string partyName = Console.ReadLine();
            return partyName;
        }
        private static int GetPartySize()
        {
            int partySize = 0;
            bool isValidNumber = false;

            do
            {
                Console.WriteLine("How many people are coming with you in the party?");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out partySize);

                if (isValidNumber == false)
                {
                    Console.WriteLine("Incorrect number given. Please try again.");
                }

            }
            while (isValidNumber == false);

            return partySize;
        }

        public static (List<string> partyGroupNames, int totalGuests) GetAllGuests()
        {
            
            List<string> partyGroupNames = new List<string>();
            int totalGuests = 0;

            string isContinue = "";

            do
            {
                partyGroupNames.Add(GuestLogic.GetPartyName());
                totalGuests += GuestLogic.GetPartySize();

                Console.Write("Do you want to continue bringing in more Groups to the Party (yes/no): ");
                isContinue = Console.ReadLine();

            }
            while (isContinue.ToLower() == "yes");

            return (partyGroupNames, totalGuests);
        }

        public static void PrintTotalGuestAndSize(List<string> partyGroupNames, int totalGuests)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Following Groups came to the party.");
            foreach (string partyGroupName in partyGroupNames)
            {
                Console.WriteLine(partyGroupName);

            }

            Console.WriteLine($"There were total {totalGuests} guests in the party");
        }

    }
}
