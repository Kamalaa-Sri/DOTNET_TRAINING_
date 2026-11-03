using System;
using System.Collections.Generic;
class ListOfNumbers {
  static void Main() {
    List<int> numbers = new List<int>();
    Console.Write("Enter the size of the list: ");
    int size = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < size; i++) {
      Console.Write("Enter a number: ");
      int number = Convert.ToInt32(Console.ReadLine());
      numbers.Add(number);
    }
    Console.WriteLine("The numbers in the list are:");
    foreach (int n in numbers) {
      Console.WriteLine(n);
    }
  }
}
  }
}