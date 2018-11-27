 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doggie;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";

            // To do: uncomment the following lines of code to call the methods
            myDog.bark();
            myDog.doTrick("Fetch");

            Console.Read();

        }

        public double getArea(double height, double width)
        {
            return width * height;
            //2)
            // a.Scope: Scope is the area where a variable is valid. The scope of getArea is the getArea class. For example, the parameters height and width are only valid within the curly braces of the getArea class, you can not use them anywhere else
            // b.Static vs. Non - Static: A static variable / method cannot be instantinized, meaning there is only one instance of a static variable / method in a class, all objects have the same variable for it, meaning they have the same copy
            // c.Return Type: A return type is the type that the method will return, whether it be int, string, or double. Return type must be defined in the method header and also returned in the body of the function. In the above example, the return type is double, as that is the type specified in the header and returned by the variables.
            // d.Method Name(Identifier): The identifier in a method is the name that you get it. It describes what you want to call the method you are using. getArea is the identifier of the method above.
            //e.Parameters: Parameters are the variables you enter into a function, that you may want to use in the method / function body below to perform some calculation, the parameters in the example above are height and width
            //f.Method Body: The method body is what calculations and statements are performed in the curly braces following the method header. The method body above conatins the return statement of width * height.

            //3) Difference between a user-defined method and a method that is provided with a framework.  What should we consider when creating a user-defined method?
                //The difference between a user defined method and one within the framework is that a user defined method is one in which the programmer defines in the program he is creating. It is a custom method, designed by him or her.  A method in the framework is one that the creators of C# created themselves and can be used in everyone's program.
                //When creating a user defined method, we should consider its usefulness in our project, and whether it is already provided in the .NET framework so we don't do something over again.

            //4)
                //The difference between a static and non static method is that a static method is one that exists outside of any instance, meaning any instance of the object will have the same method exactly. A non static method is one in which an instance of the method exists for every instance of the object.

                }
    }

}
