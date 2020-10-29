using Bid501;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Bid501_Server
{

    public delegate void AddProductDelegate(string product);
    public delegate void RemoveProductDelegate(string product);
    public delegate void BroadcastMessage(string message);
    public delegate void ExpireMessage(string message);
    public delegate void AddUserDelegate(string username);
    public delegate void ProductObserver(List<mProduct> productList);
    public delegate void ExitUser(string message);
    public delegate void UpdateCurrentListDelegate();

    class Program
    {
        static mProductDatabase Hardlist;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var wss = new WebSocketServer(9555);
            wss.AddWebSocketService<ProductSocketBehavior>("/product");
            wss.Start();

            var products = new List<mProduct>();
            mProduct p1 = new mProduct("Arduino", 144.00);
            products.Add(p1);
            p1 = new mProduct("Tomagochi", 144.00);
            products.Add(p1);
            p1 = new mProduct("Furbi", 144.00);
            products.Add(p1);
            p1 = new mProduct("Nerf Gun", 144.00);
            products.Add(p1);

            
            Hardlist = new mProductDatabase(products);
            ServerGUI gui  = new ServerGUI(Hardlist);
            cAuction controller = new cAuction(gui.AddUser , Hardlist , gui.AddProduct , gui.RemoveProduct , gui.exitUser);
            controller.setUpdateCurrentListDelegate(gui.UpdateCurrentList);
            gui.SetBroadcastDelegate(controller.BroadcastMessage);
            gui.SetExpireDelegate(controller.ExpireMessage);//NEW FOR TIME UP
            Application.Run(gui);
            


        }
        
    }
}
