namespace Bid501
{
    partial class Bid501Client
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.uxListBox = new System.Windows.Forms.ListBox();
            this.uxPlaceBid = new System.Windows.Forms.Button();
            this.uxName = new System.Windows.Forms.Label();
            this.numOfBids = new System.Windows.Forms.Label();
            this.uxMinBid = new System.Windows.Forms.Label();
            this.uxTime = new System.Windows.Forms.Label();
            this.currentBid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxClientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(50, 183);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(68, 20);
            this.textBox.TabIndex = 0;
            // 
            // uxListBox
            // 
            this.uxListBox.FormattingEnabled = true;
            this.uxListBox.Location = new System.Drawing.Point(316, 77);
            this.uxListBox.Name = "uxListBox";
            this.uxListBox.Size = new System.Drawing.Size(120, 225);
            this.uxListBox.TabIndex = 1;
            this.uxListBox.SelectedIndexChanged += new System.EventHandler(this.uxListBox_SelectedIndexChanged);
            // 
            // uxPlaceBid
            // 
            this.uxPlaceBid.Location = new System.Drawing.Point(50, 255);
            this.uxPlaceBid.Name = "uxPlaceBid";
            this.uxPlaceBid.Size = new System.Drawing.Size(115, 47);
            this.uxPlaceBid.TabIndex = 2;
            this.uxPlaceBid.Text = "Place Bid";
            this.uxPlaceBid.UseVisualStyleBackColor = true;
            this.uxPlaceBid.Click += new System.EventHandler(this.placeBid_Click);
            // 
            // uxName
            // 
            this.uxName.AutoSize = true;
            this.uxName.Location = new System.Drawing.Point(47, 77);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(58, 13);
            this.uxName.TabIndex = 3;
            this.uxName.Text = "Item Name";
            // 
            // numOfBids
            // 
            this.numOfBids.AutoSize = true;
            this.numOfBids.Location = new System.Drawing.Point(145, 190);
            this.numOfBids.Name = "numOfBids";
            this.numOfBids.Size = new System.Drawing.Size(76, 13);
            this.numOfBids.TabIndex = 4;
            this.numOfBids.Text = "number of bids";
            // 
            // uxMinBid
            // 
            this.uxMinBid.AutoSize = true;
            this.uxMinBid.Location = new System.Drawing.Point(47, 221);
            this.uxMinBid.Name = "uxMinBid";
            this.uxMinBid.Size = new System.Drawing.Size(78, 13);
            this.uxMinBid.TabIndex = 5;
            this.uxMinBid.Text = "Minimum Bid: $";
            // 
            // uxTime
            // 
            this.uxTime.AutoSize = true;
            this.uxTime.Location = new System.Drawing.Point(47, 105);
            this.uxTime.Name = "uxTime";
            this.uxTime.Size = new System.Drawing.Size(83, 13);
            this.uxTime.TabIndex = 6;
            this.uxTime.Text = "Time Remaining";
            // 
            // currentBid
            // 
            this.currentBid.BackColor = System.Drawing.Color.Beige;
            this.currentBid.Enabled = false;
            this.currentBid.Location = new System.Drawing.Point(111, 135);
            this.currentBid.Name = "currentBid";
            this.currentBid.Size = new System.Drawing.Size(31, 24);
            this.currentBid.TabIndex = 7;
            this.currentBid.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Products";
            // 
            // uxClientName
            // 
            this.uxClientName.AutoSize = true;
            this.uxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClientName.Location = new System.Drawing.Point(177, 21);
            this.uxClientName.Name = "uxClientName";
            this.uxClientName.Size = new System.Drawing.Size(0, 25);
            this.uxClientName.TabIndex = 10;
            this.uxClientName.UseMnemonic = false;
            // 
            // Bid501Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 297);
            this.Controls.Add(this.uxClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentBid);
            this.Controls.Add(this.uxTime);
            this.Controls.Add(this.uxMinBid);
            this.Controls.Add(this.numOfBids);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxPlaceBid);
            this.Controls.Add(this.uxListBox);
            this.Controls.Add(this.textBox);
            this.Name = "Bid501Client";
            this.Text = "Bid501";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bid501Client_FormClosed);
            this.Load += new System.EventHandler(this.Bid501Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox uxListBox;
        private System.Windows.Forms.Button uxPlaceBid;
        private System.Windows.Forms.Label uxName;
        private System.Windows.Forms.Label numOfBids;
        private System.Windows.Forms.Label uxMinBid;
        private System.Windows.Forms.Label uxTime;
        private System.Windows.Forms.Button currentBid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uxClientName;
    }
}