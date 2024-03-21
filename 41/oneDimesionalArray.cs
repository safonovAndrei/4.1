using System;

namespace project34
{
    
    public sealed class oneDimensionalArray<Z>: baseArray<Z>
    {

        private bool isNotRandom = false;
        private Z[] array;

        public oneDimensionalArray(bool isNotRandom, objectProvider<Z> inputProvider): base(isNotRandom, inputProvider){ }
/*
        protected override void getRandomArray()
        {
            Random random = new Random();
            array = new Z[random.Next(1, 10)];
            for (int i = 0; i < array.Length; i++)
            {   
                array[i] = Provider.Generate();
            }
        }
        
        protected override void getFromUserArray()
        {
            Console.Write("Длина одномерного массива: ");
            array = new Z[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                array[i] = Provider.Convert(Console.ReadLine());
            }
        }
*/
        public override void printArray() 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}; ");
            }
            Console.WriteLine(" ");
        }

        public Z[] addElement()
        {
            try
            {
                Console.Write("Введите элемент для добавления: ");
                array[array.Length] = Provider.Convert(Console.ReadLine());
                return array;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
                Z[] betterArray = new Z[2*array.Length+1];
                for(int i=0; i<array.Length; i++)
                {
                    betterArray[i] = array[i];
                }
                array = betterArray;
                Console.Write(" => Array.Length = 2*n+1!");
                addElement();
            }
        }
        public Z[] removeElement()
        {
            try
            {
                Console.Write("Введите индекс элемента для удаления: ");
                int index = int.TryParse(Console.ReadLine());
                Z[] betterArray = new Z[array.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    betterArray[i] = array[i];
                }
                for (int i = index; i < array.Length - 1; i++)
                {
                    betterArray[i] = array[i + 1];
                }
                array = betterArray;
                return array;
            }
            catch (Exception e)
            {
                public Z[] removeElement()
            }
        }
        public Z[] sortArray()
            {
        //Как с Z работать?         
            }
        public int numberOfElements()
        {
            return array.Length+1;
        }
        public void isElementInArray()
        {
            bool status = false;
            Console.WriteLine("Введите элемент на проверку на наличие в массиве: ");
            Z element = Provider.Convert(Console.ReadLine());
            for(int i=0; i<array.Length; i++)
            {
                if(array[i] == element)
                {
                    bool status = true;
                }
            }
            if (status){
                Console.WriteLine("Элемент в массиве!");
            }
            else:
                Console.WriteLine("Элемент не в массиве!");
        }
        public Z flipArray()
        {
            Z betterArray = new Z[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                betterArray[i] = array[array.Length - 1 - i];
            }
            return betterArray;
        }
        public Z elementsFromToArray()
            {
                Console.WriteLine("Введите от какого по номеру элемента обрезать массив: ");                
                int fromElement = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите до какого по номеру элемента обрезать массив: ");
                int toElement = int.Parse(Console.ReadLine());
                Z betterArray = new Z[array.Length];
                for (int i = fromElement; i < toElement; i++)
                {
                    betterArray[i] = array[i];
                }
                return betterArray;
            }
    }
}