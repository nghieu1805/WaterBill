namespace WaterBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addInvoiceUserControl.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddInvoiceMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUserControl.Show();
            AddInvoiceMenuButton.BackColor = Color.Blue;
            AddInvoiceMenuButton.ForeColor = Color.White;
        }
    }
}
