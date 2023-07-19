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
        char[] numbersArray = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!#$%$'()*+,-./:;<=>?@[]^_`{}|~".ToCharArray();

        //this is where the magic happens, we first define that we need ulongs in case someone wants to do a real big number!
        public string ConversionMethod(ulong toConvNumber, ulong targetBase)
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
    }
}
