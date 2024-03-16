namespace Ted_Shop
{
    partial class TedShopSystemForm
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
            lblOrder = new Label();
            lblDelivery = new Label();
            lblReport = new Label();
            lblStaff = new Label();
            groupBox1 = new GroupBox();
            monthCalendar1 = new MonthCalendar();
            lblSelectDate = new Label();
            lblSoldProduct = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrder.Location = new Point(12, 9);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(43, 17);
            lblOrder.TabIndex = 0;
            lblOrder.Text = "Order";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDelivery.Location = new Point(72, 9);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(54, 17);
            lblDelivery.TabIndex = 1;
            lblDelivery.Text = "Delivery";
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblReport.Location = new Point(142, 9);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(48, 17);
            lblReport.TabIndex = 2;
            lblReport.Text = "Report";
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStaff.Location = new Point(206, 9);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(34, 17);
            lblStaff.TabIndex = 3;
            lblStaff.Text = "Staff";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(lblSoldProduct);
            groupBox1.Controls.Add(lblSelectDate);
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(963, 457);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(403, 28);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // lblSelectDate
            // 
            lblSelectDate.AutoSize = true;
            lblSelectDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectDate.Location = new Point(234, 110);
            lblSelectDate.Name = "lblSelectDate";
            lblSelectDate.Size = new Size(157, 17);
            lblSelectDate.TabIndex = 7;
            lblSelectDate.Text = "Select From Date to Date:";
            // 
            // lblSoldProduct
            // 
            lblSoldProduct.AutoSize = true;
            lblSoldProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoldProduct.Location = new Point(25, 173);
            lblSoldProduct.Name = "lblSoldProduct";
            lblSoldProduct.Size = new Size(125, 17);
            lblSoldProduct.TabIndex = 8;
            lblSoldProduct.Text = "List of sold product:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(914, 187);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(487, 417);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 10;
            label1.Text = "Total benefit amount:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(654, 411);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 11;
            // 
            // TedShopSystemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 564);
            Controls.Add(groupBox1);
            Controls.Add(lblStaff);
            Controls.Add(lblReport);
            Controls.Add(lblDelivery);
            Controls.Add(lblOrder);
            Name = "TedShopSystemForm";
            Text = "Ted Shop System";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrder;
        private Label lblDelivery;
        private Label lblReport;
        private Label lblStaff;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label lblSoldProduct;
        private Label lblSelectDate;
        private MonthCalendar monthCalendar1;
        private TextBox textBox1;
    }
}