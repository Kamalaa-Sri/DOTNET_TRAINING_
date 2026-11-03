using System;
using System.Collections.Generic;
class DictionaryOfNumbers {
  static void Main() {
    Dictionary<int, int> numbers = new Dictionary<int, int>(); 
    Console.WriteLine("Enter the size of the dictionary: ");
    int size = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < size; i++) {
        Console.WriteLine("Enter a key:");
        int key = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a value:");
        int value = Convert.ToInt32(Console.ReadLine());
        numbers.Add(key, value);
        }
        foreach (KeyValuePair<int, int> i in numbers)
        {
            Console.WriteLine("Key: " + i.Key + ", Value: " + i.Value);
        }
  }
}