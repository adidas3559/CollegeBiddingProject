using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bid501_Server
{
    public class mProduct
    {
        private static int ID = 1;
        private int productID;
        string _itemName;
        double _minimumBid;
        mStatus _status;
        int _numberOfBids;
        string winner;


        public mProduct(string item, double min)
        {
            ProductID = GetID();
            _itemName = item;
            _minimumBid = min;
            winner = "";
            //_numberOfBids = bids;
        }

        /*
        public mProduct(string item, double min, mStatus status, double time, int bids)
        {
            _itemName = item;
            _minimumBid = min;
            _status = status;
            _timeRemaining = time;
            _numberOfBids = bids;


        }
        */

        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = value;
            }

        }

        public string winnerName
        {
            get
            {
                return winner;
            }
            set
            {
                winner = value;
            }
        }

        public double MinimumBid // current bid
        {
            get
            {
                return _minimumBid;
            }
            set
            {
                _minimumBid = value;
            }

        }
        public mStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }

        }
        
        public int NumberOfBids
        {
            get
            {
                return _numberOfBids;
            }
            set
            {
                _numberOfBids = value;
            }

        }

        public int ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }
        
        public bool currentProduct
        {
            get;
            set;
        }


        public static void SetID(int value)
        {
            ID = value;
        }
        public static int GetID()
        {
            return ID++;
        }

        public override string ToString()
        {
            return _itemName + "," + _minimumBid + "," + _status + "," + _numberOfBids + ",";
        }
    }
}
