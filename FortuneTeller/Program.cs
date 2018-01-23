using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //start variable declaration
            string fname, inputfname;
            string lname, inputlname;
            int age;
            string ageValue;
            string birthday;
            double birthdayInt;
            string transportation, transport; //mode of transportation - calling car names in coordination with colors associated
            int sibling;
            string siblingValue;
            string vacation;

            // asking about ROYGBIV
            string colorMessageOne = "Please select your favorite color from the ROYGBIV color pallate. If you need help to identify those colors, please type the word 'Help'.";
            // correcting choice with help option
            string colorMessageTwo = "Sorry, that's not a choice.  Type Help to see the options.";
            // something like great now that you know that roygbiv stands for x what is your favorite color? These will be part of if / else stmt /
            string colorMessageThree = "";
            

           

            //start to process the variables with writelines and readlines

            Console.WriteLine("Hello.  I am Zoltar, your Fortune Teller.  What is your First Name?");
            fname = Console.ReadLine();
            Console.WriteLine("And your last?");
            lname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", fname, lname);
            Console.WriteLine("Now, {0}, how old are you?", fname);
            ageValue = Console.ReadLine();
            age = int.Parse(ageValue); //turns age value into an integer
            
            // if else looking for even or odd age
            if (age %2==0) //remainder after dividing the first number by second
            {
                Console.WriteLine("Your age is even and you will retire in 15 years." );
            }
            else
            {
                Console.WriteLine("Your age is odd and you will retire in 10 years.");
             }
           
            
            

            // ask user for month born
            Console.WriteLine("What month were you born? ");
            birthday = Console.ReadLine();
           // birthday = int.Parse(birthday); //turns birthmonth into an integer
            Console.WriteLine("You are {0} years old and born in {1}. Zoltar thinks look much, much younger than that.", ageValue, birthday);
            
            
            /* logic in this thinking is if you are born between months 1-4, calculate +$100, 
             5 -8 calculate +$500 and months 9-12 +$1000.  if its less than 0 or >12, display 0.00*/


            /* this doesnt work this way but im going to ask pete about it bc i think i have the right idea
            if ((birthday >= 1) || (birthday <= 4))
            {
                Console.WriteLine("Happy Birthday, here is $100");
                    birthday(+$100);
            } 
            else ((birthday >= 5) || (birthday <= 8));
            {
                Console.WriteLine("Happy Birthday, here is $500");
                birthday(+$500);
            }

            else if ((birthday >=9) || (birthday <=12))
            {
                Console.WriteLine("Happy Birthday, here is $1000");
                birthday(+1000);
            }

           */
           
            



            //ask user to select color and designate the help feature in the switch statement
            Console.WriteLine("{0}", colorMessageOne);
            string input = Console.ReadLine().ToLower();//make user input lowercase 

            switch (input)
            {
                case "help":
                    Console.Write("These are the colors in ROYGBIV that you may choose");
                    Console.Write("red");
                    Console.Write("orange");
                    Console.Write("yellow");
                    Console.Write("green");
                    Console.Write("blue");
                    Console.Write("indigo");
                    Console.Write("violet");
                    Console.Write("Please choose a ROYGBIV color from the menu listed above");
                    input = Console.ReadLine().ToLower();
                    break;
                case "red":
                    Console.WriteLine("Red is a powerful color.  I see in your future, you will drive a red truck!");
                    transportation = "truck";
                    break;
                case "orange":
                    Console.WriteLine("Orange is a soothing color.  I see in your future, you will drive a soothing orange scooter!");
                    transportation = "scooter";
                    break;
                case "yellow":
                    Console.WriteLine("Yellow is a thoughtful color.  I see in your future, you will drive a Prius!");
                    transportation = "prius";
                    break;
                case "green":
                    Console.WriteLine("Green is the color of jealousy.  I see in your future, you will drive a pinto and be jealous of everyone elses rides!");
                    transportation = "pinto";
                    break;
                case "blue":
                    Console.WriteLine("Blue is the color of royalty.  I see in your future, you will drive a royal blue vespa!");
                    transportation = "vespa";
                    break;
                case "indigo":
                    Console.WriteLine("Indigo is a strong color.  I see in your future, you will drive a strong indigo tank!");
                    transportation = "tank";
                    break;
                case "violet":
                    Console.WriteLine("Violet  is a smart color.  I see in your future, you will drive a violet roadster!");
                    transportation = "roadster";
                    break;
                default:
                    Console.WriteLine(colorMessageTwo);
                    Console.Write("Please choose a ROYGBIV color");
                    input = Console.ReadLine().ToLower();
                    break;
            }

            //ask user to select number of siblings switch statement
            Console.WriteLine("How many siblings do you have?");
            sibling = int.Parse(Console.ReadLine());

            switch (sibling)
            {
                case 0:
                    Console.WriteLine("No Siblings");
                    if (sibling <= 0) //if sibling is less than or = to 0
                    {
                        vacation = ("the basement"); 
                      
                    }
                                            
                    else  (sibling >= 3)// if sibling is greater than or = to 3
                    {
                        vacation=("Delaware");
                        
                    }

              
                    break;
                case 1:
                    Console.WriteLine("One sibling");
                    vacation = "the basement";
                    break;

                case 2:
                    Console.WriteLine("Two siblings");
                    vacation = "Santorini, Greece";
                    break;
                case 3:
                    Console.WriteLine("Three siblings");
                    vacation = "Delaware";
                    break;
                default:
                    Console.WriteLine("Please choose a numerical value of siblings.");
                    Console.Write("Please select a number of siblings");
                    vacation = Console.ReadLine();
                    break;

            }

            Console.WriteLine("{0} {1} you will retire in {2} years with {3} in the bank, a vacation home in {4} and drive a {5}!", fname, lname, birthday, vacation, transportation);

            //i keep getting an ; expected error 
        }
       

   
                        
                   
           
                



          

        
    }
}
