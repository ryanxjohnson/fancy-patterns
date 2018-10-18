using System.Collections.Generic;

namespace FancyStuffForJc
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var fancyObject in new List<string> {"FancyObject1", "FancyObject2"})
                Write(fancyObject.GetFancyObject());
        }

        private static void Write(IFancyObject objects)
        {
            var fancyObjects = objects.GetFanciestObjects();
            objects.Print(fancyObjects);
        }
    }
}
