

class Program
{
    public static void Main (string[] args)
    {

        bool backTop = true;

        while(backTop)
        {
            //gather user input for number of people
            Console.WriteLine("How many people are we making PB and J sandwiches for?");

            // store int
            int numPeople = int.Parse(Console.ReadLine());

            // ingredients --> make calculations

            int slicesOfBread = numPeople * 2;

            int tbPB = numPeople * 2;

            int tbJelly = numPeople * 4;

            // bulk items --> make calculations

            double loafesOfBread = Math.Ceiling((double)slicesOfBread / 28.00);

            double jarsOfPB = Math.Ceiling((double)tbPB / 32.00);

            double jarsOfJelly = Math.Ceiling((double)tbJelly / 48.00);

            //print results of whats needed

            Console.WriteLine("You need:\n\n" +
                slicesOfBread + " slices of bread\n" +
                tbPB + " table spoons of peanut butter\n" +
                tbJelly + " table spoons of jelly\n\n" +
                "Which is: \n" +
                loafesOfBread + " Loaves of bread\n" +
                jarsOfPB + " Jars of Peanut Butter\n" +
                jarsOfJelly + " Jars of Jelly\n");

            //ask user if they want to end program
            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
            string response = Console.ReadLine();

            if (response == "yes" || response == "y")
            {
                backTop = true;
            }
            else
            {
                Console.WriteLine("\n\nGoodbye!");
                backTop = false;
            }
        }
        backTop = false;
        
    }
}