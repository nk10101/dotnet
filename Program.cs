using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_class
{
    internal class MyStack
    {
        static int MAX = 6;
        int top;
        int[] stack = new int[MAX];

      
        public MyStack()
        {
            top = -1;
        }

        internal bool IsEmpty()
        {
            return (top < 0);
        }
        internal bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        internal int Peek()
        {
            if (top < 0)
            {

                return -1;
            }
            else
                return stack[top];
        }

        internal bool IsFull()
        {
            if (top == MAX)
            {

                return true;
            }
            else
                return false;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            MyStack st = new MyStack();

            Console.WriteLine(st.IsFull());

            Console.WriteLine(st.IsEmpty());


            st.Push(8);
            st.Push(11);
            st.Push(4);
            st.Push(5);
            st.Push(7);
            st.Push(9);

            st.Pop();
            st.Pop();
            st.Pop();
            st.Pop();

            st.Push(10);


            Console.WriteLine("Peek the top:"+st.Peek());

            while (!st.IsEmpty())
            {

                Console.WriteLine(st.Pop());
            
            }






        }
    }
}
