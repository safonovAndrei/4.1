using System;

namespace project34
{
    public class boolProvider: objectProvider<bool>
    {
        public override bool Generate()
        {
            if (random.Next(0, 2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Convert(string value){
            return bool.Parse(value);
        }
    }
}