using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//TFD: For each item in the Vending Machine assign a cost value and a string to represent it.
//HIW: Old school getter and setter methodology (get and set without shortcut

namespace Vending_Machine
{
    class Slots
    {
        
        private double slotCost;

        public double SlotCost { get => slotCost; set => slotCost = value; }

        
        public Slots()
        {
            this.slotCost = 0.00;
        }

        // override the ToString method to represent monetary value.
        override public string ToString()
        {
            string cost = "$ " + ((decimal)this.SlotCost).ToString("0.00");
            return cost;
        }

    }
}
