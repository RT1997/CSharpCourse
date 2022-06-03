using System;
using PATA = ProjectA.TeamA;

namespace IntroToCSharp
{
    class Program
    {
        static void Main()
        {
            Program p = new Program(); //In case of no constructor for the clas => Default parameterless constructor by dotnet

            //STATIC METHODS
            //Basics();
            //Coffee(); //Hover to see XML Documentation

            //INSTANCE METHODS
            //p.Loop(); 
            //p.ForLoop(20);

            //ParamsLesson();
            //Namespaces();
            //ClassesAndObjects();
            //Inheritance();
            //Polymorphism();
            //MethodOverloading();

        }


        ///<summary>
        ///This is a Sample Method for XML Documentation Comments
        ///Coffee Billing Method
        /// </summary>
        public static void Coffee()
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
        public static void Basics()
        {
            Console.WriteLine("Name:");
            string Name1 = Console.ReadLine();
            Console.WriteLine("Hello " + Name1); //CONCAT
            Console.WriteLine("Hello {0},{0}", Name1); //PLACE HOLDER

            //------------------------------

            Console.WriteLine(int.MinValue);

            //--------------------------------------  

            string Name = "\"\\\bAarthi\"\nOne\rTwo";
            string path = "D:\\Dev\\Courses";
            string verbatimpath = @"D:\Dev\Courses";
            Console.WriteLine(Name);
            Console.WriteLine(path);
            Console.WriteLine(verbatimpath);

            //-----------------------------------------

            int? i = null; //? (For Optional Value Fields)
            string j = null; //String is a reference Type . Hence Nullable

            bool? IsMajor = null;
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
            Console.WriteLine(k);

            //--------------------------------------------------

            int ii = int.Parse(Console.ReadLine());
            Console.WriteLine(ii);

            float Result;
            bool b = float.TryParse(Console.ReadLine(), out Result);
            Console.WriteLine(Result);
            Console.WriteLine(b);

            //-------------------------------------------------------------

            int[] EvenNumbers = new int[3];
            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;
            Console.WriteLine(EvenNumbers[1]);
        }
        public void Loop()
        {
            string choice = "";
            do
            {


                Console.WriteLine("Please enter target:");
                int t = int.Parse(Console.ReadLine());
                int i = 1;
                while (i <= t)
                {
                    Console.WriteLine(i);
                    i++;
                }

                do
                {
                    Console.WriteLine("Do you want to Continue? - Yes or No");
                    choice = Console.ReadLine().ToUpper();
                    if (choice != "YES" && choice != "NO")
                    {
                        Console.Write("Please enter valid choice.");
                    }
                } while (choice != "YES" && choice != "NO");
            } while (choice == "YES");
        }
        public void ForLoop(int target)
        {
            int[] nums = new int[3];
            nums[0] = 1;
            nums[2] = 3;
            nums[1] = 2;
            int i = 0;
            for (i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            foreach (int k in nums)
            {
                Console.WriteLine(k);
            }
            for (int l = 0; l < target; l++)
            {
                if (l % 2 != 0) continue;
                Console.WriteLine(l);

            }
            for (int p = 0; p < target; p++)
            {
                Console.WriteLine(p);
                if (p == 10) break;
            }
        }
        public static void ParamsLesson()
        {
            int i = 0;
            ValueParams(i); //Pass by value
            Console.WriteLine(i);
            RefParamas(ref i);
            Console.WriteLine(i);
            int sum = 0;
            int product = 0;
            Calc(10, 20, out sum, out product);
            Console.WriteLine("{0},{1}", sum, product);
            int[] nums = new int[3] { 1, 2, 3 };
            paramsArray(nums);
        }
        public static void ValueParams(int j)
        {
            j = 101;

        }
        public static void RefParamas(ref int j)
        {
            j = 101;
        }
        public static void Calc(int i, int j, out int sum, out int product)
        {
            sum = i + j;
            product = i * j;
        }
        public static void paramsArray(params int[] nums)
        {
            Console.WriteLine(nums.Length);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
        public static void Namespaces()
        {
            PATA.classA.Print();
            ProjectA.TeamB.classA.Print();
        }
        public static void ClassesAndObjects()
        {
            Customer c1 = new Customer("Aarthi", "Padmagirisan");
            c1.Print();
            Customer c2 = new Customer();
            c2.Print();
            //-------------------------------------------------
            Console.WriteLine("Starting...");
            Circle circle1 = new Circle(5);
            Console.WriteLine("Object 1 initiated...");
            float area1 = circle1.CalArea();
            Console.WriteLine(area1);
            Circle circle2 = new Circle(6);
            Console.WriteLine("Object 2 initiated...");
            float area2 = circle2.CalArea();
            Console.WriteLine(area2);
        }
        public static void Inheritance()
        {
            FullTimeEmp ft = new FullTimeEmp(1000000);
            ft.FirstName = "Varun";
            ft.LastName = "Appaswami";
            ft.GetDetails();
            PartTimeEmp pt = new PartTimeEmp(50);
            pt.FirstName = "Aarthi";
            pt.LastName = "Padmagirisan";
            pt.GetDetails();
            ((Employee)pt).GetDetails();
            
        }
        public static void Polymorphism()
        {

            Student[] students = new Student[4];

            students[0] = new Student();
            students[1] = new FullTimeStudent();
            students[2] = new PartTimeStudent();
            students[3] = new ExchangeStudent();
            foreach (Student s in students)
            {
                s.GetPersonal();
            }
            BaseClass b1 = new DerivedClass();
            b1.printer();
            DerivedClass d1 = new DerivedClass();
            d1.printer();
            BaseClass b2 = new BaseClass();
            b2.printer();
            DerivedClass d2 = new DerivedClass();
            ((BaseClass)d2).printer();


        }
        public static void MethodOverloading()
        {
            Add();
            Add(2, 3);
            Add(6.7F, 9.567F);
            Add(5, 6, 7);
            Add(5, 6,out int x);
            Console.WriteLine(x);

        }
        public static void Add()
        {
            Console.WriteLine("Hello from Add");
        }
        public static void Add(int x, int y)
        {
            Console.WriteLine("Int Add");
            Console.WriteLine(x + y);
        }
        public static void Add(int x, int y, int z)
        {
            Console.WriteLine("3 INts add");
            Console.WriteLine(x + y + z);
        }
        public static void Add(float x, float y)
        {
            Console.WriteLine("Float ADD");
            Console.WriteLine(x + y);
        }
        public static void Add(int x, int y, out int z)
        {
            z = x + y;
            Console.WriteLine(z);
        }
    } 
    public class BaseClass
    {
        public virtual void printer()
        {
            Console.WriteLine("This is base class print method");
        }
    }
    public class DerivedClass : BaseClass
    {
        //public new void printer()
        //{
        //    Console.WriteLine("This is derived class print method hiding never called with base class reference variable");
        //}
        public override void printer()
        {
            Console.WriteLine("This is derived class print method OVERRIDING");
        }
    }
    public class Student
    {
        public string FirstName = "Aarthi";
        public string LastName = "Padmagirisan";
        public int age = 24;
        public Student()
        {
            //string fn,string ln,int age
            //FirstName = fn;
            //LastName = ln;
            //this.age = age;
        }
        public virtual void GetPersonal()
        {
            Console.WriteLine(FirstName + " " + LastName+", " + age + " years");
        }
    }
    public class PartTimeStudent : Student
    {
        public PartTimeStudent() 
        {

        }
       
        public override void GetPersonal()
        {
            Console.WriteLine(FirstName + " " + LastName + ", " + age + " years" + " - Part Time");
        }
    }
    public class FullTimeStudent : Student
    {
        public FullTimeStudent()
        {

        }
        public override void GetPersonal()
        {
            Console.WriteLine(FirstName + " " + LastName + ", " + age + " years" + " - Full Time");
        }
        //public void GetFT()
        //{
        //    Console.WriteLine("Hello");
        //}
    }
    public class ExchangeStudent : Student
    {
        public ExchangeStudent()
        {

        }
        public override void GetPersonal()
        {
            Console.WriteLine(FirstName + " " + LastName + ", " + age + " years" + " - Exchange");
        }
    }
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public Employee(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        } 

        public void GetDetails()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
            
        }
    }
    public class FullTimeEmp : Employee{
        public float yearlySalary;

