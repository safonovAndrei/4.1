using System;

namespace project34
{
    public abstract class objectProvider<Z>
    {
        protected Random random = new Random();
        public abstract Z Generate();
        public abstract Z Convert(string value);
    }
}