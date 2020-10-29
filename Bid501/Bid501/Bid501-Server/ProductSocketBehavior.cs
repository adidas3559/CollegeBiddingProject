using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

/// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//IMPORTANT NOTE BELOW, LINE 30!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
/// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Bid501_Server
{
    class ProductSocketBehavior : WebSocketBehavior
    {
        private static List<mProduct> productList = new List<mProduct>();
        protected override void OnOpen()
        {
            var sb = new StringBuilder();
            foreach (mProduct product in productList)
            {
                if (product.currentProduct)
                {
                    sb.Append("Product," + product.ToString() + "^");
                }

            }
            if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);

            ////////////////////////////////////////////////////////////
            ///If it continues crashing, add break point on this line
            Sessions.SendTo(this.ID, sb.ToString());
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            Sessions.Broadcast(e.Data);

        }
    }
}
