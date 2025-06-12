using System;
using System.Collections.Generic;
using System.Linq; // Needed for sorting

class Program
{
    static Dictionary<string, string> myDictionary = new Dictionary<string,
      string>(); // Declare and initialize the dictionary

    static void Main(string[] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("\nChoose an operation to perform on the dictionary");

            Console.WriteLine("a. populate the Dictionary");
            Console.WriteLine("b. Display Dictionary");
            Console.WriteLine("c. Remove a Key");
            Console.WriteLine("d. Add a New Key and Value");
            Console.WriteLine("e. Add a Value to an Existing Key");
            Console.WriteLine("f. Sort the Keys");
            Console.WriteLine("g. Exit");
            Console.writeLine("Enter your choice: ");

            string choice = Console.ReadLine().ToLower(); // Read user input 
            and convert to lowercase

            switch (choice)
            {
                case "a":
                    PopulateDictionary();
                    break;
                case "b":
                    DisplayDictionary();
                    break;
                case "c":
                    RemoveKey();
                    break;
                case "d":
                    AddNewKeyPair();
                    break;
                case "e":
                    AddValueToExistingKey();
                    break;
                case "f":
                    SortKeys();
                    break;
                case "g":
                    keepRunning = false;
                    Console.WriteLine("Existing Program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    static void PopulateDictionary()
    {
        // Example of display the dictionary with initial date
        myDictionary.Clear(); //Clear any existing data for repopulation
        myDictionary.Add("grape", "red");
        myDictionary.Add("orange", "yellow");
        myDictionary.Add(" passionfruit", purple);
        Console.WriteLine("myDictionary populated with sample data.");
    }
    static void DisplayDictionary()
    {
        Console.WriteLine("\n---Dictionary Contents ---");
        // Example of one enumeration method (using foreach loop)
        foreach (KeyValuePair<string, string> entry in myDictionary)
        {
            Console.WriteLine($"Key: {entry.key}, Value: {entry.Value}");
        }
        Console.WriteLIne("-------------------------");
    }
    static void RemoveKey ()
    {
        Console.Write ("Enter the key to remove: ");
        string KeyToRemove = Console.ReadLine ();

        if (myDictionary.Remove(KeyToRemove) // Remove the key if it exists)
        {
            Console.WriteLIne ($"Key '{KeyToRemove}' removed sucessfully.");
        }
        else
        {
           Console.WriteLine($"Key '{KeyToRemove}' not found in the dictionary.");
            
        }
    }
        static void AddNewKeyPair();
        {
            Console.Write("Enter the new key: ");
        string newKey = Console.ReadLine ();

        Console.Write("Enter the new value: ");
        string newValue = Console.ReadLine ();

        if (!myDictionary.ContainsKey(newKey)) //check if the key exists
        {
            myDictionary.Add (newKey, newValue);
            Console.WriteLine ($"Key-Value pair (' {newKey} ', '{newValue} ') added.");
        }
                else
            {
        Console.WriteLine($"Key ' {newKey} ' already exists. cannot add a new pair with this key.");
        }
    }  
    static void AddValueToExistingKey(
        {
            Console.Write ("Enter the key to add value to: ");
            string existingKey = Console.ReadLine();

            if (myDictionary.ConstainsKey (existingKey)) //check if the key exists
{
    Console.Write ("Enter the value to append: ");
    string valueToAppend = Console.ReadLine();

    // Append the new value to the existing value
    myDictionary[existingKey] += ", " + valueToAppend;
    Console>Write($"Value ' {valueToAppend} ' append to key ' {existingKey} ' .";)
}
else 
{
    Console.WriteLine($"Key ' {existingKey}' not found. do not add value to a non-existent key.");

        }
    }    
        Static void SortKeys()
        {
            Console>WriteLine ("\n--- Sorted Dictionary Keys---");
            // Sort the dictionary entries by key using LINQ's OrderBy()
            var sortedDictionary = myDictionary.OrderBy ( kvp => kvp.Key);
            foreach (var entry in sortedDictionary)
            {
                Console.WriteLine ($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
        Console.WriteLine("--------------------");
     }
}