//Grading ID: K5088
//CIS 199-75
//3/22/2021
//Program 3 
////UPickItGrocery Calculator using Arrays and combo with array linked to it
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variables that will be used for the program to run properly 
            int itemselect;
            double shipmentCost =0;
            double quantityLBS;
            double intitalCost = 0;
            double discountedCost = 0;
            double totalCost = 0;
            //Taking the User's Input and taking it using as variables that associated above. 
            int.TryParse(itemNumbertxt.Text, out itemselect);
            double.TryParse(quantityItemTxt.Text, out quantityLBS);
            
            //If Statements to make sure the user is in ranage 
            if (farmList.SelectedIndex >= 0) //Since the Combobox starts as -1 we will use a if statment ranging from 0 to end of the combo box
            {
                if (itemselect >= 10001 && itemselect <= 10007) //Range of the items for sale 
                {
                    if (quantityLBS >= 0) //From 0 to infinity 
                    {
                        int farm = farmList.SelectedIndex; //int value to be associated witht the combobox 
                        double[] shipRate = {.06, .0717, .07, .0874 }; //Array of shipment price
                        shipmentCost = shipRate[farm]; //the variable of shipcost. shiprate being a parrallel array with int farm

                        //Item Number and Cost Per Pound 
                        int[] itemNumber = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 }; //Array for the item numbers
                        double[] pricePerPound = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 }; //Array for the price per pound
                        bool found2 = false; // setting up a bool statement 
                        //
                        for (int index2 = 0; index2 < itemNumber.Length && !found2; index2++) // int index, index is less than item numbers and making using the bool statment while searching in the array  
                        {
                            if (itemselect == itemNumber[index2]) // if the user input is equal to an itemnumber
                            {
                                found2 = true; //the bool will turn true
                            }
                            if (found2)
                            {
                                intitalCost = pricePerPound[index2]; //making the intitalCost what is equal the what inside the array of price per pound
                            }
                        }

                        //Total Pounds and the Discount Applied

                        int[] poundsRangeLL = { 0, 6, 11, 21 }; // Array Pound Range in lower range 
                        double[] discount = { 0, .05, .10, .15 }; //Discount that would be applied 
                        bool found3 = false;
                        // setting up another bool statement 
                        int index3 = poundsRangeLL.Length - 1; 
                        while (index3 > 0 && !found3)
                        {
                            if (quantityLBS >= poundsRangeLL[index3]) // making sure the user input is greater than or equal to whats inside the Pounds Range 
                                found3 = true; // to set the bool to true
                            else
                                index3--; // to continue in the array
                        }
                        if (found3)
                        {
                            discountedCost = discount[index3]; // setting up thr discounted price percent
                        }

                    
                    }
                    else
                    {
                    MessageBox.Show("Invalid Number of LBS", "Status"); //Message box informing the user they entered something incorrect 
                    }
                }
                else
                {
                    MessageBox.Show("Out of Range Item Number", "Status"); //Message box informing the user they entered something incorrect
                }
            }
            else
            {
                MessageBox.Show("Please Select a Farm"); //Message box informing the user they entered something incorrect
            }
            double intitalCstF = intitalCost * quantityLBS; // Final intital cost
            double discountF = intitalCost * quantityLBS - (intitalCost * quantityLBS * discountedCost); //final discount cost
            double shipCostf = discountF * shipmentCost; // final ship cost
            totalCost = shipCostf + discountF; // the total cost of everything
            intCostTxt.Text = $"{intitalCstF:c2}"; //output of the user entries 
            disCostTxt.Text = $"{discountF:c2}"; //output of the user entries
            shipCostTxt.Text = $"{shipCostf:c2}"; //output of the user entries
            totalCostTxt.Text = $"{totalCost:c2}"; //output of the user entries

        }
    }
}
