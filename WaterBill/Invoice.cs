using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBill
{
    public class Invoice
    {
        protected string customerId {  get; set; }
        protected string customerName { get; set; }
        protected string invoiceId { get; set; }
        protected DateTime createdAt { get; set; }
        protected int thisMonthNumber { get; set; }
        protected int lastMonthNumber { get; set; }
        protected string typeOfCustomer { get; set; }
        protected int numberOfPeople { get; set; }
        protected int amountConsumption { get; set; }
        protected double price {  get; set; }
        protected double envFee { get; set; }
        protected double VATFee { get; set; }
        protected double subtotal { get; set; }
        protected double total { get; set; }

        public Invoice()
        {
            this.customerId = string.Empty;
            this.customerName = string.Empty;
            this.invoiceId = string.Empty;
            this.createdAt = DateTime.Now;
            this.thisMonthNumber = 0;
            this.lastMonthNumber = 0;
            this.typeOfCustomer = string.Empty;
            this.numberOfPeople = 0;
            this.amountConsumption = 0;
            this.price = 0.0;
            this.envFee = 0.0;
            this.VATFee = 0.0;
            this.subtotal = 0.0;
            this.total = 0.0;
        }

        public Invoice(
            string customerId,
            string customerName,
            string invoiceId,
            DateTime createdAt,
            int thisMonthNumber,
            int lastMonthNumber,
            string typeOfCustomer,
            int numberOfPeople,
            int amountConsumption,
            double price,
            double envFee,
            double VATFee,
            double subtotal,
            double total)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.invoiceId = invoiceId;
            this.createdAt = createdAt;
            this.thisMonthNumber = thisMonthNumber;
            this.lastMonthNumber = lastMonthNumber;
            this.typeOfCustomer = typeOfCustomer;
            this.numberOfPeople = numberOfPeople;
            this.amountConsumption = amountConsumption;
            this.price = price;
            this.envFee = envFee;
            this.VATFee = VATFee;
            this.subtotal = subtotal;
            this.total = total;
        }
    }
}
