using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{


    public partial class MainCalculator : Form
    {
        double weeklyIncome;
        double currentMoneyInBudget;
        double TotalNumberSpent;
        double TotalLuxSpent;
        double TotalEssSpent;



        string filePath_Inputted = @"C:\Users\Nathan\Documents\GitHub\Software-Engineering\Calculator\Calculator\previouslyInputtedData.txt";

        string filePath_Calculations = @"C:\Users\Nathan\Documents\GitHub\Software-Engineering\Calculator\Calculator\previousCalculations.txt";

        public MainCalculator()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader(filePath_Inputted))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {

                    string[] splitData = new string[5];
                    splitData = line.Split(' ');

                    Inputs previousData = new Inputs(splitData[2], splitData[4], double.Parse(splitData[3]));
                    string dateOfTransaction = splitData[0] + " " + splitData[1];

                    uiTransactionDataGrid.Rows.Add(dateOfTransaction, previousData.nameOfTransaction, previousData.amountSpent, previousData.luxuryOrEssential);
                }
            }


            using (StreamReader sr = new StreamReader(filePath_Calculations))
            {
                string line;
                string[] linesRead = new string[5];

                try
                {



                    while ((line = sr.ReadLine()) != null)
                    {
                        for (int i = 0; i > 5; i++)
                        {
                            linesRead[i] = line;
                        }
                    }

                    weeklyIncome = double.Parse(linesRead[0]);
                    TotalNumberSpent = double.Parse(linesRead[1]);
                    TotalLuxSpent = double.Parse(linesRead[2]);
                    TotalEssSpent = double.Parse(linesRead[3]);
                    currentMoneyInBudget = double.Parse(linesRead[4]);

                   
                    uiTotalIncomeTextBox.Text = ("£" + weeklyIncome.ToString());
                    uiIncomeTextBox.ReadOnly = true;
                    

                    uiMoneyLeftTextbox.Text = ("£" + currentMoneyInBudget);

                    uiTotalLuxTextbox.Text = TotalLuxSpent.ToString();
                    uiTotalEssTextbox.Text = TotalEssSpent.ToString();
                }
                catch (Exception e) { }
            }
        }

        
        private void TXTB_CHAR_ONLY(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))  //Makes it so only letters can be input
            {
                e.Handled = true;

            }
        }

        private void TXTB_NUM_ONLY(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar)&&(e.KeyChar != '.'))   //Makes it so numbers can only be input
            {
                e.Handled = true;

            }
        }

        private void uiIncomeButton_Click(object sender, EventArgs e)
        {
            weeklyIncome = double.Parse(uiIncomeTextBox.Text);
            uiTotalIncomeTextBox.Text = ("£" + weeklyIncome.ToString());
            uiIncomeTextBox.ReadOnly = true;
            currentMoneyInBudget = weeklyIncome;

            uiMoneyLeftTextbox.Text = ("£" + currentMoneyInBudget);




        }

        public void uiSpendButton_Click(object sender, EventArgs e)
        {
            if (uiIncomeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in Weekly Income");
                return; // return because we don't want to run normal code of button click
            }
            if (uiAmountTexbox.Text.Trim() == string.Empty|| uiItemNameTextbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the empty Textbox");
                return; // return because we don't want to run normal code of button click
            }

            string currentTransactionType = uiDropdown.SelectedItem.ToString();
            string currentTransactionName = uiItemNameTextbox.Text;
            double currentTransactionAmount = double.Parse(uiAmountTexbox.Text);

            string currentDate = DateTime.Now.ToString();

            Inputs latestInput = new Inputs(currentTransactionName, currentTransactionType, currentTransactionAmount);

            uiTransactionDataGrid.Rows.Add(currentDate, latestInput.nameOfTransaction, latestInput.amountSpent, latestInput.luxuryOrEssential);

            currentMoneyInBudget = currentMoneyInBudget - currentTransactionAmount;

            uiMoneyLeftTextbox.Text = ("£" + currentMoneyInBudget.ToString());
            


            string lineToWrite = (currentDate + " " + latestInput.nameOfTransaction + " " + latestInput.amountSpent + " " + latestInput.luxuryOrEssential);

            using (StreamWriter sw = new StreamWriter(filePath_Inputted))
            {
                sw.WriteLine(lineToWrite);
                
            }

            //Calculation 
            double CurrentAmountSpent = double.Parse(uiAmountTexbox.Text);
            TotalNumberSpent = TotalNumberSpent + CurrentAmountSpent;

            uiTotalSpentTextbox.Text = TotalNumberSpent.ToString();

            //Validation

            if (uiIncomeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox");
                return; // return because we don't want to run normal code of button click
            }
            if (currentMoneyInBudget <= 0)
            {
                MessageBox.Show("This will mean you don't have enough money left for the week");
                return; // return because we don't want to run normal code of button click
            }
            


            if (currentTransactionType =="Luxury")
            {

                double totalAmount = TotalLuxSpent;
                double TotalSpent = Convert.ToDouble(uiAmountTexbox.Text);
                TotalLuxSpent = TotalSpent + totalAmount;

                uiTotalLuxTextbox.Text = TotalLuxSpent.ToString();


            }

            if (currentTransactionType == "Essential")
            {
                double TotalAmount = TotalEssSpent;
                double TotalSpent = Convert.ToDouble(uiAmountTexbox.Text);
                TotalEssSpent = TotalSpent + TotalAmount;

                uiTotalEssTextbox.Text = TotalEssSpent.ToString();

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(filePath_Calculations))
            {
                sw.WriteLine(weeklyIncome);
                sw.WriteLine(TotalNumberSpent);
                sw.WriteLine(TotalLuxSpent);
                sw.WriteLine(TotalEssSpent);
                sw.WriteLine(currentMoneyInBudget);
                
            }



            System.Windows.Forms.Application.Exit();
        }
    }
}
