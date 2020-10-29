using Bid501;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bid501
{
    public partial class AddProdForm : Form
    {
        AddProduct add;
        List<mProduct> products = new List<mProduct>();
        int count = 0;
        mProduct p1 = new mProduct("Walkman", 144.00);
        int limit = 0;

        /*
        private mProductDatabase _productDatabase = new mProductDatabase();
        private ServerGUI APF;
        private int _count=0;
        */

        public AddProdForm(AddProduct a)
        {
            add = a;
            products.Add(p1);
            products.Add(new mProduct("Stevie Wonder CD", 144.00));
            products.Add(new mProduct("Michael Jordan Sneakers", 144.00));
            products.Add(new mProduct("Oculus Rift", 144.00));
            products.Add(new mProduct("Death Star (full size)", 144.00));
            limit = limit + 5;


            InitializeComponent();

            /*
            AddingNewEventArgs = async;
            while (_count < 4)
            {
                _productDatabase.UpdateProductDatabase();
                
                _count++;
            }

            for (int i =0; i < 7; i++)
            {
                mProduct product = _productDatabase._productHardList.ElementAt(i);
                uxAvailableProductsList.Items.Add(product.ItemName);
            }  
            */

        }

        private void uxAddItemButton_Click(object sender, EventArgs e)
        {
            if(count < limit)
            {
                add(products[count]);
                count++;
            }

            /*
            APF.updateGrid();
            if (uxAvailableProductsList.Items.Count != 0)
            {
                uxAvailableProductsList.Items.RemoveAt(0);
            }

            if (uxAvailableProductsList.Items.Count == 0)
            {
                uxAvailableProductsList.Items.Add( "No more products to add!!!");
            }
            Hide();
            */

        }
    }
}
