
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Input;
using System.Drawing;

namespace Bid501
{
    public partial class Bid501Client : Form
    {
        private Dictionary<int, mProduct> productList;
        private Dictionary<int, ClientBids> clientBids; // does nothing :(
        private ExitUser exitUser;
        private ProductSelectedDelegate productSelected;
        private BidPlacedDelegate bidPlaced;
        string clientName;

        
        public Bid501Client(Dictionary<int , mProduct> p , Dictionary<int , ClientBids> b , ProductSelectedDelegate ps , BidPlacedDelegate bp , ExitUser eu , string n)
        {
            exitUser = eu;
            productList = p;
            clientBids = b;
            productSelected = ps;
            bidPlaced = bp;
            clientName = n;
            InitializeComponent();
        }

        private void Bid501Client_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, mProduct> kvp in productList)
            {
                uxListBox.Items.Add(kvp.Value.ItemName);
            }
            uxClientName.Text = clientName;
            uxListBox.Refresh();
        }

        private void uxListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxListBox.SelectedItem != null)
            {
                string itemName = uxListBox.SelectedItem.ToString();
                int key = -1;

                foreach (KeyValuePair<int, mProduct> kvp in productList)
                {
                    if (kvp.Value.ItemName == itemName)
                    {
                        key = kvp.Key;
                        break;
                    }
                }
                if (key != -1)
                {
                    productSelected(key);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Unknown Item Selected");
                }
            }            
        }

        public void UpdateClientGUI(bool update, int key)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    mProduct product = productList[key];
                    if (update)
                    {
                        if (!uxListBox.Items.Contains(product.ItemName))
                        {
                            uxListBox.Items.Add(product.ItemName);
                        }
                        uxName.Text = product.ItemName;
                        uxTime.Text = Convert.ToString("Time Remaining");
                        numOfBids.Text = Convert.ToString("(" + product.NumberOfBids + ") Bids");
                        uxMinBid.Text = Convert.ToString(product.MinimumBid);
                        if (clientName == product.winnerName)
                        {
                            currentBid.BackColor = Color.Yellow;
                        }
                        else
                        {
                            currentBid.BackColor = Color.Blue;
                        }
                    }
                    else
                    {
                        uxListBox.Items.Remove(product.ItemName);
                        uxName.Text = "";
                        uxTime.Text = "";
                        label1.Text = "";
                        uxMinBid.Text = "";
                    }
                    uxListBox.Refresh();
                }));
            }
            catch
            {
                exitUser(clientName);
            }
            
        }

        public void AddProductToList(int key)
        {
            uxListBox.Items.Add(productList[key].ItemName);
            uxListBox.Refresh();
        }

        private void placeBid_Click(object sender, EventArgs e)
        {
            bidPlaced(uxName.Text, Convert.ToDouble(textBox.Text));
        }

        public void RemoveName(string name)
        {
            Invoke(new Action(() => uxListBox.Items.Remove(name)));
            //uxListBox.Items.Remove(name);
        }
        
        private void Bid501Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitUser("Exit,");
        }

        private void Bid501Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            exitUser("Exit,");
        }
    }
}
