using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declared all Variables
            int people = 0;
            double distance = 0;
            int prepDays;
            double totalPeople;
            double distanceTotal;
            double totalcost;


            int.TryParse(peopleInput.Text, out people);
            double.TryParse(distanceInput.Text, out distance);
            int.TryParse(deliveryInput.Text, out prepDays);

            //Making Sure Criteria is being Meet
            if (people > 0)
            {
                if (distance > 0)
                {
                    if (prepDays > 0)
                    {
                        //Company A

                        totalPeople = people; //Number of People 
                        distanceTotal = distance * .02; //Distance Traveled Formula
                        if (prepDays == 1)
                        {
                            totalcost = 20 + distanceTotal + totalPeople;
                            outCompA.Text = $"{totalcost:f2}";
                        }
                        else if (prepDays == 2)
                        {
                            totalcost = 17 + distanceTotal + totalPeople;
                            outCompA.Text = $"{totalcost:f2}";
                        }
                        else if (prepDays == 3)
                        {
                            totalcost = 15 + distanceTotal + totalPeople;
                            outCompA.Text = $"{totalcost:f2}";
                        }
                        else if (prepDays >= 4 && prepDays <= 7)
                        {
                            totalcost = 10 + distanceTotal + totalPeople;
                            outCompA.Text = $"{totalcost:f2}";
                        }
                        else
                        {
                            totalcost = 7 + distanceTotal + totalPeople;
                            outCompA.Text = $"{totalcost:f2}";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Delivery Days", "Status");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Distance", "Status");
                }
            }
            else
            {
                MessageBox.Show("Invalid Numbers of People", "Status");
            }

            //Company B

            if (people > 0)
            {
                if (distance > 0)
                {
                    if (prepDays > 0)
                    {
                        totalPeople = 0;
                        distanceTotal = distance * .1;


                        if (people < 10)
                            totalPeople = 20 * people;
                        else if (people >= 10 && people < 50)
                            totalPeople = 10 * people;
                        else if (people >= 50 && people < 100)
                            totalPeople = 5 * people;
                        else if (people >= 100 && people < 200)
                            totalPeople = 3 * people;
                        else if (people >= 200)
                            totalPeople = (int)(people * .15);

                        if (prepDays >= 1 && prepDays <= 4)
                        {
                            totalcost = 10 + totalPeople + distanceTotal;
                            companyB.Text = $"{totalcost:f2}";
                        }
                        else if (prepDays > 4)
                        {
                            totalcost = 7 + totalPeople + distanceTotal;
                            companyB.Text = $"{totalcost:f2}";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Delivery Days", "Status");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Distance", "Status");
                }
            }
            else
            {
                MessageBox.Show("Invalid Numbers of People", "Status");
            }



            if (people > 0)
            {
                if (distance > 0)
                {
                    if (prepDays > 0)
                    {
                        // total weight
                        totalPeople = (.25 * people);
                        distanceTotal = 0;
                        if (distance >= 1000) distanceTotal = 40;
                        else if (distance >= 750 && distance < 1000) distanceTotal = 35;
                        else if (distance >= 500 && distance < 750) distanceTotal = 25;
                        else if (distance >= 200 && distance < 500) distanceTotal = 15;
                        else if (distance < 200) distanceTotal = 10;
                        // total cost
                        totalcost = 20.0 + distanceTotal + totalPeople;
                        outComC.Text = $"{totalcost:f2}";
                    }
                    else
                    {
                        MessageBox.Show("Invalid Delivery Days", "Status");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Distance", "Status");
                }
            }
            else
            {
                MessageBox.Show("Invalid Numbers of People", "Status");
            }
        }
    }
}
            
