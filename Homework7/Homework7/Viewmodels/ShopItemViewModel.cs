using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework7.Viewmodels
{
    public class ShopItemViewModel
    {
        private string mName;
        private string mDescription;
        private double mPrice;
        private int mQuantityAvailable;

        public ShopItemViewModel()
        {
            this.mName = "";
            this.mDescription = "";
            this.mPrice = 0;
            this.mQuantityAvailable = 0;
        }

        public ShopItemViewModel(string mName, string mDescription, double mPrice, int mQuantityAvailable)
        {
            this.mName = mName;
            this.mDescription = mDescription;
            this.mPrice = mPrice;
            this.mQuantityAvailable = mQuantityAvailable;
        }

        public string Name
        {
            get { return this.mName; }
            set { this.mName = value; }
        }

        public string Description
        {
            get { return this.mDescription; }
            set { this.mDescription = value; }
        }

        public double Price
        {
            get { return this.mPrice; }
            set { this.mPrice = value; }
        }

        public int QuantityAvailable
        {
            get { return this.mQuantityAvailable; }
            set { this.mQuantityAvailable = value; }
        }
    }
}