using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// File Prologue
// Name: Kyle 
// Project: Project 8 
// Date: <3/19/2015
// Program to roll dice 


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.



namespace proj_08_KHR_V1._0.zip
{
    public partial class Form1 : Form
    {
        // declare reference variable to the dice object 
        private Dice theDice;


        // form constructor 
        // purpose: to make the form and the dice object
        // parameters: none 
        // Returns: none 

        public Form1()
        {
            InitializeComponent();
            theDice = new Dice();
        }

        // The event handleer for the roll button 
        // purpose: roll the dice 
        // parameters: the button object and event arguments
        // Returns: none 

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kyle Raja\nCS1400\nproject 8");
        }

        // This is the Event Handler for the button 
        // purpose: roll the dice 
        // Parameters: button object and event arguments 
        // Returns: none 
        private void button1_Click(object sender, EventArgs e)
        {
            dice1Txt.Clear();
            dice2Txt.Clear();
            theLabel.Text = "";

            // now we roll the dice 
            theDice.Rollem();

            // now we get the string and put them in the text boxes 

            string dice1String = "", dice2String = "";
            
            theDice.GetRoll(ref dice1String, ref dice2String);

            dice1Txt.Text = dice1String;
            dice2Txt.Text = dice2String;


            // we need to display Boxcars or snake eyes when we get a certian value between the two dices

            if (theDice.RollIsBoxCars())
                theLabel.Text = "BOX CARS!";

            else if (theDice.RollIsSnakeEyes())
                theLabel.Text = "SNAKE EYES!";

        

           


        }
    }
}
