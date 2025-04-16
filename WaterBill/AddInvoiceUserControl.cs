using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBill
{
    public partial class AddInvoiceUserControl : UserControl
    {
        public AddInvoiceUserControl()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeOfCustomerInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerID = CustomerIDInput.Text.Trim();
            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show(" Customer ID cannot be empty. Please enter a valid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(customerID, out int customerIdValue))
            {
                MessageBox.Show("Customer ID must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (customerIdValue <0)
            {
                MessageBox.Show(" Customer ID cannot be nagative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string customerName = CustomerNameInput.Text.Trim();
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Customer Name cannot be empty. Please enter a valid name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(customerName, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Customer Name must contain only letters and spaces.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int thisMonthNumber, lastMonthNumber;
            try
            {
                thisMonthNumber = Convert.ToInt32(ThisMonthInput.Text);
                lastMonthNumber = Convert.ToInt32(LastMonthInput.Text);
                if (lastMonthNumber > thisMonthNumber)
                {
                    MessageBox.Show("Last Month Number cannot be greater than This Month Number.","Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Both months must be valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numberOfPeople;
           
            try
            {
                numberOfPeople = Convert.ToInt32(NumberOfPeopleInput.Text);
                if (numberOfPeople <= 0)
                {
                    MessageBox.Show("Number of People must be greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch ( FormatException)
            {
                MessageBox.Show("Number of People must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string customerType = TypeOfCustomerInput.Text;
            double price = 0;
            double VATFee = 0;
            double envFee = 0;
            double subtotal = 0;
            double total = 0;
          
           
            int amountConsumption = thisMonthNumber - lastMonthNumber;
            if (customerType == "Household customer")
            {
                double amountConsumptionPerPeople = amountConsumption / (double) numberOfPeople;
                if (amountConsumptionPerPeople <= 10)
                {
                    price = 5973;
                    envFee = 597.3;
                }
                else if (amountConsumptionPerPeople <= 20)
                {
                    price = 7052;
                    envFee = 705.2;
                }
                else if (amountConsumptionPerPeople <= 30)
                {
                    price = 8699;
                    envFee = 869.9;
                }
                else
                {
                    price = 15929;
                    envFee = 1592.9;
                }
            }
            else if (customerType == "Administrative agency, public services")
            {
                price = 9955;
                envFee = 995.5;
            }
            else if (customerType == "Production units")
            {
                price = 11615;
                envFee = 1161.5;
            }
            else if (customerType == "Business services")
            {
                price = 22068;
                envFee = 2206.8;
            }
            else
            {
                MessageBox.Show("Invalid Type of customer", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            subtotal= (amountConsumption * price)+ envFee;
            VATFee = subtotal * 0.1;
            total = subtotal+VATFee;

            string invoiceId = DateTime.Now.ToFileTime(). ToString();
            Invoice invoice = new Invoice(
                customerID,
                customerName,
                invoiceId,
                DateTime.Now,
                thisMonthNumber,
                lastMonthNumber,
                customerType,
                numberOfPeople,
                amountConsumption,
                price,envFee,VATFee, subtotal, total
                );
            resultSubtotal.Text= Math.Round( subtotal, 2 ).ToString();
            resultEnvFee.Text = Math.Round(envFee, 2).ToString();
            resultVATFee.Text= Math.Round(VATFee,2 ).ToString();
            resultTotal.Text= Math.Round(total, 2).ToString();  
        }
    }
}
    

