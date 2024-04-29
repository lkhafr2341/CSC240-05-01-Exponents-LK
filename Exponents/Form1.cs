using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Lumumba Khafra
 * Date:04/28/2024
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
           
            // STORAGE
            int userInput;
            int squareResult;
            int cubeResult;
            

            // INPUT
            if (!int.TryParse(xInputTextBox.Text, out userInput))
            {
                MessageBox.Show("Please enter a valid integer.");
                return;
            }

            // PROCESS
            squareResult = Square(userInput);
            cubeResult = Cube(userInput);

            // OUTPUT
            xOutputLabel.Text = $"Square: {squareResult}";
            xOutputLabel.Text = $"Cube: {cubeResult}";

            // set the output to visible
            xOutputLabel.Visible = true;

            // turn the Go button off
            xGoButton.Enabled = false;
        }

        public int Square(int num)
        {
            // we will create this code in class
            return num * num;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
           
            // the input and output text should be emptied
            xInputTextBox.Text = "";
            xOutputLabel.Text = "";
            xOutputLabel.Text = "";

            // turn the output to invisible
            xOutputLabel.Visible = false;

            // turn the Go button back on
            xGoButton.Enabled = true;
        }

    }
}
