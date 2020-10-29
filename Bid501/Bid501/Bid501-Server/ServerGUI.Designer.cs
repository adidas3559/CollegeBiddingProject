namespace Bid501_Server
{
    partial class ServerGUI
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
            this.components = new System.ComponentModel.Container();
            this.uxCurrentProducts = new System.Windows.Forms.ListBox();
            this.uxCurrentBidders = new System.Windows.Forms.ListBox();
            this.uxProductListLabel = new System.Windows.Forms.Label();
            this.uxBiddersList = new System.Windows.Forms.Label();
            this.uxTimeUp = new System.Windows.Forms.Button();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCurrentProducts
            // 
            this.uxCurrentProducts.FormattingEnabled = true;
            this.uxCurrentProducts.Location = new System.Drawing.Point(13, 39);
            this.uxCurrentProducts.Name = "uxCurrentProducts";
            this.uxCurrentProducts.Size = new System.Drawing.Size(197, 368);
            this.uxCurrentProducts.TabIndex = 1;
            // 
            // uxCurrentBidders
            // 
            this.uxCurrentBidders.FormattingEnabled = true;
            this.uxCurrentBidders.Location = new System.Drawing.Point(246, 39);
            this.uxCurrentBidders.Name = "uxCurrentBidders";
            this.uxCurrentBidders.Size = new System.Drawing.Size(210, 368);
            this.uxCurrentBidders.TabIndex = 2;
            // 
            // uxProductListLabel
            // 
            this.uxProductListLabel.AutoSize = true;
            this.uxProductListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxProductListLabel.Location = new System.Drawing.Point(55, 16);
            this.uxProductListLabel.Name = "uxProductListLabel";
            this.uxProductListLabel.Size = new System.Drawing.Size(114, 20);
            this.uxProductListLabel.TabIndex = 3;
            this.uxProductListLabel.Text = "Products List";
            // 
            // uxBiddersList
            // 
            this.uxBiddersList.AutoSize = true;
            this.uxBiddersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBiddersList.Location = new System.Drawing.Point(302, 16);
            this.uxBiddersList.Name = "uxBiddersList";
            this.uxBiddersList.Size = new System.Drawing.Size(104, 20);
            this.uxBiddersList.TabIndex = 4;
            this.uxBiddersList.Text = "Bidders List";
            // 
            // uxTimeUp
            // 
            this.uxTimeUp.Location = new System.Drawing.Point(168, 413);
            this.uxTimeUp.Name = "uxTimeUp";
            this.uxTimeUp.Size = new System.Drawing.Size(126, 46);
            this.uxTimeUp.TabIndex = 5;
            this.uxTimeUp.Text = "Time\'s Up";
            this.uxTimeUp.UseVisualStyleBackColor = true;
            this.uxTimeUp.Click += new System.EventHandler(this.uxTimeUp_Click);
            // 
            // ServerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 471);
            this.Controls.Add(this.uxTimeUp);
            this.Controls.Add(this.uxBiddersList);
            this.Controls.Add(this.uxProductListLabel);
            this.Controls.Add(this.uxCurrentBidders);
            this.Controls.Add(this.uxCurrentProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerGUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ServerForm";
            this.Load += new System.EventHandler(this.ServerGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox uxCurrentProducts;
        private System.Windows.Forms.ListBox uxCurrentBidders;
        private System.Windows.Forms.Label uxProductListLabel;
        private System.Windows.Forms.Label uxBiddersList;
        private System.Windows.Forms.Button uxTimeUp;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource auctionBindingSource;
    }
}