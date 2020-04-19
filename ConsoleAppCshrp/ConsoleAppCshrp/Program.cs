//Jonathan Ano Capstone SNHU

using System;
using System.IO;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Text;



namespace ConsoleAppCshrp
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine(" -------------------------------------------------   ");
            Console.WriteLine("|          Welcome to Tic Tac Tactical!          |   ");
            Console.WriteLine(" ------------------------------------------------- \n");

            Console.WriteLine("             ~~~~~~~~~ MENU ~~~~~~~~~               ");
            Console.WriteLine(" ▄▄▄▄               ▄▄▄▄▄▄▄ ▄▄▄     ▄▄▄▄▄▄▄ ▄▄   ▄▄");
            Console.WriteLine("█    █             █       █   █   █       █  █ █  █");
            Console.WriteLine(" █   █             █    ▄  █   █   █   ▄   █  █▄█  █");
            Console.WriteLine(" █   █             █   █▄█ █   █   █  █▄█  █       █");
            Console.WriteLine(" █   █      ▄▄▄    █    ▄▄▄█   █▄▄▄█       █▄     ▄█");
            Console.WriteLine(" █   █     █   █   █   █   █       █   ▄   █ █   █");
            Console.WriteLine(" █▄▄▄█     █▄▄▄█   █▄▄▄█   █▄▄▄▄▄▄▄█▄▄█ █▄▄█ █▄▄▄█");

            Console.WriteLine(" ▄▄▄▄▄▄▄            ▄▄▄▄▄▄▄ ▄▄   ▄▄ ▄▄▄▄▄▄ ▄▄▄▄▄▄   ▄▄▄▄▄▄ ▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄ ▄▄▄▄▄▄   ▄▄▄▄▄▄▄");
            Console.WriteLine("█       █          █       █  █ █  █      █   ▄  █ █      █       █       █       █   ▄  █ █       █");
            Console.WriteLine("█▄▄▄▄   █          █       █  █▄█  █  ▄   █  █ █ █ █  ▄   █       █▄     ▄█    ▄▄▄█  █ █ █ █  ▄▄▄▄▄█");
            Console.WriteLine(" ▄▄▄▄█  █          █     ▄▄█       █ █▄█  █   █▄▄█▄█ █▄█  █     ▄▄█ █   █ █   █▄▄▄█   █▄▄█▄█ █▄▄▄▄▄");
            Console.WriteLine("█ ▄▄▄▄▄▄█   ▄▄▄    █    █  █   ▄   █      █    ▄▄  █      █    █    █   █ █    ▄▄▄█    ▄▄  █▄▄▄▄▄  █");
            Console.WriteLine("█ █▄▄▄▄▄   █   █   █    █▄▄█  █ █  █  ▄   █   █  █ █  ▄   █    █▄▄  █   █ █   █▄▄▄█   █  █ █▄▄▄▄▄█ █");
            Console.WriteLine("█▄▄▄▄▄▄▄█  █▄▄▄█   █▄▄▄▄▄▄▄█▄▄█ █▄▄█▄█ █▄▄█▄▄▄█  █▄█▄█ █▄▄█▄▄▄▄▄▄▄█ █▄▄▄█ █▄▄▄▄▄▄▄█▄▄▄█  █▄█▄▄▄▄▄▄▄█");

            Console.WriteLine(" ▄▄▄▄▄▄▄            ▄▄▄▄▄▄▄ ▄▄   ▄▄ ▄▄▄ ▄▄▄▄▄▄▄");
            Console.WriteLine("█       █          █       █  █▄█  █   █       █");
            Console.WriteLine("█▄▄▄    █          █    ▄▄▄█       █   █▄     ▄█");
            Console.WriteLine(" ▄▄▄█   █          █   █▄▄▄█       █   █ █   █");
            Console.WriteLine("█▄▄▄    █   ▄▄▄    █    ▄▄▄██     ██   █ █   █");
            Console.WriteLine(" ▄▄▄█   █  █   █   █   █▄▄▄█   ▄   █   █ █   █");
            Console.WriteLine("█▄▄▄▄▄▄▄█  █▄▄▄█   █▄▄▄▄▄▄▄█▄▄█ █▄▄█▄▄▄█ █▄▄▄█ \n");

            Console.WriteLine(" -------------------------------------------------   ");
            Console.WriteLine("|       Please select a numbered option:          |  ");
            Console.WriteLine(" -------------------------------------------------   ");

            int menuSelection = Convert.ToInt32(Console.ReadLine()); //reads the user input
            //var csvPath = "P:\\SNHU\\CAPSTONE\\Final\\CharactersCSV.csv";
            //bool menuSelectionLoop = true;


            if (menuSelection == 1)
            {
             
                Play.PlayGame(); //This calls the Play Class from play.cs

            }

            else if (menuSelection == 2)
            {
                Console.WriteLine(" starting ");
                System.Data.DataTable tempTbl = Characters.CharacterList();
                Console.WriteLine(" ending ");
                Console.WriteLine();
            }

            else if (menuSelection == 3)
            {
                Console.WriteLine("\n             Thank you for playing!");
                System.Threading.Thread.Sleep(2000); //system pauses for 2 seconds (2000)
                Environment.Exit(0);
            }
            else
            {
                
                Console.WriteLine("You entered: " + menuSelection + ", please select a valid menu option." );
                
                System.Threading.Thread.Sleep(2000);

                Main();

            }

            /*
            //Console.WriteLine("you entered: " + menuSelection);  # this is testing the menu
            do
            {
                Console.WriteLine("Please select an option: ");

                int menuSelection = Convert.ToInt32(Console.ReadLine()); //reads the user input
                bool menuSelectionLoop = true;


            }
            while ((menuSelectionLoop == 1) || (menuSelectionLoop == 2) || (menuSelectionLoop == 3)); //exit if a proper condition is met
            

                if (menuSelection == 1)
                {
                    Console.WriteLine("works");

                }

                else if (menuSelection == 2)
                {
                    Console.WriteLine("works");
                }

                else if (menuSelection == 3)
                {
                    Console.WriteLine("works");
                }
                 
                 
            } */
         
        }
    }
}
