using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_GenericsIntro_Lesson19
{
    internal interface IMainPropReturner<out TProp>
    {
        TProp GetMainPropValue();
    }

    class Person : IMainPropReturner<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public long GetMainPropValue()
        {
            return Id;
        }
    }

    class House : IMainPropReturner<string>
    {
        public string Address { get; set; }
        public double Size { get; set; }

        public string GetMainPropValue()
        {
            return Address;
        }
    }

    class Car : IMainPropReturner<int>
    {
        public int CarNumber { get; set; }
        public string Color { get; set; }

        public int GetMainPropValue()
        {
            return CarNumber;
        }
    }
}
