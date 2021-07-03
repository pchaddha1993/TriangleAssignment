using System;
namespace TriangleAssignment
{
    class Program
    {

        static int userinput;
        static int ValidatemenuSelection()
        {
            bool validMenuSelection = false;
            while (validMenuSelection == false)
            {
                Console.WriteLine("Select the operation which you want to perform from below options.....\n");
                Console.WriteLine("1 = Enter Triangle Dimensions\n");
                Console.WriteLine("2 = Exit\n");
                userinput = Convert.ToInt32(Console.ReadLine()); ;
                if (userinput != 1 && userinput != 2)
                {
                    Console.WriteLine("Invalid menu option, please try again:\n");
                }
                else
                {
                    validMenuSelection = true;
                }
            }

            return userinput;
        }
        static void Main(string[] args)
        {
            int selection = ValidatemenuSelection();
            bool flag = true;
            while (flag == true)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Enter the 3 dimensions of the triangle:\n");
                        Console.WriteLine("Side 1:");
                        int Side_1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Side 2:");
                        int Side_2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Side 3:");
                        int Side_3 = Convert.ToInt32(Console.ReadLine());
                        if ((Side_1 + Side_2 > Side_3) && (Side_2 + Side_3 > Side_1) && (Side_1 + Side_3 > Side_2))
                        {
                            Console.WriteLine("Numbers will form a triangle");
                            string triangleType = TriangleSolver.Analyze(Side_1, Side_2, Side_3);
                            Console.WriteLine("This is {0} triangle", triangleType);
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Numbers will not form a triangle...Re-enter valid values!!");
                        }
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
