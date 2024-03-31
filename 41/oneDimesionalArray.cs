using System;

namespace project34
{
    
    public sealed class oneDimensionalArray<Z>: baseArray<Z>
    where Z : IComparable<Z>
    {

        private const int defaultC = 7;
        private int size = 0;
        private Z[] array;

        public oneDimensionalArray(int length)
        {
            array = new Z[length];
        }
        public oneDimensionalArray()
        {
            array = new Z[defaultC];
        }
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

        public Z[] addElement(Z item)
        {
            if (size >= array.Length)
            {
                int lEnght = array.Length * 2 + 1;
                Array.Resize(ref array, lEnght);
            }         
            array[size] = item;
            size++;
            return array;
        }
        public Z[] removeElement(int index)
        {
            try
            {
                index -= 1;
                Z[] betterArray = new Z[array.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    betterArray[i] = array[i];
                }
                for (int i = index+1; i < array.Length-1; i++)
                {
                    betterArray[i] = array[i];
                }
                array = betterArray;
                return array;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message);
                return array;
            }
        }
        public Z[] sortArray()
            {
                for(int i = 0; i<array.Length-1; i++)
                {
                    for(int j = i+1; j<array.Length; j++)
                        {
                            if(array[i].CompareTo(array[j])>0)
                            {
                                Z temp = array[i];
                                array[i] = array[j];
                                array[j] = temp;
                            }
                        }
                }
                return array;
            }
        /*
        public int numberOfElements()
        {
            
        }
        */
        public void isElementInArray(Z element)
        {
            bool status = false;
            for(int i=0; i<array.Length; i++)
            {
                if(array[i].CompareTo(element) == 0)
                {
                    status = true;
                }
            }
            if (status){
                Console.WriteLine("Элемент в массиве!");
            }
            else{Console.WriteLine("Элемент не в массиве!");}
        }
        public int calcCondition(Func<Z, bool> condition)
        {
            int numberOfTrueCondition = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(condition(array[i]))
                {
                    numberOfTrueCondition += 1;
                }
            }
            return numberOfTrueCondition;
        }
        public bool ifOnly1Condition(Func<Z, bool> condition)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(condition(array[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool ifAllCondition(Func<Z, bool> condition)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(!condition(array[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public Z[] flipArray()
        {
            for (int i = 0; i < array.Length-1-i; i++)
            {
                Z item = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = item;
            }
            return array;
        }
        public Z maxElement()
        {
            Z maxElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(maxElement) > 0)
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
        public Z minElement()
        {
            Z minElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(minElement) < 0)
                {
                    minElement = array[i];
                }
            }
            return minElement;
        }
        public Z[] elementsFromToArray()
            {
                Console.WriteLine("Введите от какого по номеру элемента обрезать массив: ");                
                int fromElement = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите до какого по номеру элемента обрезать массив: ");
                int toElement = int.Parse(Console.ReadLine());
                Z[] betterArray = new Z[toElement-fromElement + 1];
                for (int i = fromElement; i < toElement; i++)
                {
                    betterArray[i] = array[i];
                }
                return betterArray;
            }
        /*
        public ZResult Min<ZResult>(Func<Z, ZResult> projectior)
        {

        }
        */
    }
}