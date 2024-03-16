namespace Ted_Shop
{
    partial class CartForm
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
            btnCheckout = new Button();
            dgvCart = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(29, 22);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(127, 32);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(29, 72);
            dgvCart.Name = "dgvCart";
            dgvCart.RowTemplate.Height = 25;
            dgvCart.Size = new Size(859, 322);
            dgvCart.TabIndex = 1;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 430);
            Controls.Add(dgvCart);
            Controls.Add(btnCheckout);
            Name = "CartForm";
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckout;
        private DataGridView dgvCart;
    }
}
