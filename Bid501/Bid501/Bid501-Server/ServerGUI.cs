using Bid501;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Bid501_Server
{
    public partial class ServerGUI : Form
    {
        private static mProductDatabase _productDatabase;
        private BroadcastMessage broadCastMessage;
        private ExpireMessage expireMessage; //NEW FOR TIME UP

        public ServerGUI(mProductDatabase pd)
        {
            _productDatabase = pd;

            InitializeComponent();

            auctionBindingSource.DataSource = pd._productList;
        }

        private void ServerGUI_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _productDatabase._productList.Count; i++)
            {
                var product = _productDatabase._productList[i];
                uxCurrentProducts.Items.Add(product);
            }

        }

        public void UpdateCurrentList()
        {
            Invoke(new Action(() =>
            {
                uxCurrentProducts.Items.Clear();
                for (int i = 0; i < _productDatabase._productList.Count; i++)
                {
                    uxCurrentProducts.Items.Add(_productDatabase._productList[i]);
                }
            }));
        }

        public void setCurrentList()
        {
            var product = _productDatabase._productList[0];
            string s = product.ToString();
            broadCastMessage(s);
            product = _productDatabase._productList[1];
            broadCastMessage(product.ToString());
            product = _productDatabase._productList[2];
            broadCastMessage(product.ToString());
            product = _productDatabase._productList[3];
            broadCastMessage(product.ToString());
        }

        public void SetBroadcastDelegate(BroadcastMessage del)
        {
            broadCastMessage = del;
            setCurrentList();
        }

        public void SetExpireDelegate(ExpireMessage del)
        {
            expireMessage = del;
        }

        public void AddProduct(string product)
        {
            Invoke(new Action(() =>
            {
                uxCurrentProducts.Items.Add(product);
            }));
        }

        public void RemoveProduct(string product)
        {
            Invoke(new Action(() =>
            {
                uxCurrentProducts.Items.Remove(product);
            }));
        }

        public void AddUser(string name)
        {
            Invoke(new Action(() => uxCurrentBidders.Items.Add(name)));
            setCurrentList();
        }

        public void exitUser(string user)
        {
            Invoke(new Action(() => uxCurrentBidders.Items.Remove(user)));
        }

        private void uxTimeUp_Click(object sender, EventArgs e)
        {
            if(uxCurrentProducts.SelectedIndex != -1)
            {
                var product = _productDatabase._productList.ElementAt(uxCurrentProducts.SelectedIndex);
                //_socket.OnMessage += (sender, e) => { Expired(e.Data); };
                expireMessage(product.ToString());
            }           
        }
    }
}
