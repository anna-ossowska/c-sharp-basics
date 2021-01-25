using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversion without loses:
            // byte b = 1;
            // int i = b;

            // For a byte max is 255, so some of the bits must be lost. We get 232 as an final output.
            // int i = 1000;
            // Casting:
            // byte b = (byte)i;
            // Console.WriteLine(b);

            // Converting the string to integer using the ToInt32 method (belonging to the Convert class)
            // var number = "12345";
            // int i = Convert.ToInt32(number);
            // Console.WriteLine(i);

            // Handling the exception | string to a byte
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a byte.");
            }

            // Handling the exception | string to a boolean
            try
            {
                string str = "true";
                bool bl = Convert.ToBoolean(str);
                Console.WriteLine(bl);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a boolean.");
            }

        }
    }
}
