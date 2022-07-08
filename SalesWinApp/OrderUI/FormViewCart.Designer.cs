
using System.ComponentModel;
using System.Windows.Forms;

namespace SalesWinApp.OrderUI
{
    partial class FormViewCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.lableProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.lableQuantity = new System.Windows.Forms.Label();
            this.textBoxProductQuantity = new System.Windows.Forms.TextBox();
            this.lableProductPrice = new System.Windows.Forms.Label();
            this.lableTotal = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductTotal = new System.Windows.Forms.TextBox();
            this.buttonRemoveFromCart = new System.Windows.Forms.Button();
            this.lableOrderTotal = new System.Windows.Forms.Label();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(12, 185);
            this.dataGridViewCart.MultiSelect = false;
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowTemplate.Height = 25;
            this.dataGridViewCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCart.Size = new System.Drawing.Size(877, 228);
            this.dataGridViewCart.TabIndex = 0;
            this.dataGridViewCart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellDoubleClick);
            // 
            // lableProductName
            // 
            this.lableProductName.AutoSize = true;
            this.lableProductName.Location = new System.Drawing.Point(21, 34);
            this.lableProductName.Name = "lableProductName";
            this.lableProductName.Size = new System.Drawing.Size(84, 15);
            this.lableProductName.TabIndex = 1;
            this.lableProductName.Text = "Product Name";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Enabled = false;
            this.textBoxProductName.Location = new System.Drawing.Point(114, 31);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(280, 23);
            this.textBoxProductName.TabIndex = 2;
            // 
            // lableQuantity
            // 
            this.lableQuantity.AutoSize = true;
            this.lableQuantity.Location = new System.Drawing.Point(21, 77);
            this.lableQuantity.Name = "lableQuantity";
            this.lableQuantity.Size = new System.Drawing.Size(53, 15);
            this.lableQuantity.TabIndex = 3;
            this.lableQuantity.Text = "Quantity";
            // 
            // textBoxProductQuantity
            // 
            this.textBoxProductQuantity.Enabled = false;
            this.textBoxProductQuantity.Location = new System.Drawing.Point(114, 74);
            this.textBoxProductQuantity.Name = "textBoxProductQuantity";
            this.textBoxProductQuantity.Size = new System.Drawing.Size(280, 23);
            this.textBoxProductQuantity.TabIndex = 4;
            // 
            // lableProductPrice
            // 
            this.lableProductPrice.AutoSize = true;
            this.lableProductPrice.Location = new System.Drawing.Point(578, 36);
            this.lableProductPrice.Name = "lableProductPrice";
            this.lableProductPrice.Size = new System.Drawing.Size(33, 15);
            this.lableProductPrice.TabIndex = 5;
            this.lableProductPrice.Text = "Price";
            // 
            // lableTotal
            // 
            this.lableTotal.AutoSize = true;
            this.lableTotal.Location = new System.Drawing.Point(579, 82);
            this.lableTotal.Name = "lableTotal";
            this.lableTotal.Size = new System.Drawing.Size(32, 15);
            this.lableTotal.TabIndex = 6;
            this.lableTotal.Text = "Total";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Enabled = false;
            this.textBoxProductPrice.Location = new System.Drawing.Point(642, 34);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(247, 23);
            this.textBoxProductPrice.TabIndex = 7;
            // 
            // textBoxProductTotal
            // 
            this.textBoxProductTotal.Enabled = false;
            this.textBoxProductTotal.Location = new System.Drawing.Point(642, 80);
            this.textBoxProductTotal.Name = "textBoxProductTotal";
            this.textBoxProductTotal.Size = new System.Drawing.Size(247, 23);
            this.textBoxProductTotal.TabIndex = 8;
            // 
            // buttonRemoveFromCart
            // 
            this.buttonRemoveFromCart.Location = new System.Drawing.Point(395, 146);
            this.buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            this.buttonRemoveFromCart.Size = new System.Drawing.Size(118, 23);
            this.buttonRemoveFromCart.TabIndex = 9;
            this.buttonRemoveFromCart.Text = "&Remove From Cart";
            this.buttonRemoveFromCart.UseVisualStyleBackColor = true;
            this.buttonRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // lableOrderTotal
            // 
            this.lableOrderTotal.AutoSize = true;
            this.lableOrderTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lableOrderTotal.Location = new System.Drawing.Point(12, 150);
            this.lableOrderTotal.Name = "lableOrderTotal";
            this.lableOrderTotal.Size = new System.Drawing.Size(76, 15);
            this.lableOrderTotal.TabIndex = 10;
            this.lableOrderTotal.Text = "Order Total: ";
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(781, 150);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(108, 23);
            this.buttonCheckOut.TabIndex = 11;
            this.buttonCheckOut.Text = "&Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // FormViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 424);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.lableOrderTotal);
            this.Controls.Add(this.buttonRemoveFromCart);
            this.Controls.Add(this.textBoxProductTotal);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.lableTotal);
            this.Controls.Add(this.lableProductPrice);
            this.Controls.Add(this.textBoxProductQuantity);
            this.Controls.Add(this.lableQuantity);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.lableProductName);
            this.Controls.Add(this.dataGridViewCart);
            this.Name = "FormViewCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Cart";
            this.Load += new System.EventHandler(this.frmViewCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewCart;
        private Label lableProductName;
        private Label lableQuantity;
        private TextBox textBoxProductQuantity;
        private Label lableProductPrice;
        private Label lableTotal;
        private TextBox textBoxProductPrice;
        private TextBox textBoxProductTotal;
        private Button buttonRemoveFromCart;
        private TextBox textBoxProductName;
        private Label lableOrderTotal;
        private Button buttonCheckOut;
    }
}