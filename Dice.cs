using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_08_KHR_V1._0.zip
{
    // This is the Dice Class and it represents a pair of dice and then we do the dice calculations

 
    class Dice
    {
        //define integers
        // numOne is the value of the first die 
        // numTwo is the value of the second die 
        // we create a random number generator by using the private Random
        // we use this for writing patters 


        private int numOne; 
        private int numTwo;
        private Random randomRoll;
        const int BOX = 6;
        static string nL = System.Environment.NewLine; 

        // show the face of the dice. 
        // now we do numbers 1-6
        private string[] DIE_FACE = {
                                        nL + "l",
                                        "l" + nL + nL + "l", 
                                        "l" + nL + "l" + nL + "l" , 
                                        "l l" + nL + nL + "l l", 
                                        "l l" + nL + " l "+ nL + "l l", 
                                        "l l" + nL + "l l " + nL + "l l" };

        // The Dice Constructor 
        // Purpose: this will initialize the dice values that I just created and use the random number Generator 
        // Parameters: none 
        // Return none 

        public Dice()
        {

            numOne = 0;
            numTwo = 0; 
            randomRoll = new Random();


        }

        // Rollem method 
        // purpose: to create the values for the dice 
        // Paremeters: none 
        // Return: none 


        public void Rollem()

        {

            numOne = randomRoll.Next(1, BOX + 1);
            numTwo = randomRoll.Next(1, BOX + 1);
           

        }

        // GetRoll method
        // Purpose: strings for the dice roll 
        // Parameters: a reference by two strings
        // returns: none 

        public void GetRoll(ref string str1, ref string str2)

        {
            str1 = GenerateString(numOne);
            str2 = GenerateString(numTwo);
        

        }

        // The RollIsBoxCars Method 
        // Purpose: see if the dice values to see if in boxcars
        // Parameters: none 
        // Returns: True if boxcars, else false
        
        public bool RollIsBoxCars()

        {
            if (numOne == BOX && numTwo == BOX)
                return true;
            else 
                return false;
            
        }

        // The RollIsSnakeEyes Method 
        // Purpose: see if the dice values to see if its snake eyes 
        // Parameters: none 
        // Returns: true if snake-eyes, else false 

        public bool RollIsSnakeEyes()

        {
            if (numOne == 1 && numTwo == 1)
                return true;
            else 
                return false;

        }

        // Generator String Method
        // Purpose: do a string that defines the value on the face of the dice 
        // Parameters: The value of the dice
        // Returns: there will be dots with a string and will show what the dice will look like

        public string GenerateString(int roll)
        {
            return DIE_FACE[roll - 1];
        

         }
    }
}
