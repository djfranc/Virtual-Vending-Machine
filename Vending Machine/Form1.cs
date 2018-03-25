using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * TFD = The Following Does
 * FNFI = Future Notes For Improvement
 * PI = Personal Ideas
 * HIW: How it Works
 */


/*
 * The Form class in the Vending_Machine namespace is in charge of maintaining the Form and the events within the elements included within
 * the Form window.
 * Assessment Summary (Criticism): Too much repetition major code shrinkage needed. Find problem areas by searching with #CodeShrink.
 */
namespace Vending_Machine
{
    public partial class Form1 : Form
    {

        Wallet wallet = new Wallet();
        SlotList merchandise = new SlotList();

        //TFD: initializing into the respective slots, initializing the form window component
        //FNFI: Text initialization could be simplified into an array of buttons 
        public Form1()
        {

           
           
            
            InitializeComponent();

            //PI: method, (static or template) for initializing all of following Texts possibly another merchandise function. #CodeShrink
            //HIW: assign array with price info to Text on form Load. (Can be changed to be dynamic)
            merchandise.initializeSlots(merchandise.SList);
            this.a1.Text = "A1\n\n" + merchandise.SList[0].ToString();
            this.a2.Text = "A2\n\n" + merchandise.SList[1].ToString();
            this.a3.Text = "A3\n\n" + merchandise.SList[2].ToString();
            this.a4.Text = "A4\n\n" + merchandise.SList[3].ToString();
            this.a5.Text = "A5\n\n" + merchandise.SList[4].ToString();
            this.a6.Text = "A6\n\n" + merchandise.SList[5].ToString();
            this.a7.Text = "A7\n\n" + merchandise.SList[6].ToString();
            this.a8.Text = "A8\n\n" + merchandise.SList[7].ToString();
            this.a9.Text = "A9\n\n" + merchandise.SList[8].ToString();
          
        }

        
        //Empty
        private void cashLabel_Click(object sender, EventArgs e)
        {

        }

        //TFD: (a1-a9)_Click merchandise manages the Purchasing events initiated by 
        //clicking the buttons on the left side of the Form.
        
        
        //FNFI: #CodeShrink
        //HIW: if smaller than the Wallet, substract from Total and give change (applies for a1-click - a9-click)
        private void a1_Click(object sender, EventArgs e)
        {
            if (wallet.Change > merchandise.SList[0].SlotCost)
            {
                wallet.Change -= merchandise.SList[0].SlotCost;
                label2.Text = wallet.GiveChange();
            }
            else
                label2.Text = "Not enough money available!";
            label3.Text = "$ " + wallet.Change.ToString("0.00");

        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (wallet.Change > merchandise.SList[1].SlotCost)
            {
                wallet.Change -= merchandise.SList[1].SlotCost;
                label2.Text = wallet.GiveChange();
            }
            else
                label2.Text = "Not enough money available!";
            label3.Text = "$ " + wallet.Change.ToString("0.00");
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (wallet.Change > merchandise.SList[2].SlotCost)
            {
                wallet.Change -= merchandise.SList[2].SlotCost;
                label2.Text = wallet.GiveChange();
            }
            else
                label2.Text = "Not enough money available!";
            label3.Text = "$ " + wallet.Change.ToString("0.00");
        }

        private void a4_Click(object sender, EventArgs e)
        {
            if (wallet.Change > merchandise.SList[3].SlotCost)
            {
                wallet.Change -= merchandise.SList[3].SlotCost;
                label2.Text = wallet.GiveChange();
            }
            else
                label2.Text = "Not enough money available!";
            label3.Text = "$ " + wallet.Change.ToString("0.00");
        }

        private void a5_Click(object sender, EventArgs e)
        {
            if (wallet.Change > merchandise.SList[4].SlotCost)
            {
                wallet.Change -= merchandise.SList[4].SlotCost;
                label2.Text = wallet.GiveChange();
            }
            else
                label2.Text = "Not enough money available!";
            label3.Text = "$ " + wallet.Change.ToString("0.00");
        }

        private void a6_Click(object sender, EventArgs e)
        {
            if (wallet.Change > merchandise.SList[5].SlotCost)
            {
                wallet.Change -= merchandise.SList[5].SlotCost;
                label2.Text = wallet.GiveChange();
            }
            else
                label2.Text = "Not enough money available!";
            label3.Text = "$ " + wallet.Change.ToString("0.00");
        }

        private void a7_Click(object sender, EventArgs e)
        {
            if (wallet.Change > merchandise.SList[6].SlotCost)
            {
                wallet.Change -= merchandise.SList[6].SlotCost;
                label2.Text = wallet.GiveChange();
            }
            else
                label2.Text = "Not enough money available!";
            label3.Text = "$ " + wallet.Change.ToString("0.00");
        }

        private void a8_Click(object sender, EventArgs e)
        {
            if (wallet.Change > merchandise.SList[7].SlotCost)
            {
                wallet.Change -= merchandise.SList[7].SlotCost;
                label2.Text = wallet.GiveChange();
            }
            else
                label2.Text = "Not enough money available!";
            label3.Text = "$ " + wallet.Change.ToString("0.00");
        }

        private void a9_Click(object sender, EventArgs e)
        {
            if (wallet.Change > merchandise.SList[8].SlotCost)
            {
                wallet.Change -= merchandise.SList[8].SlotCost;
                label2.Text = wallet.GiveChange();
            }
            else
                label2.Text = "Not enough money available!";
            label3.Text = "$ " + wallet.Change.ToString("0.00");
            
        }

        //Empty
        private void label3_Click(object sender, EventArgs e)
        {

        }

        //HIW: Event Manager for $ 0.05 button. Add to total output in string
        private void nickelButton_Click(object sender, EventArgs e)
        {

            double num = wallet.AddToWallet(0.05);
            label3.Text = num.ToString("0.00");
        }
        

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        //HIW: Event Manager for $ 0.25 button. Add to total output in string
        private void quarterButton_Click(object sender, EventArgs e)
        {
            double num = wallet.AddToWallet(0.25);
            label3.Text ="$ " + num.ToString("0.00");
            
        }

        //HIW: Event Manager for $ 2.00 button. Add to total output in string
        private void toonButton_Click(object sender, EventArgs e)
        {
            double num = wallet.AddToWallet(2.00);
            label3.Text ="$ " + num.ToString("0.00");
        }

        //HIW: Event Manager for $ 0.10 button. Add to total output in string
        private void dimeButton_Click(object sender, EventArgs e)
        {
            double num = wallet.AddToWallet(0.10);
            label3.Text ="$ " + num.ToString("0.00");
        }

        //HIW: Event Manager for $ 1.00 button. Add to total output in string
        private void loonButton_Click(object sender, EventArgs e)
        {
            double num = wallet.AddToWallet(1.00);
            label3.Text = "$ " + num.ToString("0.00");
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        //HIW: Reset total, wallet and output change values
        private void button6_Click(object sender, EventArgs e)
        {

            label2.Text = wallet.GiveChange();
            wallet.Change = 0.00;
            double num = wallet.Change;
            label3.Text = "$ " + num.ToString("0.00");
        }
    }
}
