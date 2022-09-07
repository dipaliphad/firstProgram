using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProgram
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter the two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. for addition");
            Console.WriteLine("2. for substraction");
            Console.WriteLine("3. for multiplication");
            Console.WriteLine("4. for division");
            Console.WriteLine("5. for mod");
            Console.WriteLine("select your option");

            int result = Convert.ToInt32(Console.ReadLine());
           

            switch (result)
            {
                case 1:
                    Console.WriteLine($"addition the two numbers is {num1+num2}");
                    break;
               case 2:
                    Console.WriteLine($"substraction the two numbers is{num1-num2}");
                    break;

                case 3:
                    Console.WriteLine($"multiplication the two numbers is {num1*num2}");
                    break;

                case 4:
                    Console.WriteLine($"division the two numbers is {num1/num2}");
                    break;

                case 5:
                    Console.WriteLine($"mod the two numbers is {num1%num2}");
                    break;
                    default:
                    Console.WriteLine("wrong input");
                    break;
            }

            //Console.WriteLine("enter the numbers");
            //n1=Convert.ToInt32(Console.ReadLine());
            //n2 = Convert.ToInt32(Console.ReadLine());   
            //n3 = Convert.ToInt32(Console.ReadLine());

            //if(n1>n2 && n2>n3)
            //{
            //    Console.WriteLine($"{n1} is grater number");
            //}
            //else if(n2>n1 && n2>n3)
            //{
            //    Console.WriteLine($"{n2} is grater number");
            //}
            //else if(n3>n1 && n3>n2)
            //{
            //    Console.WriteLine($"{n3} is grater number");
            //}

            //char ch = 'd';
            //if(ch=='a' || ch=='e' || ch=='i'|| ch=='e'|| ch=='u')
            //{
            //    Console.WriteLine(" character is vowel");
            //}
            //else
            //{
            //    Console.WriteLine("character is consonnet");
            //}

            //int year = 2022;

            //if( year%4==0)
            //{
            //    Console.WriteLine("year is leap");
            //}
            //else
            //{
            //    Console.WriteLine("year is not leap");
            //}
            // int a = 10;
            //// Console.WriteLine($"{a++} {a++} {++a}");
            // Console.WriteLine($"{a++} {--a} {--a} {a++} {a++}");

            //Console.WriteLine("enter the two numbers");
            //int n1 =Convert.ToInt32(Console.ReadLine());
            //int n2 =Convert.ToInt32(Console.ReadLine());
            //int sum = n1 + n2;
            //int substraction = n1 - n2;
            //int multiplication = n2 * n1;
            //int divide = n2 / n2;
            //int mod = n2 % n1;
            //Console.WriteLine($"Addition is {sum}");
            //Console.WriteLine($"substraction is {substraction}");
            //Console.WriteLine($"multiplication is {multiplication}");
            //Console.WriteLine($"divide is {divide}");
            //Console.WriteLine($"mod is {mod}");


            //int n1 = 10, n2 = 20;
            //int result = n1 + n2;
            //int multiply = n1 * n2;
            //int divide = n1 / n2;
            //int subtraction = n1 - n2;
            //int modul = n1 % n2;
            //Console.WriteLine($"Addition is {result} and multiplication is {multiply} and devidatoin is {divide} and substraction is {subtraction} and modul is {modul}");
            //char gender ='M';
            //float salary = 45000.56f;
            //double salary2 = 78000.78;

            //Console.WriteLine("the gender is "+gender+" salary is "+salary+" salary2 is "+salary2);
            //Console.WriteLine("the gender is {0} salary is{1} salary2 is {2}",gender,salary,salary2);
            //Console.WriteLine($"the gender is{gender} salary is {salary} salary2 is {salary2}");

        }
    }
}
