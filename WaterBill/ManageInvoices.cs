using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBill
{
    public class ManageInvoices
    {
        private List<Invoice> invoices = new List<Invoice>();
        public List<Invoice> GetInvoices()
        {
            return invoices;
        }
        public void AddInvoice(Invoice invoice)
        {
            invoices.Add(invoice);
        }
    }
}
