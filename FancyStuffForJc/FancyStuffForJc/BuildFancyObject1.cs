using System;
using System.Collections.Generic;

namespace FancyStuffForJc
{
    public class BuildFancyObject1 : IFancyObject
    {
        public IEnumerable<FanciestObject> GetFanciestObjects()
        {
            yield return new FancyObject1 {Name = "FancyObject1", FancyObject1Property = "Teacup"};
        }

        public void Print(IEnumerable<FanciestObject> objects)
        {
            foreach (var o in objects)
            {
                var fanciestObject = (FancyObject1) o;
                Console.WriteLine($"{fanciestObject.Name}: {fanciestObject.FancyObject1Property}");
            }
        }
    }
}
