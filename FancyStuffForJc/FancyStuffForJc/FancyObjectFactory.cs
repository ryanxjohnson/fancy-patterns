using System.ComponentModel;

namespace FancyStuffForJc
{
    public static class FancyObjectFactory
    {
        public static IFancyObject GetFancyObject(this string type)
        {
            switch (type)
            {
                case "FancyObject1":
                    return new BuildFancyObject1();
                case "FancyObject2":
                    return new BuildFancyObject2();
                default:
                    throw new InvalidEnumArgumentException("Not a valid fancy object type");
            }
        }
    }
}