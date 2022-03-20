//Grading ID: K5088
//CIS 199-75
//4/13/2021
//Program 4
//Repair Records using Methods, Property, and array
using System;
using static System.Console;
namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before\n");
             
            RepairRecord[] recordOnFile = new RepairRecord[6]; //Array of Class Objects Line 12- 17 
            recordOnFile[0] = new RepairRecord(-1, -2, null, "A12345678", 14, " ", false); //Complete Messup to make sure everything works fine and normal
            recordOnFile[1] = new RepairRecord(40222, 2005, "Toyota Camry" , "A987654321", 90, "Charles M. ", true);
            recordOnFile[2] = new RepairRecord(40204, 2016, "BMW 328i", "J128754901", 120, "Charley W.", false);
            recordOnFile[3] = new RepairRecord(40025, 2014, "Mercedes C63", "W126787541", 180, "Kermit E.", true);
            recordOnFile[4] = new RepairRecord(40678, 2019, "Ford Mustang", "D543467546", 60, "Donnie T.", false);
            recordOnFile[5] = new RepairRecord(40634, 2015, "Nissan GTR", "C431345697", 45, "Erin Q.", true);
            RepairRecord.OutputRepairRecords(recordOnFile); //Displays the Output

            WriteLine("After\n");
            //Chanages to the records line 22 - 27  
            recordOnFile[0].ZipCode = 40222;
            recordOnFile[1].TechName = "Shuan P." ;
            recordOnFile[2].SerialNumber = "A32135690";//Human Error 9 SN instead of 10
            recordOnFile[3].AppointmentLength = 170;
            recordOnFile[4].MakeAndModel = "Corvette C8";
            recordOnFile[5].YearMade = 2012;
            RepairRecord.OutputRepairRecords(recordOnFile); //Displays the output


        }
    }
}
