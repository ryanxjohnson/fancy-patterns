using System.Collections.Generic;

namespace FancyStuffForJc
{
    public interface IFancyObject
    {
        IEnumerable<FanciestObject> GetFanciestObjects();
        void Print(IEnumerable<FanciestObject> objects);
    }
}