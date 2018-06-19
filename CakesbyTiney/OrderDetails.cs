using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakesbyTiney
{
    class OrderDetails
    
    {
        #region Properties
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderTotal { get; set; }
        private decimal MaterialTotal { get; set; }
        public int CakeSize { get; set; }
        public string CakeFlavor { get; set; }
        public int DateNeeded { get; set; }
        private decimal TotalBalance { get; set; }

        #endregion

        #region Methods


        private decimal CakeOrder(decimal balance)
        {
             TotalBalance  += OrderTotal;
            return balance;
        }

        private decimal MaterialCost(decimal balance)

        {
            TotalBalance -= MaterialTotal;
            return balance;
        }
        #endregion
    }
}
