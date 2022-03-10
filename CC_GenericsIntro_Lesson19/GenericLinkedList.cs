using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_GenericsIntro_Lesson19
{
    internal class GenericLinkedList<T> : IMainPropReturner<T>
    {
        internal Node<T> head;
        public T MainValue { get; set; }

        internal void InsertFront(T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            newNode.Next = head;
            head = newNode;
        }

        internal void InsertLast(T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> lastNode = GetLastNode();
            lastNode.Next = newNode;
        }

        internal void InsertAfter(Node<T> prevNode, T newData)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node<T> new_node = new Node<T>(newData);
            new_node.Next = prevNode.Next;
            prevNode.Next = new_node;
        }

        internal Node<T> GetLastNode()
        {
            Node<T> temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

        public T GetMainPropValue()
        {
            return MainValue;
        }
    }
}