        public FullTimeEmp(float ys): base("Aarthi", "Padmagirisan")
        {
            yearlySalary = ys;
        }
    }
    class PartTimeEmp : Employee
    {
        public float hourlySalary;

        public PartTimeEmp(int hr) : base("Aarthi", "Padmagirisan")
        {
            hourlySalary = hr;
        }
        public new void GetDetails()
        {
            //base.GetDetails();
            Console.WriteLine("{0} {1} - Contractor", FirstName, LastName);
            Console.WriteLine("Yearly Salary :" + hourlySalary * 8 * 4*51);
        }
    }
    class Customer
    {
        string _firstName;
        string _lastName;
        public Customer() : this("First","Last") { } //implementation for parameterless constructor that invokes parametered one with default arguments
        public Customer(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName; 
        }
        public void Print()
        {
            Console.WriteLine("{0} {1}", _firstName, _lastName);
        }
        ~Customer() { //Destructor to clean up code
        }


    }
    class Circle
    {
        static float _PI;
        int _Radius;
        //Static constructor
        static Circle()
        {
            Console.WriteLine("Static constructor called...");
            _PI = 3.141F;
        }
        //Instance constructor
        public Circle(int Raidus)
        {
            Console.WriteLine("Instance constructor called...");
            this._Radius = Raidus;
        } 
        public float CalArea()
        {
            return _PI * _Radius * this._Radius;
        }
    }
}
namespace ProjectA
{
    namespace TeamA
    {
        class classA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print method");
            }
        }
    }
    namespace TeamB
    {
        class classA
        {
            public static void Print()
            {
                Console.WriteLine("Team B  Print method");
            }
        }
    }

}
