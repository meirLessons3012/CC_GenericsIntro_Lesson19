using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_GenericsIntro_Lesson19
{
    internal class GenericForOnlyStruct<T> where T : struct
    {
        public T TProp { get; set; }
        public GenericForOnlyStruct()
        {
            //TProp.
        }
    }

    internal class GenericForOnlyClass<T> where T : class
    {
        public T TProp { get; set; }
        public GenericForOnlyClass()
        {
            //TProp = new T();//Error
        }
    }

    internal class GenericForOnlyParameterLessCtor<T> where T : new()
    {
        public T TProp { get; set; }

        public GenericForOnlyParameterLessCtor()
        {
            TProp = new T();
        }
    }

    internal class GenericForOnlySomeClass<T> where T : Book
    {
        public T TProp { get; set; }
        public GenericForOnlySomeClass()
        {
            TProp.Author = "string";
        }
    }

    internal class GenericForOnlySomeInterface<T> where T : ICloneable
    {
        public T TProp { get; set; }

        public GenericForOnlySomeInterface()
        {
            TProp.Clone();
        }
    }

    internal class GenericForTEqualU<T,U> where T : U
    {

    }

    internal interface IGenericForInAndOut<in TIn, out TOut> where TIn : Book
    {
        public TOut Foo(TIn t);
    }

    class GenericForInAndOut : IGenericForInAndOut<Book, string>
    {
        public string Foo(Book t)
        {
            return "";
        }
    }
}
