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
    public class Characters
    {
        public static System.Data.DataTable CharacterList()
        {

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

           
            foreach (DataColumn column in tempTbl.Columns) //display all columns in a line
            {
                Console.Write("  " + column.ColumnName + "  ");

            }
            
            Console.WriteLine('\n');
           
            foreach(DataRow row in tempTbl.Rows)
            {
                Console.Write(row["Character"]);
                Console.Write("    |     ");
                Console.Write(row["Speed"]);
                Console.Write("  |   ");
                Console.Write(row["HP"]);
                Console.Write("  |   ");
                Console.Write(row["Defence"]);
                Console.Write("  |  ");
                Console.Write(row["Attack"]);
                Console.Write("  |   ");
                Console.Write(row["Critical"]);
                Console.Write("\n");



            }

            //Console.WriteLine(tempTbl.Rows[0][0]); //table.rows[rowindex][columnindex] // if you know column name table.rows[rowindex][columnname]

            /*
            foreach (DataRow row in tempTbl.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item + "    " );
                }
            }*/
            Console.WriteLine("\n");
            Console.WriteLine("###### Type 1 to Return to main menu: ######");
            
            int mainmenu = Convert.ToInt32(Console.ReadLine());
            if (mainmenu == 1)
            {

                Program.Main(); //This calls the main in program class

            }
            //playtbl = new DataTable();
            return tempTbl;
            //Console.WriteLine(CharacterList(tempTbl));

           











        }        
    }
}
