namespace Bid501
{
    partial class AddProdForm
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
            this.uxAvailableProductsList = new System.Windows.Forms.ListBox();
            this.uxAddItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxAvailableProductsList
            // 
            this.uxAvailableProductsList.FormattingEnabled = true;
            this.uxAvailableProductsList.Location = new System.Drawing.Point(12, 12);
            this.uxAvailableProductsList.Name = "uxAvailableProductsList";
            this.uxAvailableProductsList.Size = new System.Drawing.Size(369, 368);
            this.uxAvailableProductsList.TabIndex = 0;
            // 
            // uxAddItemButton
            // 
            this.uxAddItemButton.Location = new System.Drawing.Point(12, 387);
            this.uxAddItemButton.Name = "uxAddItemButton";
            this.uxAddItemButton.Size = new System.Drawing.Size(195, 51);
            this.uxAddItemButton.TabIndex = 1;
            this.uxAddItemButton.Text = "Add Item";
            this.uxAddItemButton.UseVisualStyleBackColor = true;
            this.uxAddItemButton.Click += new System.EventHandler(this.uxAddItemButton_Click);
            // 
            // ProductsToBeAddedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.uxAddItemButton);
            this.Controls.Add(this.uxAvailableProductsList);
            this.Name = "ProductsToBeAddedForm";
            this.Text = "ProductsToBeAddedForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxAvailableProductsList;
        private System.Windows.Forms.Button uxAddItemButton;
    }
}