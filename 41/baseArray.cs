using System;
namespace project34
{
    public abstract class baseArray<Z>: IbaseArray
    {
        public void fillArray(bool isNotRandom)
        {
            if (isNotRandom)
            {
                getFromUserArray();
            }
            else
            {
                getRandomArray();
            }
        }
        protected objectProvider<Z> Provider;
        public baseArray(bool isNotRandom, objectProvider<Z> inputProvider)
        {
            Provider = inputProvider;
            fillArray(isNotRandom);
        }
        public abstract void printArray();
        protected abstract void getRandomArray();
        protected abstract void getFromUserArray();
    }
} 