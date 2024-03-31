using System;
namespace project34
{
    class Program
    {
        static void Main()
        {
            oneDimensionalArray<int> arrayInt;
            Console.Write("Which type of array? (default capacity/given capacity)");
            string typeQ = Console.ReadLine();
            if (typeQ == "default capacity")
            {
                arrayInt = new oneDimensionalArray<int>();
                arrayInt.addElement(100);
                arrayInt.addElement(1);
                arrayInt.addElement(200);
                arrayInt.addElement(3);
                arrayInt.addElement(5);
                arrayInt.addElement(8);
                arrayInt.addElement(13);
                arrayInt.printArray();
                arrayInt.removeElement(6);
                arrayInt.printArray();
                arrayInt.sortArray();
                arrayInt.printArray();
                Console.WriteLine(arrayInt.minElement());
                Console.WriteLine(arrayInt.maxElement());
                arrayInt.isElementInArray(4);
                arrayInt.flipArray();
                arrayInt.printArray();
            }
            else if (typeQ == "given capacity")
            {
                arrayInt = new oneDimensionalArray<int>(int.Parse(Console.ReadLine()));
                arrayInt = new oneDimensionalArray<int>();
                arrayInt.addElement(100);
                arrayInt.addElement(1);
                arrayInt.addElement(200);
                arrayInt.addElement(3);
                arrayInt.addElement(5);
                arrayInt.addElement(8);
                arrayInt.addElement(13);
                arrayInt.printArray();
                arrayInt.removeElement(6);
                arrayInt.printArray();
                arrayInt.sortArray();
                arrayInt.printArray();
                Console.WriteLine(arrayInt.minElement());
                Console.WriteLine(arrayInt.maxElement());
            }
            else {Console.WriteLine("Error! Type not found");}

        }
    }
}