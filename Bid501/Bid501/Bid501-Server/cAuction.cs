
using System;
using System.Linq;
using WebSocketSharp;

namespace Bid501_Server
{
    class cAuction
    {
        private mProductDatabase productDatabase;
        private AddUserDelegate addUser;
        private WebSocket ws;
        private AddProductDelegate addProduct;
        private RemoveProductDelegate removeProduct;
        private ExitUser exitUser;
        private UpdateCurrentListDelegate updateCurrentList;



        public cAuction(AddUserDelegate au, mProductDatabase pd, AddProductDelegate ap, RemoveProductDelegate rp, ExitUser eu) {
            addProduct = ap;
            removeProduct = rp;
            exitUser = eu;
            addUser = au;
            productDatabase = pd;
            ws = new WebSocket("ws://127.0.0.1:9555/product");
            ws.OnMessage += (sender, e) => { Recieve(e.Data); };
            ws.Connect();
        }

        public void Recieve(string msg)
        {
            string[] msgParts = msg.Split(',');

            if (msgParts[0].Equals("Client"))
            {
                addUser(msgParts[1]);
            }
            else if (msgParts[0].Equals("Bid"))
            {
                for (int i = 0; i < productDatabase._productList.Count; i++)
                {
                    if (productDatabase._productList[i].ItemName.Equals(msgParts[1]))
                    {
                        productDatabase._productList[i].winnerName = msgParts[2];
                        productDatabase._productList[i].MinimumBid = Convert.ToDouble(msgParts[3]);
                        productDatabase._productList[i].NumberOfBids = Convert.ToInt32(msgParts[4]);
                        UpdateProductList();
                        break;
                    }
                }
            }
            else if (msgParts[0].Equals("Product"))
            {
                string name = msgParts[1];
                string min = msgParts[2];
                string winner = msgParts[3];
                mProduct product = MakeProduct(name, min, winner);
                product.currentProduct = true;
                bool alreadyIn = false;
                for (int i = 0; i < productDatabase._productList.Count; i++)
                {
                    if (productDatabase._productList[i].ItemName == name)
                    {
                        alreadyIn = true;
                    }
                }
                if (alreadyIn == false)
                {
                    productDatabase._productList.Add(product);
                    addProduct(product.ToString());
                }

            }
            else if (msgParts[0].Equals("Expired"))
            {
                string name = msgParts[1];
                mProduct p = productDatabase._productList.First(x => x.ItemName == name);
                productDatabase._productList.Remove(p);
                UpdateProductList();

            }
            else if (msgParts[0].Equals("Exit"))
            {
                exitUser(msgParts[1]);
            }
        }

        public mProduct MakeProduct(string name, string minbid, string winner)
        {
            mProduct p = new mProduct(name, Convert.ToDouble(minbid));
            p.winnerName = winner;
            return p;
        }

        private void UpdateProductList()
        {
            updateCurrentList();
        }

        public void setUpdateCurrentListDelegate(UpdateCurrentListDelegate del)
        {
            updateCurrentList = del;
        }

        public void BroadcastMessage(string message)
        {
            ws.Send("Product," + message);
        }

        public void ExpireMessage(string message)
        {
            ws.Send("Expired," + message);
        }
    }
}
