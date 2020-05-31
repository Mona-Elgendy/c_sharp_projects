namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.HeaderText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxLable = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingcartListBoxLabel = new System.Windows.Forms.Label();
            this.shoppingcartlistBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.VendorListBoxLabel = new System.Windows.Forms.Label();
            this.VendorListBox = new System.Windows.Forms.ListBox();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.StoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(23, 9);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(389, 51);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Consignment Shop ";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 25;
            this.itemsListBox.Location = new System.Drawing.Point(32, 106);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(368, 204);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // itemsListBoxLable
            // 
            this.itemsListBoxLable.AutoSize = true;
            this.itemsListBoxLable.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxLable.Location = new System.Drawing.Point(27, 77);
            this.itemsListBoxLable.Name = "itemsListBoxLable";
            this.itemsListBoxLable.Size = new System.Drawing.Size(120, 26);
            this.itemsListBoxLable.TabIndex = 2;
            this.itemsListBoxLable.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart.Location = new System.Drawing.Point(437, 178);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(204, 40);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart   ->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingcartListBoxLabel
            // 
            this.shoppingcartListBoxLabel.AutoSize = true;
            this.shoppingcartListBoxLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingcartListBoxLabel.Location = new System.Drawing.Point(671, 77);
            this.shoppingcartListBoxLabel.Name = "shoppingcartListBoxLabel";
            this.shoppingcartListBoxLabel.Size = new System.Drawing.Size(146, 26);
            this.shoppingcartListBoxLabel.TabIndex = 5;
            this.shoppingcartListBoxLabel.Text = "Shopping Cart";
            // 
            // shoppingcartlistBox
            // 
            this.shoppingcartlistBox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingcartlistBox.FormattingEnabled = true;
            this.shoppingcartlistBox.ItemHeight = 25;
            this.shoppingcartlistBox.Location = new System.Drawing.Point(676, 106);
            this.shoppingcartlistBox.Name = "shoppingcartlistBox";
            this.shoppingcartlistBox.Size = new System.Drawing.Size(380, 204);
            this.shoppingcartlistBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePurchase.Location = new System.Drawing.Point(852, 347);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(204, 40);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // VendorListBoxLabel
            // 
            this.VendorListBoxLabel.AutoSize = true;
            this.VendorListBoxLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorListBoxLabel.Location = new System.Drawing.Point(27, 381);
            this.VendorListBoxLabel.Name = "VendorListBoxLabel";
            this.VendorListBoxLabel.Size = new System.Drawing.Size(89, 26);
            this.VendorListBoxLabel.TabIndex = 8;
            this.VendorListBoxLabel.Text = "Vendors";
            // 
            // VendorListBox
            // 
            this.VendorListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorListBox.FormattingEnabled = true;
            this.VendorListBox.ItemHeight = 25;
            this.VendorListBox.Location = new System.Drawing.Point(32, 410);
            this.VendorListBox.Name = "VendorListBox";
            this.VendorListBox.Size = new System.Drawing.Size(368, 204);
            this.VendorListBox.TabIndex = 7;
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfitLabel.Location = new System.Drawing.Point(671, 425);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(116, 26);
            this.StoreProfitLabel.TabIndex = 9;
            this.StoreProfitLabel.Text = "StoreProfit";
            // 
            // StoreProfitValue
            // 
            this.StoreProfitValue.AutoSize = true;
            this.StoreProfitValue.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfitValue.Location = new System.Drawing.Point(811, 425);
            this.StoreProfitValue.Name = "StoreProfitValue";
            this.StoreProfitValue.Size = new System.Drawing.Size(65, 26);
            this.StoreProfitValue.TabIndex = 10;
            this.StoreProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 636);
            this.Controls.Add(this.StoreProfitValue);
            this.Controls.Add(this.StoreProfitLabel);
            this.Controls.Add(this.VendorListBoxLabel);
            this.Controls.Add(this.VendorListBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingcartListBoxLabel);
            this.Controls.Add(this.shoppingcartlistBox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListBoxLable);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.HeaderText);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxLable;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingcartListBoxLabel;
        private System.Windows.Forms.ListBox shoppingcartlistBox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label VendorListBoxLabel;
        private System.Windows.Forms.ListBox VendorListBox;
        private System.Windows.Forms.Label StoreProfitLabel;
        private System.Windows.Forms.Label StoreProfitValue;
    }
}

