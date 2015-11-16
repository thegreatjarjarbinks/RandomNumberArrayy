/*
 * Created by: Alex Mathias
 * Created on: 16-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 5-03
 * This program displays A lower number in array finder
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberArray
{
    public partial class frmRandomNumberArray : Form
    {
        public double ArrayFinder (double[] array)
        {
            //Variables
            double smallestNumber = array[0];

            foreach (double numberValue in array)
            {
                if(numberValue < smallestNumber)
                {
                    smallestNumber = numberValue;
                }
                
            }
            return smallestNumber;
        }
        public frmRandomNumberArray()
        {
            InitializeComponent();
        }

        private void frmRandomNumberArray_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Variables
            double smallestNumber;
            double[] NumberArray = new double[10];
            Random randomNumberGenerator = new Random();

            //Process
            for (int counter = 0; counter < 10; counter++)
            {
                NumberArray[counter] = randomNumberGenerator.Next(1, 10 + 1);
                this.lstNumbers.Items.Add(NumberArray[counter]);
            }
            smallestNumber = ArrayFinder(NumberArray);
            this.lblSmallestNumber.Text = "The smallest number is: " + smallestNumber;
        }
    }
}
