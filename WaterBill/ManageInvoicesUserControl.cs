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
    public partial class ManageInvoicesUserControl : UserControl
    {

        public ManageInvoices ListInvoices;
        public ManageInvoicesUserControl()


        {
            InitializeComponent();
        }
        public void RefreshInvoiceList()
        {
            DataTable table = new DataTable();
            table.Columns.Add("No");
            table.Columns.Add("Customer ID");
            table.Columns.Add("Customer Name");
            table.Columns.Add("Customer Type");
            table.Columns.Add("Last Month");
            table.Columns.Add("This Month");
            table.Columns.Add("Total");

            if (ListInvoices != null)
            {
                List<Invoice> invoices = ListInvoices.GetInvoices();
                int i = 1;
                foreach (Invoice invoice in invoices)
                {
                    table.Rows.Add(
                    i++,
                    invoice.customerId,
                    invoice.customerName,
                    invoice.typeOfCustomer,
                    invoice.lastMonthNumber,
                    invoice.thisMonthNumber,
                    invoice.total
                );

                }
            }
        }
    }

}


