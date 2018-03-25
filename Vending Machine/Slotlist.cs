using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class SlotList
    {// Inition
        private Slots[] sList;
        public Slots[] SList { get => sList; set => sList = value; }

        //double depot = 0.00;
        /// <summary>
        /// 
        /// </summary>
        /// <param></param>
        public SlotList(double cash)
        {
            
            //this.depot = cash; 
            this.sList = new Slots[] {new Slots(), new Slots(), new Slots(), new Slots(),
            new Slots(), new Slots(), new Slots(), new Slots(),  new Slots() };
        }

        public SlotList()
        {
            
            //this.depot = 0.00;
            this.sList = new Slots[] {new Slots(), new Slots(), new Slots(), new Slots(),
            new Slots(), new Slots(), new Slots(), new Slots(),  new Slots() };
        }

        public void initializeSlots(Slots[] sList)
        {
            int num = sList.Length;
            Slots[] mats = this.sList;
            //double price;
            for(int i = 0; i < num; i++)
            {
               mats[i].SlotCost = ((1.00 + (0.25 * i))); 
            } 
        }
    }
}
