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
            manageInvoicesUserControl1.Hide();
            AddInvoiceMenuButton.BackColor = Color.Blue;
            AddInvoiceMenuButton.ForeColor = Color.White;

            ManageInvoicesMenuButton.BackColor = Color.White;
            ManageInvoicesMenuButton.ForeColor = Color.Black;
        }

        private void ManageInvoicesMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUserControl.Hide();
            manageInvoicesUserControl1.RefreshInvoiceList();
            manageInvoicesUserControl1.Show();
            AddInvoiceMenuButton.BackColor = Color.Blue;
            AddInvoiceMenuButton.ForeColor = Color.White;

            ManageInvoicesMenuButton.BackColor = Color.White;
            ManageInvoicesMenuButton.ForeColor = Color.Black;
        }
    }
}
