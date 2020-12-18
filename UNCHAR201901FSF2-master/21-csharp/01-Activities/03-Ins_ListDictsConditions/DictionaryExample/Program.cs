using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> studentInformation = new Dictionary<string, string>();

            // Adding items requires the Add method.
            studentInformation.Add("firstName", "Jane");
            studentInformation.Add("lastName", "Doe");

            // Retrieving items
            string firstName = studentInformation["firstName"];

            // OR you can use TryGetValue()...
            // string firstName;
            // studentInformation.TryGetValue("firstName", out firstName);

            string lastName = studentInformation["lastName"];

            // OR you can use TryGetValue()...
            // string lastName;
            // studentInformation.TryGetValue("lastName", out lastName);

            Console.WriteLine("The student's first name is " + firstName + ".");
            Console.WriteLine("The student's last name is " + lastName + ".");

            // To iterate a dictionary, we examine each KeyValuePair within it with a foreach statement.
            foreach (KeyValuePair<string, string> entry in studentInformation)
            {
                // This looks a bit ugly. How can we make it prettier?
                Console.WriteLine("The student's " + entry.Key + " is " + entry.Value + ".");
            }
        }
    }
}
