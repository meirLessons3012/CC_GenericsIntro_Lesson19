using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CC_GenericsIntro_Lesson19
{
    internal class GenericClass<T,T1>
    {
        public void PrintType(T1 instance)
        {
            Console.WriteLine(instance.GetType());
        }
        public GenericClass()
        {
            JsonSerializer.Serialize<GenericClass<T, T1>>(this);
        }
        public void WriteLine<TMethod>(TMethod methodType, T classType)
        {
            Console.WriteLine(methodType);
        }

        public void PrintAllTTypes(T t, T1 t1)
        {
            Console.WriteLine(t);
            Console.WriteLine(t1);

        }

        public void PrintAllTTypesOfMethod<TM1,TM2,TM3>(TM1 t, TM2 t1, TM3 t2)
        {
            Console.WriteLine(t);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }

        public static void PrintAllTTypesOfMethodStatic<TM1, TM2, TM3>(TM1 t, TM2 t1, TM3 t2)
        {
            Console.WriteLine(t);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }

    }
}
