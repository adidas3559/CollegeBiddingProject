using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bid501
{
    public delegate void UpdateClientGUIDelegate(bool ok, int key);
    public delegate void AddProduct(mProduct product);
    public delegate void AddProductDelegate(int key);
    public delegate void ProductSelectedDelegate(int key);
    public delegate void BidPlacedDelegate(string name, double bid);
    public delegate void RemoveProductDelegate(string message);
    public delegate void ExitUser(string message);
    
    static class Program
    {
        static Dictionary<int, ClientBids> clientBids = new Dictionary<int, ClientBids>();
        static Random r = new Random();

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int num = r.Next(1000);
            string clientName = ("Client " + num);

            Dictionary<int, mProduct> products = new Dictionary<int, mProduct>();
            cBid501Client controller = new cBid501Client(products, clientBids, clientName);
            Bid501Client gui = new Bid501Client(products, clientBids, controller.productSelected, controller.bidPlace, controller.sendUserExitMessage , clientName);
            controller.setUpdateClientGUIDelegate(gui.UpdateClientGUI);
            AddProdForm addForm = new AddProdForm(controller.AddProduct);
            controller.SetAddProductDelegate(gui.AddProductToList);
            controller.SetRemoveNameDelegate(gui.RemoveName);

            addForm.Show();
            Application.Run(gui);
        }

    }
}
