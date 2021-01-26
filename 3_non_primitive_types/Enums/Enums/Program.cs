using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method); // Express

            // Converting enum to integer (using casting)
            Console.WriteLine((int)method); // 3

            // Converting integer to enum
            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId); // RegisterdAirMail

            // Converting enum to string
            Console.WriteLine(method.ToString());
            // Console.WriteLine by deafult calls a ToString() method on whatever you pass in
            Console.WriteLine(method);

            // Converting string to enum
            var methodName = "Express";
            // Parse method returns an object, we cast it to ShippingMethod
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
