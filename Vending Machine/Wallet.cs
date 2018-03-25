using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Wallet
    {
        private int coinNum = 0;
        
        private const double toon = 2.00;
        const double loon = 1.00;
        const double quarter = 0.25;
        const double dime = 0.10;
        const double nickle = 0.05;
        private string msgForUser = "";

        public double Change { get; set; }

        public Wallet()
        {
            this.Change = 0.00;
        }

        public double AddToWallet(double money)
        {
            return Change += money;
        }

        public string GiveChange()
        {
            coinNum = 0;
            double temp = Change;
            
           if (Change != 0)
            {
                msgForUser = "";

                coinNum = (int)(temp / toon);
                msgForUser += coinNum + " Toonies\n";
                temp = temp % toon;

                coinNum = (int)(temp / loon);
                msgForUser += coinNum + " Loonies\n";
                temp = temp % loon;

                coinNum = (int)(temp / quarter);
                msgForUser += coinNum + " Quarters\n";
                temp = temp % quarter;

                coinNum = (int)(temp / dime);
                msgForUser += coinNum + " Dimes\n";
                temp = temp % dime;

                coinNum = (int)(temp / nickle);
                msgForUser += coinNum + " Nickles\n";
                temp = temp % nickle;
            }

            return msgForUser;

        }
    }
     
    
}
