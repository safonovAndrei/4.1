using System;

namespace project34
{
    public class intProvider: objectProvider<int>
    {
        public override int Generate(){
            int Int = random.Next(-100, 100);
            return Int;
        }
        public override int Convert(string value){
            return int.Parse(value);
        }
    }
}