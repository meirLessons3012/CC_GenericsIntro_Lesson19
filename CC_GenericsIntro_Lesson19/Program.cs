using System;

namespace CC_GenericsIntro_Lesson19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericLinkedList<int> gllInt = new GenericLinkedList<int>();
            gllInt.InsertFront(13);
            gllInt.InsertLast(22);
            gllInt.InsertLast(122);

            GenericLinkedList<bool> gllBool = new GenericLinkedList<bool>();
            gllBool.GetMainPropValue();
            gllBool.InsertFront(false);

            GenericLinkedList<Book> gllBook = new GenericLinkedList<Book>();
            gllBook.GetMainPropValue();
            gllBook.InsertFront(new Book());

            GenericClass<float,int> gc = new GenericClass<float, int>();
            GenericClass<Book, Book> gc1 = new GenericClass<Book, Book>();
            gc.PrintType(3);
            gc1.PrintType(new Book());
            //gc.PrintType("muki");//Error
            gc.WriteLine(true,3.3f);
            gc.WriteLine("rubi", 3.3f);
            gc.WriteLine(152, 3.3f);
            gc.WriteLine<int>(3, 4.2f);
            gc.PrintAllTTypes(13.2f,3);
            gc.PrintAllTTypesOfMethod<int, int, int>(1, 1, 1);
            gc.PrintAllTTypesOfMethod<bool, int, bool>(false, 3,true);
            PrintMessage<string>("hello");
            PrintMessage('h');

            #region Generic Interface

            //Instance
            //Person<long> p1 = new Person<long>();
            //long id = p1.GetMainPropValue();

            //Person<string> p2 = new Person<string>();
            //string id1 = p2.GetMainPropValue();

            //Class
            Person p1 = new Person();
            long id = p1.GetMainPropValue();

            #endregion

            #region Generic Constraints

            //struct
            GenericForOnlyStruct<int> gfocInt = new GenericForOnlyStruct<int>();
            GenericForOnlyStruct<float> gfocFloat = new GenericForOnlyStruct<float>();
            GenericForOnlyStruct<DateTime> gfocDate = new GenericForOnlyStruct<DateTime>();

            //class
            GenericForOnlyClass<Book> gfoc = new GenericForOnlyClass<Book>();
            GenericForOnlyClass<int[]> gfoc1 = new GenericForOnlyClass<int[]>();

            //Parameterless Ctor
            GenericForOnlyParameterLessCtor<Book> newCntrs1 = new GenericForOnlyParameterLessCtor<Book>();
            GenericForOnlyParameterLessCtor<int> newCntrs2 = new GenericForOnlyParameterLessCtor<int>();
            //GenericForOnlyParameterLessCtor<Node> newCntrs3 = new GenericForOnlyParameterLessCtor<Node>();

            //Some Class
            GenericForOnlySomeClass<Book> someClass1 = new GenericForOnlySomeClass<Book>();
            GenericForOnlySomeClass<SubBook> someClass2 = new GenericForOnlySomeClass<SubBook>();
            //GenericForOnlySomeClass<BaseBook> someClass3 = new GenericForOnlySomeClass<BaseBook>();

            //Some Interface
            GenericForOnlySomeInterface<string> someInterface1 = new GenericForOnlySomeInterface<string>();
            GenericForOnlySomeInterface<SubBook> someInterface2 = new GenericForOnlySomeInterface<SubBook>();
            //GenericForOnlySomeInterface<int> someInterface3 = new GenericForOnlySomeInterface<int>();

            #endregion
        }

        public static void PrintMessage<T>(T message)
        {
            Console.WriteLine(message);
        }

    }
}
