using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class CalculatorForm : Form
    {
        double amount = 0.00;
        public CalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This event is use to calculate and display the Tip Per Person and the Total Per Person, on the change 
        /// of the Bill Amount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmount.Text, out var newAmount))
            {
                amount = newAmount;
                UpdateBillInfo();
            }
            else
            {
                txtAmount.Text = amount.ToString();
            }

        } 

        /// <summary>
        /// This event is use to calculate and display the Tip Per Person and the Total Per Person, on the change 
        /// of the Tip Percent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numTipPercent_ValueChanged(object sender, EventArgs e)
        {
            UpdateBillInfo();
        }
        /// <summary>
        /// This event is use to calculate and display the Tip Per Person and the Total Per Person, on the change 
        /// of the People Count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numPeople_ValueChanged(object sender, EventArgs e)
        {
            UpdateBillInfo();
        }
        /// <summary>
        /// This function Get and Update the value of the Tip Per person and The Total Per Person on the Form 
        /// </summary>

        private void UpdateBillInfo()
        {
            var tipPerPerson = CalculateTipPerPerson();
            var totalPerPerson = CalculateTotalPerPerson();

            labelTipPerPerson.Text = "$ " + tipPerPerson.ToString();
            labelTotalPerPerson.Text = "$" + totalPerPerson.ToString();
        }
        /// <summary>
        /// This function Calculate Amount Per Person on the Form 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="tipPercent"></param>
        /// <param name="people"></param>
        /// <returns></returns>
        private double CalculateAmountPerPerson(double amount, int tipPercent, int people)
        {
            return Math.Round(amount / people, 2);
        }
        /// <summary>
        /// This function Calculate Tip Per Person on the Form 
        /// </summary>
        /// <returns></returns>
        private double CalculateTipPerPerson()
        {
            int tipPercent = Convert.ToInt32(numTipPercent.Value);
            int people = Convert.ToInt32(numPeople.Value);
            return CalculateTipPerPerson(amount, tipPercent, people);
        }
        /// <summary>
        /// Tip Per Person
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="tipPercent"></param>
        /// <param name="people"></param>
        /// <returns></returns>
        private double CalculateTipPerPerson(double amount, int tipPercent, int people)
        {
            var perPersonAmount = CalculateAmountPerPerson(amount, tipPercent, people);
            var tipPerPerson = Math.Round((perPersonAmount * tipPercent) / 100, 2);
            return tipPerPerson;
        }

        private double CalculateTotalPerPerson()
        {
            int tipPercent = Convert.ToInt32(numTipPercent.Value);
            int people = Convert.ToInt32(numPeople.Value);
            return CalculateTotalPerPerson(amount, tipPercent, people);
        }
        private double CalculateTotalPerPerson(double amount, int tipPercent, int people)
        {
            var tipPerPerson = CalculateTipPerPerson(amount, tipPercent, people);
            var perPersonAmount = CalculateAmountPerPerson(amount, tipPercent, people);

            return tipPerPerson + perPersonAmount;
        }
    }
}
