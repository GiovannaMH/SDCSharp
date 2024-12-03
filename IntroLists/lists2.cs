/*
 * You can store items of different types in a single list in C# if the list is defined to hold a base type such as object. 
 * Since all types in C# derive from object, a List<object> can store items of any type. 
 * However, you need to handle type conversion carefully when retrieving and using those items.
 * 
 * Example: Storing Different Types in a List<object>
 * A better version of this is using a Class.
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Income { get; set; }
        }
 * 
 * */
using System;
using System.Collections.Generic;

namespace Lists2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list that can hold items of different types
            List<object> mixedList = new List<object>();

            // Add items of different types to the list
            mixedList.Add("Hello, World!"); // String
            mixedList.Add(42);             // Integer
            mixedList.Add(3.14);           // Double
            mixedList.Add(true);           // Boolean

            // Print all items in the list
            Console.WriteLine("Items in the list:");
            foreach (object item in mixedList)
            {
                Console.WriteLine($"Type: {item.GetType()}, Value: {item}");
            }

            // Access individual items and use them
            Console.WriteLine("\nAccessing items:");
            string firstItem = (string)mixedList[0];
            Console.WriteLine($"First item as string: {firstItem}");

            int secondItem = (int)mixedList[1];
            Console.WriteLine($"Second item as integer: {secondItem}");

            double thirdItem = (double)mixedList[2];
            Console.WriteLine($"Third item as double: {thirdItem}");

            bool fourthItem = (bool)mixedList[3];
            Console.WriteLine($"Fourth item as boolean: {fourthItem}");
        }
    }
}

