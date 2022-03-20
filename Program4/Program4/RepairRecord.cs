//Grading ID: K5088
//CIS 199-75
//4/13/2021
//Program 4
//Repair Records using Methods, classes, arrays, constructors
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Program4
{
    class RepairRecord
    {
        private int _zipCode; //Backing Fields from line 10 - 16
        private int _yearMade;
        private string _makeAndModel;
        private string _serialNumber;
        private int _appointmentLength;
        private string _techName;
        private bool _warranty;// Backing Fields

        //Conditions that have to followed in this program
        int minZip = 00000;// min zipCode
        int maxZip = 99999; //max zipCode
        int defaultZip = 40204; // if conditions isnt meet in the class a default zip will be given
        string defaultmodel = "Unknown Make/Model"; // default model if MAM is left with white space or "null".
        int serialNumberLength = 10; // SN length has to be equal to 10 
        string defaultSerialNumber = "A000000000"; //If a strings lengths isnt 10 we will replace it with a default SN
        string defaultTechName = "John Smith"; // default techName if Tech Name is left with white space or "null".
        int minAppTime = 15; // Min Appointment Time
        int maxAppTime = 180; // Max appointment time
        int defaultTime = 30; // Is the condition isnt inside criteria range we will resort to the default time
        double AppPrice = 1.50; // whatever the appointment length is it is timed by 1.50
        double noWarranty = 25; //flat cost with no warranty
        double withWarranty = 20; //falt cost with warranty
        int defaultYear = 2021; // I just added a little mix to this adding a default year

        
        //Constructors
        public RepairRecord(int zipCode, int yearMade, string makeAndModel, string serialNumber,
            int appointmentLength, string techName, bool warranty)
        {
            ZipCode= zipCode; //Setting the Zip Property
            YearMade = yearMade; //Setting the Year Property
            MakeAndModel = makeAndModel; //Setting the MAM Property
            SerialNumber = serialNumber;//Setting the SN Property
            AppointmentLength = appointmentLength;//Setting the Appointment Property
            TechName = techName;//Setting the TechName Property
            Warranty = warranty;//Setting the Warranty Property
        }
        //New Property

        public int ZipCode
        {
            //Pre-Condition: None
            //Post-Condition: Return of _zipCode
            get
            {
                return _zipCode;
            }
            //Pre-Condition: value >= minZip && <= maxzip
            //Post-Condition: the _zipCode has been set to a specific value 
            set
            {
                if (value >= minZip && value <= maxZip)
                    _zipCode = value;
                else
                    _zipCode = defaultZip;
            }
        }
        //New Property
        public int YearMade
        {
            //Pre-Condition: None
            //Post-Condition: Return of _yearMade
            get
            {
                return _yearMade;
            }
            //Pre-Condition: value >= 0 && <= 9999
            //Post-Condition: the _Year has been set to a specific value
            set
            {
                if (value >= 0 && value <= 9999) //Used a little bit of magic number to have arange 
                    //with year of production of the car
                    _yearMade = value;
                else
                    _yearMade = defaultYear;

            }
        }
        //New Property
        public string MakeAndModel
        {
            //Pre-Condition: None
            //Post-Condition: Return of _makeAndModel
            get
            {
                return _makeAndModel;
            }
            //Pre-Condition: To ensure the text doesnt have white space or a null
            //Post-Condition: to make sure that _makeAndModel have a value and set to a specific value
            set
            {
                if (!(string.IsNullOrWhiteSpace(value)))
                    _makeAndModel = value;
                else 
                    _makeAndModel = defaultmodel;
            }
        }
        //New Property
        public string SerialNumber
        {
            //Pre-Condition: None
            //Post-Condition: Return of _serialNumber
            get
            {
                return _serialNumber;
            }
            //Pre-Condition: to make sure the value is equal to 10
            //Post-Condition: if value is equal to serial number length the value is set 
            set
            {
                if (value.Length == serialNumberLength)
                    _serialNumber = value;
                else
                    _serialNumber = defaultSerialNumber;
            }
        }
        //New Property
        public int AppointmentLength
        {
            //Pre-Condition: None
            //Post-Condition: Return of _appointmentLength
            get
            {
                return _appointmentLength;
            }
            //Pre-Condition: value >= minAppTime && <= maxAppTime
            //Post-Condition: the _appointmentLength has been set to a specific value
            set
            {
                if (value >= minAppTime && value <= maxAppTime)
                    _appointmentLength = value;
                else
                    _appointmentLength = defaultTime;
            }
        }
        //New Property
        public string TechName
        {
            //Pre-Condition: None
            //Post-Condition: Return of _techName
            get
            {
                return _techName;
            }
            //Pre-Condition: To ensure the text doesnt have white space or a null
            //Post-Condition: to make sure that _techName have a value and set to a specific value
            set
            {
                if (!(string.IsNullOrWhiteSpace(value)))
                    _techName = value;
                else 
                    _techName = defaultTechName;
            }
        }
        //New Property
        public bool Warranty
        {
            //Pre-Condition: None
            //Post-Condition: Return of _warranty
            get
            {
                return _warranty;
            }
            //Pre-Condition: None
            //Post-Condition: displays if warranty is present or not
            set
            {
                if (value == true)
                    _warranty = value;
                else if (value == false)
                    _warranty = value;
            }
        }
        //New Property
        public double CalcCost()
        {
            double cost;
            if (Warranty == false)
                cost = (noWarranty + (AppPrice * AppointmentLength));
            else
                cost = withWarranty;
            return cost;
        }
        public double AppointmentHour
        {
            get
            {
                double appointmentHour = AppointmentLength;
                double roundAppoint;
                roundAppoint = (appointmentHour / 60);
                return roundAppoint;

            }
        }
        //Overriding a Method
        public override string ToString()
        {
            return "Service Location Zip Code: " + ZipCode + "\nYear: " + YearMade + "\nMake and Model: " + MakeAndModel +
                "\nSerial Number: " + SerialNumber + "\nAppointment Length: " + AppointmentLength + "\nAppointment Hours: " + AppointmentHour +
                "\nTechnician Name: " + TechName + "\nWarranty Coverage: " + Warranty; //What it should output once called
        }
        //A method
        public static void OutputRepairRecords(RepairRecord[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                WriteLine(obj[i].ToString()); //Lines 212-214
                WriteLine("Calculate Cost: " + obj[i].CalcCost() + "\n"); //Getting the calcost for the six records in
                //the array
            }
        }
    }
}

