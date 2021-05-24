using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Subject
    {
        private int _quantity = 0;

        public delegate void QuantityUpdated(int quantity);
        public event QuantityUpdated OnQuantityUpdated;

        public void UpdateQuantity(int value)
        {
            _quantity += value;

            // alert any obeservers
            OnQuantityUpdated?.Invoke(_quantity);
        }
    }
}
