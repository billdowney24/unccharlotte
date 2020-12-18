﻿/* ****************************************************************************
 *
 * BRIEF //
 *
 *  In this exercise, you'll create a Student class to replace the student 
 *  Dictionary.
 *
 *  First, fill out Student.cs. Then come back to this file!
 *
 * ****************************************************************************
 *
 *  There's a new function in Helpers.cs, called `promptForAttribute (string attribute)`.
 *  It takes the name of an attribute, which will be displayed to the user, and
 *  returns what they enter in response.
 *
 *  For example, you can do: 
 *
 *    string firstName = promptForAttribute("first name");
 *
 *  This will write to the console with:
 *
 *      "Please enter the student's first name."
 *
 *  ...And store the user's resposne in the `firstName` variable.
 *
 *  Do this for every attribute you set on your Student, and use the user's input to
 *  set their values appropriately.
 *
 ***************************************************************************** */

using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(String[] args)
        {
            while (true)
            {
                Dictionary<string, string> student = new Dictionary<string, string>();

                // An example of a good use case for arrays over array lists.
                string[] attributes = new string[] { "first name", "last name", "middle name",
                    "address", "email", "phone number" };

                foreach (string attribute in attributes)
                {
                    Helpers.saveAttribute(attribute, student);
                }

                Helpers.printEntries(student);

                if (!Helpers.confirm())
                {
                    break;
                }
            }
        }
    }
}
