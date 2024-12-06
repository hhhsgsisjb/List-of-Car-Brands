using System;
using System.Collections.Generic;

class Program
{
    public static void DisplayCarBrands(List<string> carBrands)
    {
        foreach (string brand in carBrands)
        {
          
            if (brand == null) // Display "null" for null values
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine(brand);
            }

            /* or you can use this Line instead of (if & else) :
             * Console.WriteLine(brand ?? "null");
             */
            
        }
        Console.WriteLine("Count of car brands = " + carBrands.Count);
        Console.WriteLine("--------------------------");
    }
    static void Main(string[] args)
    {
        // Initialize the list with some car brands
        List<string> carBrands = new List<string>() { "BMW", "KIA", "SUZUKI", "KIA", "JEEP" };

        // Display initial car brands
        Console.WriteLine("Car Brands:");
        DisplayCarBrands(carBrands);

        // Add elements to the list
        carBrands.Add("FORD");
        carBrands.Add(null); // Adding a null value
        Console.WriteLine("After adding FORD and null:");
        DisplayCarBrands(carBrands);

        // Insert an element at index 2
        carBrands.Insert(2, "TOYOTA");
        Console.WriteLine("After inserting TOYOTA at index 2:");
        DisplayCarBrands(carBrands);

        carBrands.Remove("KIA");
        Console.WriteLine("After removing the first occurrence of KIA:");
        DisplayCarBrands(carBrands);

        carBrands.RemoveAt(1);
        Console.WriteLine("After removing the element at index 1:");
        DisplayCarBrands(carBrands);

        Console.WriteLine("Final state of car brands:");
        DisplayCarBrands(carBrands);
        Console.ReadLine();
    }
}