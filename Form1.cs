using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajorProject1_final
{
    public partial class Form1 : Form
    {
        public double loan;
        public double rate;
        public double rebate;
        public int months;
        public double balance;
        public double monthlyAPR;
        public double monthlyPayment;
        public double principleAmount;
        public double totalLoanAmount;
        public double totalPayment;
        public double totalLoanAmountForTheDay;
        public double totalInterestForTheDay;
        double totalPrincipleAmount;
        double totalInterest;
 
        public Form1()
        {

            InitializeComponent();
            Form1_load();

        }

        private void Form1_load()
        {
            rebateInput.ReadOnly = true;

        }

        private void CalculateButton_Click(object sender, EventArgs e) 
        { 
            totalPrincipleAmount =0;
            totalInterest =0;
            clearAll();


            if (!double.TryParse(loanAmountInput.Text, out loan) || loan <= 0)
            {
                MessageBox.Show("Please enter a valid loan amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                loan = double.Parse(loanAmountInput.Text);
            }

            if (!double.TryParse(annualAPRselect.Text, out rate) || rate <= 0)
            {
                MessageBox.Show("Please enter a valid APR.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                rate = Convert.ToDouble(annualAPRselect.Text);
            }


            if (checkBox1.Checked)
            {
                if (!double.TryParse(rebateInput.Text, out rebate))
                {
                    MessageBox.Show("Please enter a valid rebate amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                rebate = 0;
            }

            loan = loan-rebate;
            rate = rate/100;
            monthlyAPR = rate/12;
            setSelectedNumberOfMonths();
            balance = loan;
            monthlyPayment = (loan*monthlyAPR) / (1 - Math.Pow(1+ monthlyAPR ,-months));

            for(int index = 1; index <= months+1; index++)
            {
                 if(index == months+1)
                {
                    monthview.Items.Add("Total");
                    interestView.Items.Add(Math.Round(totalInterest,2).ToString("0.00"));
                    principleView.Items.Add(Math.Round(totalPrincipleAmount,2).ToString("0.00"));
                    paymentView.Items.Add(Math.Round(monthlyPayment*months).ToString("0.00"));

                }
             
                else { 
                totalLoanAmount += monthlyPayment;
                double interest = balance * monthlyAPR;
                principleAmount = monthlyPayment - interest;
                totalPrincipleAmount += principleAmount;
                totalInterest += interest;
                balance = balance - principleAmount;
               

                monthview.Items.Add(index.ToString());
                interestView.Items.Add(Math.Round(interest,2).ToString("0.00"));
                principleView.Items.Add(Math.Round(principleAmount,2).ToString("0.00"));
                paymentView.Items.Add(Math.Round(monthlyPayment).ToString("0.00"));
                listView1.Items.Add(Math.Round(balance,2).ToString("0.00"));
                    }

                

            }
                 string totalInterestForMsgBox = Math.Round(totalInterest,2).ToString("0.00");
                 string totalPrincipleForMsgBox = Math.Round(totalPrincipleAmount,2).ToString("0.00");
                 string totalPaymentForMsgBox = Math.Round(monthlyPayment*months,2).ToString("0.00");


                 MessageBox.Show($" Total Interest: {totalInterestForMsgBox} \n Total Principle Amount: {totalPrincipleForMsgBox} \n Total Payment :{totalPaymentForMsgBox}" ,"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      

        private void setSelectedNumberOfMonths ()
        {
            if (radioButton6.Checked)
            {
                months = 6;
            }
            else if (radioButton12.Checked)
            {
                months = 12;
            }
            else if (radioButton18.Checked)
            {
                months = 18;
            }
            else if (radioButton24.Checked)
            {
                months = 24;
            }
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            clearAll();
          
        }

        private void onAcceptLoanClicked(object sender, EventArgs e)
        {
            totalInterestForTheDay += totalInterest;
            totalLoanAmountForTheDay += loan;
        }

        private void onDisplayAllLoansClicked(object sender, EventArgs e)
        {
            totalInterestOutput.Text = totalInterestForTheDay.ToString("0.00)");
            totalLoansOutput.Text = totalLoanAmountForTheDay.ToString("(0.00)");
        }

        private void clearAll()
        {
            monthview.Clear();
            interestView.Clear();
            principleView.Clear();
            paymentView.Clear();
            listView1.Clear();
        }

        private void CheckBox1_Changed(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                rebateInput.ReadOnly = false;
            }
            else
            {
                rebateInput.ReadOnly = true;
                rebateInput.Clear();
                rebate = 0;
            }
        }

        private void onRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
