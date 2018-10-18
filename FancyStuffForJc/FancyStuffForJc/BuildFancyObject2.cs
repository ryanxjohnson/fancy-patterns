using System;
using System.Collections.Generic;

namespace FancyStuffForJc
{
    public class BuildFancyObject2 : IFancyObject
    {
        public IEnumerable<FanciestObject> GetFanciestObjects()
        {
            yield return new FancyObject2 {Name = "FancyObject2", FancyObject2Property = "Lamp"};
        }

        public void Print(IEnumerable<FanciestObject> objects)
        {
            foreach (var o in objects)
            {
                var fanciestObject = (FancyObject2)o;
                Console.WriteLine($"{fanciestObject.Name}: {fanciestObject.FancyObject2Property}");
            }
        }
    }
}