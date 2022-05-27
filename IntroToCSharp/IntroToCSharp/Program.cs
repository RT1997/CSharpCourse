using System;

namespace IntroToCSharp
{
    class Program
    {
        static void Main()
        {
            /*Console.WriteLine("Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name); //CONCAT
            Console.WriteLine("Hello {0},{0}", Name); //PLACE HOLDER*/

            //------------------------------

            //Console.WriteLine(int.MinValue);

            //--------------------------------------  

            /*string Name = "\"\\\bAarthi\"\nOne\rTwo";
            string path = "D:\\Dev\\Courses";
            string verbatimpath = @"D:\Dev\Courses";
            Console.WriteLine(Name);
            Console.WriteLine(path);
            Console.WriteLine(verbatimpath);*/

            //-----------------------------------------

            //int? i = null; //? (For Optional Value Fields)
            //string j = null; //String is a reference Type . Hence Nullable

            /*bool? IsMajor = null;
            if (IsMajor == true) Console.WriteLine("True");
            else if (IsMajor == false) Console.WriteLine("False");
            else if (!IsMajor.HasValue) Console.WriteLine("Null"); // true
            else if (IsMajor == null) Console.WriteLine("Also Null"); //skips when prev. statement there //aslo true
            else Console.WriteLine("Uhhhh..." + IsMajor.HasValue);
            i = 100;
            int k;
            if (i == null) k = 0;
            else k = (int)i;
            Console.WriteLine(k); //These many Lines can be replaced with the following null Coalescent Operator

            // ----
            k = i ?? 0;
            Console.WriteLine(k);*/

            //--------------------------------------------------

            /*int i = int.Parse(Console.ReadLine());
            Console.WriteLine(i);

            float Result;
            bool b = float.TryParse(Console.ReadLine(), out Result);
            Console.WriteLine(Result);
            Console.WriteLine(b);*/

            //-------------------------------------------------------------

            /*int[] EvenNumbers = new int[3];
            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;
            Console.WriteLine(EvenNumbers[1]);*/

            // --------------------------------------------------------------
            //Coffee(); //Hover to see XML Documentation
        }
        ///<summary>
        ///This is a Sample Method for XML Documentation Comments
        ///Coffee Billing Method
        /// </summary>
        static void Coffee()
        {
            int TotalCost = 0;
            Start:
            Console.WriteLine("Please select size of Coffee : 1 - Small, 2 - Medium, 3 - Large");
            int coffeeSize = int.Parse(Console.ReadLine());
            
            switch (coffeeSize)
            {
                case 1:
                    TotalCost += 1;
                    break;
                case 2:
                    TotalCost += 2;
                    break;
                case 3:
                    TotalCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid.", coffeeSize);
                    goto Start;

            
            }
            Decide:
            Console.WriteLine("Do you want to continue shopping? Yes or No");
            switch (Console.ReadLine().ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    goto Decide;
            
            }
            Console.WriteLine("Thankyou for shopping with us.Your Total Bill Amount is {0}", TotalCost);
        }
    }

}
