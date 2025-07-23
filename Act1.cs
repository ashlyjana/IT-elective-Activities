using System; 

using System.Collections.Generic; 

using System.Linq; 

using System.Text; 

using System.Threading.Tasks;  

namespace Ass1act1 

{ 

    internal class Program 

    { 

        static void Main(string[] args) 

        { 

            string FirstName; 

            string LastName; 

  

            Console.Write("Enter your FirstName: "); 

            FirstName = Console.ReadLine(); 

  

            Console.Write("Enter your LastName: "); 

            LastName = Console.ReadLine(); 

  

            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName)) 

            { 

                Console.WriteLine("Reject empty input fields."); 

            } 

            else 

            { 

                Console.WriteLine("Your name is " + FirstName + " " + LastName); 

            } 

  

             

        } 

    } 

} 
