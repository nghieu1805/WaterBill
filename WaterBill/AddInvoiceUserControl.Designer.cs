namespace WaterBill
{
    partial class AddInvoiceUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            CustomerIDInput = new TextBox();
            CustomerNameInput = new TextBox();
            ThisMonthInput = new TextBox();
            LastMonthInput = new TextBox();
            NumberOfPeopleInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            button1 = new Button();
            TypeOfCustomerInput = new ComboBox();
            label5 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            resultSubtotal = new Label();
            resultEnvFee = new Label();
            resultVATFee = new Label();
            resultTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(211, 40);
            label1.TabIndex = 0;
            label1.Text = "Add An Invoice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 1;
            label2.Text = "Customer ID";
            // 
            // CustomerIDInput
            // 
            CustomerIDInput.Location = new Point(3, 81);
            CustomerIDInput.Name = "CustomerIDInput";
            CustomerIDInput.Size = new Size(132, 23);
            CustomerIDInput.TabIndex = 0;
            // 
            // CustomerNameInput
            // 
            CustomerNameInput.Location = new Point(197, 81);
            CustomerNameInput.Name = "CustomerNameInput";
            CustomerNameInput.Size = new Size(139, 23);
            CustomerNameInput.TabIndex = 1;
            // 
            // ThisMonthInput
            // 
            ThisMonthInput.Location = new Point(3, 131);
            ThisMonthInput.Name = "ThisMonthInput";
            ThisMonthInput.Size = new Size(132, 23);
            ThisMonthInput.TabIndex = 2;
            ThisMonthInput.TextChanged += textBox3_TextChanged;
            // 
            // LastMonthInput
            // 
            LastMonthInput.Location = new Point(197, 131);
            LastMonthInput.Name = "LastMonthInput";
            LastMonthInput.Size = new Size(139, 23);
            LastMonthInput.TabIndex = 3;
            // 
            // NumberOfPeopleInput
            // 
            NumberOfPeopleInput.Location = new Point(194, 181);
            NumberOfPeopleInput.Name = "NumberOfPeopleInput";
            NumberOfPeopleInput.Size = new Size(139, 23);
            NumberOfPeopleInput.TabIndex = 5;
            NumberOfPeopleInput.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(197, 57);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 3;
            label3.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(0, 107);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 3;
            label4.Text = "This Month Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 157);
            label6.Name = "label6";
            label6.Size = new Size(132, 21);
            label6.TabIndex = 3;
            label6.Text = "Type of Customer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(197, 107);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 3;
            label7.Text = "Last Month Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(197, 157);
            label9.Name = "label9";
            label9.Size = new Size(136, 21);
            label9.TabIndex = 3;
            label9.Text = "Number of People";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(222, 216);
            button1.Name = "button1";
            button1.Size = new Size(111, 30);
            button1.TabIndex = 6;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TypeOfCustomerInput
            // 
            TypeOfCustomerInput.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeOfCustomerInput.FormattingEnabled = true;
            TypeOfCustomerInput.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            TypeOfCustomerInput.Location = new Point(3, 181);
            TypeOfCustomerInput.Name = "TypeOfCustomerInput";
            TypeOfCustomerInput.Size = new Size(132, 23);
            TypeOfCustomerInput.TabIndex = 4;
            TypeOfCustomerInput.SelectedIndexChanged += TypeOfCustomerInput_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 217);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 6;
            label5.Text = "Subtotal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 240);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 6;
            label8.Text = "Env Fee:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 264);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 6;
            label10.Text = "VAT Fee:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(169, 262);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 6;
            label11.Text = "Total:";
            // 
            // resultSubtotal
            // 
            resultSubtotal.AutoSize = true;
            resultSubtotal.Location = new Point(63, 216);
            resultSubtotal.Name = "resultSubtotal";
            resultSubtotal.Size = new Size(0, 15);
            resultSubtotal.TabIndex = 7;
            // 
            // resultEnvFee
            // 
            resultEnvFee.AutoSize = true;
            resultEnvFee.Location = new Point(63, 240);
            resultEnvFee.Name = "resultEnvFee";
            resultEnvFee.Size = new Size(0, 15);
            resultEnvFee.TabIndex = 8;
            // 
            // resultVATFee
            // 
            resultVATFee.AutoSize = true;
            resultVATFee.Location = new Point(60, 264);
            resultVATFee.Name = "resultVATFee";
            resultVATFee.Size = new Size(0, 15);
            resultVATFee.TabIndex = 9;
            // 
            // resultTotal
            // 
            resultTotal.AutoSize = true;
            resultTotal.Location = new Point(222, 264);
            resultTotal.Name = "resultTotal";
            resultTotal.Size = new Size(0, 15);
            resultTotal.TabIndex = 10;
            // 
            // AddInvoiceUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(resultTotal);
            Controls.Add(resultVATFee);
            Controls.Add(resultEnvFee);
            Controls.Add(resultSubtotal);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(TypeOfCustomerInput);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(NumberOfPeopleInput);
            Controls.Add(ThisMonthInput);
            Controls.Add(LastMonthInput);
            Controls.Add(CustomerNameInput);
            Controls.Add(CustomerIDInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInvoiceUserControl";
            Size = new Size(400, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CustomerIDInput;
        private TextBox CustomerNameInput;
        private TextBox ThisMonthInput;
        private TextBox LastMonthInput;
        private TextBox NumberOfPeopleInput;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label9;
        private Button button1;
        private ComboBox TypeOfCustomerInput;
        private Label label5;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label resultSubtotal;
        private Label resultEnvFee;
        private Label resultVATFee;
        private Label resultTotal;
    }
}
