using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace Bid501
{
    class cBid501Client
    {
        Dictionary<int, mProduct> productList;
        Dictionary<int, ClientBids> clientBids;// does nothing :(
        RemoveProductDelegate removeProduct;
        AddProductDelegate addProduct;
        UpdateClientGUIDelegate updateClientGUI;
        WebSocket ws;
        private string clientNumber;

        public cBid501Client(Dictionary<int, mProduct> p, Dictionary<int, ClientBids> b, string n)
        {
            productList = p;
            clientBids = b;
            clientNumber = n;
            ws = new WebSocket("ws://127.0.0.1:9555/product");
            ws.OnMessage += (sender, e) => { MessageReceived(e.Data); };
            ws.Connect();
            ws.Send("Client," + n);
        }

        public void MessageReceived(string message)
        {
            string[] msgParts = message.Split(',');

            if (msgParts[0].Equals("Expired"))
            {
                int ID = -1;
                foreach (var p in productList.Values)
                {
                    if (p.ItemName.Equals(msgParts[1]))
                    {
                        removeProduct(msgParts[1]);
                        ID = p.ProductID;
                        
                        if(p.winnerName != "0")
                        {
                            MessageBox.Show("Product " + msgParts[1] + " expired!  The winner was " + p.winnerName);
                        }
                        
                    }
                }
                productList.Remove(ID);
            }
            else if (msgParts[0].Equals("Product"))
            {
                string[] msgParts2 = message.Split('^');

                for (int i = 0; i < msgParts2.Length; i++)
                {
                    string[] currentProduct = msgParts2[i].Split(',');
                    string name = currentProduct[1];
                    string minSaleAmt = currentProduct[2];
                    string winner = currentProduct[4];
                    mProduct product = MakeProduct(name, minSaleAmt, winner);
                    productList.Add(product.ProductID, product);
                    if(updateClientGUI != null)
                    {
                        updateClientGUI(true, product.ProductID);
                    }                    
                }
            }
            else if (msgParts[0].Equals("Bid"))
            {
                int key = 0;
                mProduct product = null;

                foreach (KeyValuePair<int, mProduct> kvp in productList)
                {
                    if (kvp.Value.ItemName.Equals(msgParts[1]))
                    {
                        key = kvp.Key;
                        product = kvp.Value;
                        break;
                    }
                }
                product.winnerName = msgParts[2];
                product.MinimumBid = Convert.ToDouble(msgParts[3]);
                //product.NumberOfBids++;/////////////////////////////////////////////////////////////////////////////////bids
                product.NumberOfBids = Convert.ToInt32(msgParts[4]);
                productList[key] = product;
                updateClientGUI(true, key);
            }
        }

        public mProduct MakeProduct(string name, string minSaleAmt, string winner)
        {
            mProduct p = new mProduct(name, Convert.ToDouble(minSaleAmt));
            p.winnerName = winner;
            return p;
        }

        public void AddProduct(mProduct product)
        {
            bool notInList = true;
            foreach (KeyValuePair<int, mProduct> kvp in productList)
            {
                if (kvp.Value.ItemName == product.ItemName)
                {
                    notInList = false;
                }
            }

            if (notInList)
            {
                productList.Add(product.ProductID, product);
                addProduct(product.ProductID);
                ws.Send("Product," + product.ToString());
            }

        }

        public void bidPlace(string productName, double bidAmount)
        {

            int key = 0;
            mProduct product = null;

            foreach (KeyValuePair<int, mProduct> kvp in productList)
            {
                if (kvp.Value.ItemName.Equals(productName))
                {
                    key = kvp.Key;
                    product = kvp.Value;
                    break;
                }
            }
            if (bidAmount >= product.MinimumBid)
            {
                product.winnerName = clientNumber;
                product.MinimumBid = bidAmount;
                product.NumberOfBids++;//////////////////////////////////////////////////////////////////////////////////
                productList[key] = product;

                ws.Send("Bid," + productName + "," + clientNumber + "," + product.MinimumBid + "," + product.NumberOfBids);
            }
            else
            {
                MessageBox.Show("Bid too low!");
            }
        }
        
        public void productSelected(int key)
        {
            if (productList.ContainsKey(key))
            {
                updateClientGUI(true, key);
            }
        }

        public void sendUserExitMessage(string message)
        {
            ws.Send(message + clientNumber);
        }

        public void setUpdateClientGUIDelegate(UpdateClientGUIDelegate del)
        {
            updateClientGUI = del;
        }

        public void SetAddProductDelegate(AddProductDelegate d)
        {
            addProduct = d;
        }

        public void SetRemoveNameDelegate(RemoveProductDelegate r)
        {
            removeProduct = r;
        }

        
    }
}
