using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWorkLibraryV2;

namespace CourseWorkV2
{
    class CourseWork
    {
        static void Main(string[] args)
        {

            //Variables
            string num;
            int i;

            #region Do while Loop
            //Loop to loop menu
            do
            {
                Console.WriteLine("CourseWork Testing Menu");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1 - Unit Test Category");
                Console.WriteLine("2 - Unit Test Assigment");
                Console.WriteLine("3 - Exit");
                Console.Write("Enter Choice: ");
                num = Console.ReadLine();
                Console.WriteLine("");

                //Parse string to int 
                if (!Int32.TryParse(num, out i))
                {

                }

                //Checks if user inputed 1
                if (i == 1)
                {
                    CourseWorkUnitTesting test = new CourseWorkUnitTesting();

                    test.Name =

                    Console.WriteLine("**********************");
                    Console.WriteLine("Unit Testing: Category");
                    Console.WriteLine("**********************");
                    Console.WriteLine("Category Name Property: ");
                    Console.WriteLine("Category Percentage Property: ");
                    Console.WriteLine("");
                }

                //Checks if user inputed 2
                if (i == 2)
                {
                    Console.WriteLine("**********************");
                    Console.WriteLine("Unit Testing: Assigment");
                    Console.WriteLine("**********************");
                    Console.WriteLine("Assigment Name Property: ");
                    Console.WriteLine("Assigment Description Property: ");
                    Console.WriteLine("Assigment CategoryName Property: ");
                    Console.WriteLine("");
                }

                //Checks for vaild user input
                if (i < 1 || i > 3)
                {
                    Console.WriteLine("Invaild Input");
                    Console.WriteLine("Enter 1, 2 or 3");
                    Console.WriteLine("");
                }

            } while (i != 3); //Loop will not exit until user inputs 3 
            #endregion

            //Checks if user inputed 3
            if (i == 3)
            {
                //Terminates Application
                System.Environment.Exit(1);
            }
        }
    }
}
