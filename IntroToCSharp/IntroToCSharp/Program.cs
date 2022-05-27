using System;

namespace IntroToCSharp
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Name:");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Hello " + Name); //CONCAT
            //Console.WriteLine("Hello {0},{0}", Name); //PLACE HOLDER

            //------------------------------

            //Console.WriteLine(int.MinValue);

            //--------------------------------------  

            //string Name = "\"\\\bAarthi\"\nOne\rTwo";
            //string path = "D:\\Dev\\Courses";
            //string verbatimpath = @"D:\Dev\Courses";
            //Console.WriteLine(Name);
            //Console.WriteLine(path);
            //Console.WriteLine(verbatimpath);

            //-----------------------------------------

            int? i = null; //? (For Optional Value Fields)
            string j = null; //String is a reference Type . Hence Nullable

            bool? IsMajor = null;
            if (IsMajor == true) Console.WriteLine("True");
            else if (IsMajor == false) Console.WriteLine("False");
            else if (!IsMajor.HasValue) Console.WriteLine("Null"); // true
            else if (IsMajor == null) Console.WriteLine("Also Null"); //skips when prev. statement there //aslo true
            else Console.WriteLine("Uhhhh..." + IsMajor.HasValue);
            //i = 100;
            int k;
            if (i == null) k = 0;
            else k = (int)i;
            Console.WriteLine(k); //These many Lines can be replaced with the following null Coalescent Operator
            k = i ?? 0;
            Console.WriteLine(k);
            //--------------------------------------------------




        }
    }
}
