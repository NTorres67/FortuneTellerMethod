using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameFirst = "";
            string nameLast = "";

            // User's First Name

            Console.WriteLine("Please enter your first name.");
            nameFirst = Console.ReadLine();
            Console.WriteLine(" ");

            // User's Last Name
            
            Console.WriteLine("Please enter your last name.");
            nameLast = Console.ReadLine();
            Console.WriteLine(" ");

            // Greet User
            Console.WriteLine("Greetings, " + nameFirst + " " + nameLast + ". I will tell you your fortune!");
            Console.WriteLine("");


            //User's Age
            Console.WriteLine("Please enter your age.");
            int ageCurrent = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            //Console.WriteLine(ageCurrent);

            //Years to Retirement
            int ageOdd = 62;
            int ageEven = 65;
            //int retire = (ageEven - ageCurrent);

            int retire;
            if ((ageCurrent % 2) == 0)
            {
                retire = (ageEven - ageCurrent);
                //Console.WriteLine(retire);
            }
            else
            {
                retire = (ageOdd - ageCurrent);
            }

            Console.WriteLine("");

            //Console.WriteLine(retire);
            //return (retire);



            //Number Siblings
            Console.WriteLine("How many sibilings do you have?");
            int numberSiblings = int.Parse(Console.ReadLine());
            //Console.Write(numberSiblings);
            Console.WriteLine("");

            //Vacation Home according to number of siblings
            string vac = "";

            if (numberSiblings <= 0)
            {
                vac = " the garbage dump";
                //Console.WriteLine(vac);
            }
            if (numberSiblings == 0)
            {
                vac = "woods";
            }
            if (numberSiblings == 1)
            {
                vac = "Pacific Ocean";
            }
            if (numberSiblings == 2)
            {
                vac = "Mediterranean";
            }
            if (numberSiblings == 3)
            {
                vac = "Rockies";
            }
            if (numberSiblings >= 3)
            {
                vac = "Rockies";
            }
            else
            { }

            Console.WriteLine("");



            //Favorite Color
            Console.WriteLine("Please state your favorite using the ROYGBIV color acronym.");
            Console.WriteLine("If help is required, please type the word \"Help.\"");
            string favoriteColor = Console.ReadLine();
            //Console.WriteLine(favoriteColor);
            string color = favoriteColor.ToLower();
            Console.WriteLine(" ");

            if (favoriteColor == "help")
            {
                Console.WriteLine("R = red");
                Console.WriteLine("O = orange");
                Console.WriteLine("Y = yellow");
                Console.WriteLine("G = green");
                Console.WriteLine("B = blue");
                Console.WriteLine("I = indigo");
                Console.WriteLine("V = violet");

                Console.WriteLine("");

                Console.WriteLine("Please select your favorit color using the ROYGIBIV color acronym.");
                favoriteColor = Console.ReadLine();
                color = favoriteColor.ToLower();
            }

            Console.WriteLine("");

            //Transportation according to favorite color
            string col = "";

            switch (color)
            {
                case "red":
                    col = "your feet";
                    //Console.WriteLine(red);
                    break;

                case "orange":
                    col = "horseless wagon";
                    break;

                case "yellow":
                    col = " truck";
                    break;

                case "green":
                    col = "scooter";
                    break;

                case "blue":
                    col = "donkey";
                    break;

                case "indigo":
                    col = "seahorse";
                    break;

                case "violet":
                    col = "sled pulled by rabbits";
                    break;

                default:
                    break;
            }
            Console.WriteLine("");

            //Console.WriteLine(col);
            //return (col);



            // Birth Month
            Console.WriteLine("Please enter your month of birth by its numerical value.");
            int birthMonth = int.Parse(Console.ReadLine());
            //Console.WriteLine(birthMonth);
            Console.WriteLine(" ");

            // Money in bank based on month of birth
            string pay = "";
            if ((birthMonth == 1) || (birthMonth == 2) || (birthMonth == 3) || (birthMonth == 4))
            {
                pay = "$10,000";
                //Console.WriteLine(payOne);
            }
            if ((birthMonth == 5) || (birthMonth == 6) || (birthMonth == 7) || (birthMonth == 8))
            {
                pay = "$15,000";
                //Console.WriteLine(payTwo);
            }
            if ((birthMonth == 9) || (birthMonth == 10) || (birthMonth == 11) || (birthMonth == 12))
            {
                pay = "$20,000";
                //Console.WriteLine(payThree);
            }
            if ((birthMonth <= 0) || (birthMonth >= 12))
            {
                pay = "$0.00";
                //Console.WriteLine(payOther);
            }
            else
            { }
            Console.WriteLine("");

            //Console.WriteLine(pay);
            //return (pay);

            // Provide Fortune
            Console.WriteLine(nameFirst + " " + nameLast + " will retire in " + retire + " years with " + pay + " in the bank, a vaction home in " + vac + " and a " + col + ".");
            Console.WriteLine("");

            // Judge how good the fortune is
            Console.WriteLine("Better luck in your next life! ( *_* )");
            Console.WriteLine("");


        }
 
    }
}

