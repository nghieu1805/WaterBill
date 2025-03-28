using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            string customerID = CustomerIDInput.Text;
            string customerName = CustomerNameInput.Text;
            int thisMonthNumber = Convert.ToInt32(ThisMonthInput.Text);
            int lastMonthNumber = Convert.ToInt32(LastMonthInput.Text);
            string customerType = TypeOfCustomerInput.Text;
            int numberOfPeople = Convert.ToInt32(NumberOfPeopleInput.Text);
            double price = 0;
            double VATFee = 0;
            double envFee = 0;
            double subtotal = 0;
            double total = 0;

            int amountConsumption = thisMonthNumber - lastMonthNumber;
            if (customerType == "Household customer")
            {
                double amountConsumptionPerPeople = amountConsumption/numberOfPeople;
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
            else if (customerType == " Administrative agency, public services")
            {
                price = 9955;
                envFee = 995.5;
            }
            else if (customerType == " Production units")
            {
                price = 11615;
                envFee = 1161.5;
            }
            else if (customerType == " Business services")
            {
                price = 22068;
                envFee = 2206.8;
            }
            else
            {
                MessageBox.Show("Invalid Type of customer");
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
            resultSubtotal.Text = Math.Round(envFee, 2).ToString();
            resultVATFee.Text= Math.Round(VATFee,2 ).ToString();
            resultTotal.Text= Math.Round(total, 2).ToString();  
        }
    }
}
    

