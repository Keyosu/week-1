using sc = System.Console;

namespace Revature.Week1.HelloWorld //namespace scope
{
    //class, struct, interface, enum only scopes available to the namespace

    class Program //class scope
    {
        private static void Main() //method scope
        {
            // stdin to get your name
            sc.WriteLine("Enter your Class");
            // string in;
            var input = sc.ReadLine(); // datatype inference
            //object starklight = "Paladin"; // anonymous datatype
            // stdout to print your name
            sc.WriteLine("Hello my name is {input}");
        }
        private void UiPath()
        {
            {   // block scope   
            }

            {   // block scope
            }

        }
    }
}
