//Jonathan Ano Capstone SNHU

using System;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace ConsoleAppCshrp
{
    class Play
    {
        public static void PlayGame()
        {
            //#########Gather data from csv and populate a temp table
            System.Data.DataTable tempTbl = new System.Data.DataTable();

            var csvpath = "P:\\SNHU\\CAPSTONE\\Final\\CharactersCSV.csv";
            string FullContents;
            using (StreamReader srFILE = new StreamReader(csvpath))
            {
                FullContents = srFILE.ReadToEnd().ToString(); //This is to read the entire csv text
                string[] rows = FullContents.Split('\n'); //split the full contents into rows 

                for (int i = 0; i < rows.Count() - 1; i++)
                {
                    string[] rowValues = rows[i].Split(','); //split each row with comma to get individual values, this is why we have the -1 in the second statement of the for loop
                    {
                        if (i == 0) // this is declaring the first itteration as the HEADERS. Simply adding headers 
                        {
                            for (int j = 0; j < rowValues.Count(); j++)
                            {
                                tempTbl.Columns.Add(rowValues[j]); //add headers using system functions using pos 0;

                            }
                        }

                        else // This is taking each row after the headers and creating individual character arrays. starts at pos 1;
                        {
                            DataRow characterArray = tempTbl.NewRow();
                            for (int k = 0; k < rowValues.Count(); k++)
                            {
                                characterArray[k] = rowValues[k].ToString();
                            }
                            tempTbl.Rows.Add(characterArray); //Add other rows. 

                        }
                    }
                }

            }

            //########################## PLAY ####################################
            List<int> team1 = new List<int>();
            List<int> team2 = new List<int>();

            Console.WriteLine("CHARACTER LIST:");

            for (int i = 0; i < 6; i++) //displaying list of characters
            {
                Console.Write(i + 1 + ": ");
                Console.WriteLine(tempTbl.Rows[i]["Character"]);

            }

            Console.WriteLine('\n');

            //int characterSelection = Convert.ToInt32(Console.ReadLine());  //ENTER NUMBER
            int numberofCharacters = 0;

            void selectTeam()
            {
                if (numberofCharacters == 3)
                {
                    return;
                }
                Console.WriteLine("\n");
                Console.WriteLine(" ---------------------------");
                Console.WriteLine("| Please select a character |");
                Console.WriteLine(" ---------------------------");
                int characterSelection = Convert.ToInt32(Console.ReadLine());
                //List<int> team1 = new List<int>();
                if (characterSelection < 7 & characterSelection > 0 & numberofCharacters < 3)
                {
                    
                    Console.WriteLine("you added " + characterSelection);                    
                    team1.Add(characterSelection);
                                        
                    numberofCharacters++;
                    enemyTeam();
                }
                
               /* Console.WriteLine("Your Team: ");
                team1.ForEach(Console.WriteLine);*/

            }
            
            void enemyTeam()
            {
                Random rnd = new Random();
                int ran = rnd.Next(1, 7);
                if (numberofCharacters <= 3)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(" !!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.Write("    !   ENEMY CHOSE " + ran + " !\n"); //random selection from 1-5
                    Console.WriteLine(" !!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("\n");
                                        
                    team2.Add(ran);
                                       
                    selectTeam();
                }
                              
                if(numberofCharacters == 3)
                {
                    return;
                }
                
            }
            void team()
            {

                Console.WriteLine("Both teams are preparing to fight... Please wait");

                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("ENTERING BATTLE!!");
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("\nBOTH OF YOUR TEAMS ARE FIGHTING PLEASE WAIT...");
                System.Threading.Thread.Sleep(3000);
                int totalteam1 = team1.Sum();
                int totalteam2 = team2.Sum();

                if(totalteam1 > totalteam2)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(" YOUR TEAM DEFEATED THE ENEMY! ");
                    Console.WriteLine(@" \ \ / /   ___    _   _    \ \      / / (_)  _ __   | | | | | | ");
                    Console.WriteLine(@"  \ V /   / _ \  | | | |    \ \ /\ / /  | | | '_ \  | | | | | | ");
                    Console.WriteLine(@"   | |   | (_) | | |_| |     \ V  V /   | | | | | | |_| |_| |_| ");
                    Console.WriteLine(@"   |_|    \___/   \__,_|      \_/\_/    |_| |_| |_| (_) (_) (_) ");

                    System.Threading.Thread.Sleep(1000);

                    Console.WriteLine("\n Play Again? y/n");
                    string playagain = Console.ReadLine();

                    if(playagain == "y")
                    {
                        Program.Main();
                    }
                    else
                    {
                        return;
                    }
                }
                else if(totalteam2 > totalteam1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(" You faught hard but you lost in the end...");
                    Console.WriteLine("\n Play Again? y/n");
                    string playagain = Console.ReadLine();
                    if (playagain == "y")
                    {
                        Program.Main();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\n Both of your teams were evenly matched, it was a tie!");
                    Console.WriteLine("\n Play Again? y/n");
                    string playagain = Console.ReadLine();
                    if (playagain == "y")
                    {
                        Program.Main();
                    }
                    else
                    {
                        return;
                    }
                }


            }
            

            selectTeam(); //starting the calls

            team();

            

        }
    }
}
