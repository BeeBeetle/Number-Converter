using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Engine
{
    public class NumberChanger
    {
        //this will be our final output
        string finalNumber = "";
        //this is our master list of characters, it gets wonky at the end
        //but that's ok when we need to go out to base 92
        //these are the order in which they will appear, so at base 11 the next "number" to be used will be A
        //to change it to something else simply reorder the string below
        char[] numbersArray = "0123456789ABCDEF†GHIJKL|MNOPQRƒS‡TuµVWXYZabcde¦þhijklmnøpqrs§ÅŠØŸ×ÂÃÄÈÉÊËÌÍ¤ÀÁÎÏŽÑÒÓÔÕÖÙÚÜÛÝ".ToCharArray();

        //this is where the magic happens, we first define that we need ulongs in case someone wants to do a real big number!
        public string ConvertFrom10(ulong toConvNumber, ulong targetBase)
        {
            //as long as the working number is not 0 we keep going through the loop
            //if it ever reaches 0 that means the base has been divided for the last time
            //any further division is useless and would only return 0
            while (toConvNumber != 0)
            {
                //this sets our remainder which will determine each character in our new number
                ulong remainder = toConvNumber % targetBase;
                //this pulls the character from our array based on its position via the remainder
                //the 35th character in the array is Z
                //with a remainder of 35 Z would be the next character added to our final number 
                //it is important that the next number is added to the front of the string because the division
                //causes the number to be calculated in reverse, so 28 to Hex would come out as C1 instead of 1C
                //if we added to the end of finalNumber
                finalNumber = numbersArray[remainder] + finalNumber;
                //this resets the working number such that the math works, I can't think of a good way to explain it
                toConvNumber = toConvNumber / targetBase;
            }
            //finally we take our finished number and send it back to the rest of the program!
            return finalNumber;
        }

        //with the above code to convert from base 10 to another base all we need is to be able to revert back to base 10
        //applying this followed by the above code will allow you to convert from any base to any other base
        //because we can ALWAYS convert from 10 to anything
        public string ConvertTo10(string inputNumber, ulong startingBase)
        {
            string outputString = "";
            double outputNumber = 0;
            char[] inputArray = inputNumber.ToCharArray();
            //this guy ensures our exponent will be correct, because a number with 3 digits will need the exponents 2, 1, and 0
            int subPosition = (inputNumber.Length) - 1;
            foreach (char c in inputArray)
            {
                int masterPosition = Array.IndexOf(numbersArray, c);
                //the math here is (x*(B^d))+(x*(B^d-1) ...
                //where x is the value of the symbol you are converting to 10, B is the base you are currently in
                //and d is the position in that number where the lowest position is 0 (just like starting from 0 w/ programming)
                //for F1A in hex you would have (15*(16^2))+(1*(16^1))+(10*(16^0)) = 3840 + 16 + 10 = 3866
                //at some point I could even go to decimals because the pattern continues
                //so for x.ya it would be 16^0 + 16^-1 + 16^-2 and so on
                double x = masterPosition * Math.Pow(startingBase, subPosition);
                outputNumber += x;
                subPosition -= 1;
            }
            return Convert.ToString(outputNumber);
        }
    }
}
