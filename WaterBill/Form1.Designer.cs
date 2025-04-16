namespace WaterBill
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnExit = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ManageInvoicesMenuButton = new Button();
            AddInvoiceMenuButton = new Button();
            addInvoiceUserControl = new AddInvoiceUserControl();
            manageInvoicesUserControl1 = new ManageInvoicesUserControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ManageInvoicesMenuButton);
            panel1.Controls.Add(AddInvoiceMenuButton);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(122, 290);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(0, 267);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(8, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 69);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ManageInvoicesMenuButton
            // 
            ManageInvoicesMenuButton.Location = new Point(3, 116);
            ManageInvoicesMenuButton.Name = "ManageInvoicesMenuButton";
            ManageInvoicesMenuButton.Size = new Size(111, 35);
            ManageInvoicesMenuButton.TabIndex = 1;
            ManageInvoicesMenuButton.Text = "Manage Invoices";
            ManageInvoicesMenuButton.UseVisualStyleBackColor = true;
            ManageInvoicesMenuButton.Click += ManageInvoicesMenuButton_Click;
            // 
            // AddInvoiceMenuButton
            // 
            AddInvoiceMenuButton.Location = new Point(8, 75);
            AddInvoiceMenuButton.Name = "AddInvoiceMenuButton";
            AddInvoiceMenuButton.Size = new Size(106, 35);
            AddInvoiceMenuButton.TabIndex = 1;
            AddInvoiceMenuButton.Text = "Add Invoice";
            AddInvoiceMenuButton.UseVisualStyleBackColor = true;
            AddInvoiceMenuButton.Click += AddInvoiceMenuButton_Click;
            // 
            // addInvoiceUserControl
            // 
            addInvoiceUserControl.BackColor = Color.AliceBlue;
            addInvoiceUserControl.BackgroundImageLayout = ImageLayout.Center;
            addInvoiceUserControl.Location = new Point(121, 1);
            addInvoiceUserControl.Name = "addInvoiceUserControl";
            addInvoiceUserControl.Size = new Size(501, 287);
            addInvoiceUserControl.TabIndex = 1;
            // 
            // manageInvoicesUserControl1
            // 
            manageInvoicesUserControl1.Location = new Point(121, 1);
            manageInvoicesUserControl1.Name = "manageInvoicesUserControl1";
            manageInvoicesUserControl1.Size = new Size(501, 287);
            manageInvoicesUserControl1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(623, 288);
            Controls.Add(manageInvoicesUserControl1);
            Controls.Add(addInvoiceUserControl);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ManageInvoicesMenuButton;
        private Button AddInvoiceMenuButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnExit;
        private AddInvoiceUserControl addInvoiceUserControl;
        private ManageInvoicesUserControl manageInvoicesUserControl1;
    }
}
