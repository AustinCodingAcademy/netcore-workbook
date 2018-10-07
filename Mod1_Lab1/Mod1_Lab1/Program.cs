using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Mod1_Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Student Information");
            //string FirstName = "Dylan";
            //string LastName = "Zocchi";
            //DateTime birthDate;
            //birthDate = new DateTime();
            //string address = "2717 S Lamar Blvd Apt 2083";
            //string City = "Austin";
            //string State = "TX";
            //int Zip = 78704;
            //string Country = "USA";
            //Console.WriteLine(FirstName + " " + LastName);
            //Console.WriteLine(birthDate + " " + address + " " + City + " " + State + " " + Zip + " " + Country);

            //Console.WriteLine("Teacher Information");
            //string TeachFirstName = "Kim";
            //string TeachLastName = "Drezdon";
            //DateTime TbirthDate;
            //TbirthDate = new DateTime();
            //string Teachaddress = "2717 S Lamar Blvd Apt 2083";
            //string TeachCity = "Austin";
            //string TeachState = "TX";
            //int TeachZip = 78704;
            //string TeachCountry = "USA";
            //Console.WriteLine(TeachFirstName + " " + TeachLastName);
            //Console.WriteLine(TbirthDate + " " + Teachaddress + " " + TeachCity + " " + TeachState + " " + TeachZip + " " + TeachCountry);

            //Console.WriteLine("UProgram Information");
            //string ProgramName = "Advanced C#";
            //string DepartmentHead = "Dude";
            //string Degrees = "comp1";
            //Console.WriteLine(ProgramName + " " + DepartmentHead + " " + Degrees);

            //Console.WriteLine("Degree Info");
            //string DegreeName = "Scientist";
            //int CreditsRequired = 5;
            //Console.WriteLine(DegreeName + " " + CreditsRequired);


            //Console.WriteLine("Course Information");
            //string CourseName = "falkfjh";
            //int Credits = 7;
            //int DurationInWeeks = 5;
            //string Teacher = TeachFirstName + " " + TeachLastName;
            //Console.WriteLine(CourseName + " " + Credits + " " + DurationInWeeks + " " + Teacher);

            //// Create a switch block

            //Console.WriteLine("Coffee sizes: 1=small 2=medium 3=large");
            //Console.Write("Please enter your selection: ");
            //string str = Console.ReadLine();
            //int cost = 0;

            //switch (str)
            //{
            //    case "1":
            //    case "small":
            //        cost += 25;
            //        break;
            //    case "2":
            //    case "medium":
            //        cost += 50;
            //        break;
            //    case "3":
            //    case "large":
            //        cost += 75;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
            //        break;
            //}
            //if (cost != 0)
            //{
            //    Console.WriteLine("Please insert {0} cents.", cost);
            //}
            //Console.WriteLine("Thank you for your business.");
            //int outer;
            //int inner;

            //for (outer = 2; outer < 100; outer++)
            //{
            //    for (inner = 2; inner <= (outer / inner); inner++)
            //        if ((outer % inner) == 0) break; // if factor found, not prime
            //    if (inner > (outer / inner))
            //        Console.WriteLine("{0} is prime", outer);
            //}
            //int n = 1;
            //while (n < 6)
            //{
            //    Console.WriteLine($"Current value of n is {n}");
            //    n++;
            //}


            //int x = 3;
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;
            //} while (x < 5);

            int x;
            int y;
            for (y = 0; y < 8; y++)
            {
                if (y % 2 == 0)
                {
                    for (x = 0; x < 8; x++)
                        if (x % 2 == 0)
                        {
                            Console.Write("x");
                        }
                        else
                        {
                            Console.Write("o");
                        }
                    Console.WriteLine();

                }
                else
                {
                    for (x = 0; x < 8; x++)
                        if (x % 2 == 0)
                        {
                            Console.Write("o");
                        }
                        else
                        {
                            Console.Write("x");
                        }
                    Console.WriteLine();
                }
            }

        }



        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
