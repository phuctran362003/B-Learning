namespace Ted_Shop
{
    partial class CheckOutForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOrderDate = new Label();
            lblCusName = new Label();
            lblCusAddress = new Label();
            lblCusPhone = new Label();
            label4 = new Label();
            lblTotal = new Label();
            txtCusName = new TextBox();
            txtCusAddress = new TextBox();
            txtCusPhone = new TextBox();
            txtTotal = new TextBox();
            btnOrder = new Button();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderDate.Location = new Point(101, 71);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(88, 20);
            lblOrderDate.TabIndex = 0;
            lblOrderDate.Text = "Order date: ";
            // 
            // lblCusName
            // 
            lblCusName.AutoSize = true;
            lblCusName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCusName.Location = new Point(73, 126);
            lblCusName.Name = "lblCusName";
            lblCusName.Size = new Size(116, 20);
            lblCusName.TabIndex = 1;
            lblCusName.Text = "Customer name:";
            // 
            // lblCusAddress
            // 
            lblCusAddress.AutoSize = true;
            lblCusAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCusAddress.Location = new Point(59, 177);
            lblCusAddress.Name = "lblCusAddress";
            lblCusAddress.Size = new Size(130, 20);
            lblCusAddress.TabIndex = 2;
            lblCusAddress.Text = "Customer address:";
            // 
            // lblCusPhone
            // 
            lblCusPhone.AutoSize = true;
            lblCusPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCusPhone.Location = new Point(64, 228);
            lblCusPhone.Name = "lblCusPhone";
            lblCusPhone.Size = new Size(125, 20);
            lblCusPhone.TabIndex = 3;
            lblCusPhone.Text = "Customer phone: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 268);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(89, 280);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total amount:";
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(212, 123);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(261, 23);
            txtCusName.TabIndex = 6;
            // 
            // txtCusAddress
            // 
            txtCusAddress.Location = new Point(212, 174);
            txtCusAddress.Name = "txtCusAddress";
            txtCusAddress.Size = new Size(261, 23);
            txtCusAddress.TabIndex = 7;
            // 
            // txtCusPhone
            // 
            txtCusPhone.Location = new Point(212, 225);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(261, 23);
            txtCusPhone.TabIndex = 8;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(212, 277);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(261, 23);
            txtTotal.TabIndex = 9;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(84, 330);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(105, 52);
            btnOrder.TabIndex = 10;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(368, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 52);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(212, 68);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // CheckOutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 428);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCancel);
            Controls.Add(btnOrder);
            Controls.Add(txtTotal);
            Controls.Add(txtCusPhone);
            Controls.Add(txtCusAddress);
            Controls.Add(txtCusName);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(lblCusPhone);
            Controls.Add(lblCusAddress);
            Controls.Add(lblCusName);
            Controls.Add(lblOrderDate);
            Name = "CheckOutForm";
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderDate;
        private Label lblCusName;
        private Label lblCusAddress;
        private Label lblCusPhone;
        private Label label4;
        private Label lblTotal;
        private TextBox txtCusName;
        private TextBox txtCusAddress;
        private TextBox txtCusPhone;
        private TextBox txtTotal;
        private Button btnOrder;
        private Button btnCancel;
        private DateTimePicker dateTimePicker1;
    }
}