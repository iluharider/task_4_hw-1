    public class Stack
    {
        static readonly int maxNumberOfElements = 100;
        int top_index;
        private int minValue;
 
        int[] stack = new int[maxNumberOfElements];
        int[] minStack = new int[maxNumberOfElements]; //stack for minimums

        public int MinValue
        {
            get { return minValue; }
        }
        public Stack()
        {
            top_index = -1;
        }


        public bool Push(int value)
        {
            if (top_index >= maxNumberOfElements)
            {
                Console.WriteLine("Stack Overflow!");
                return false;
            }
            else
            {
                if (top_index < 0 || value < minValue) minValue = value;
                stack[++top_index] = value;
                minStack[top_index] = minValue;
                return true;
            }
        }

        public int Pop()
        {
            if (top_index < 0)
            {
                Console.WriteLine("Stack Underflow!");
                return 0;
            }
            else
            {
                minValue = minStack[top_index - 1];
                int value = stack[top_index--];
                return value;
            }
        }
        public void PrintStack()
        {
            if (top_index < 0)
            {
                Console.WriteLine("Stack Underflow!");
                return;
            }
            else
            {
                Console.WriteLine("Stack:");
                for (int i = top_index; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(3);
            myStack.Push(2);
            myStack.Push(5);
            myStack.Push(1);
            myStack.Push(8);

            myStack.PrintStack();

            myStack.Pop(); Console.WriteLine($"I popped one element, now min is {myStack.MinValue}");
            myStack.Pop(); Console.WriteLine($"I popped one element, now min is {myStack.MinValue}");
            
            if (myStack.Push(0) == true) Console.WriteLine("I pushed zero to the stack");
        
            Console.WriteLine($"ok, now min is {myStack.MinValue}");

            myStack.PrintStack();
        }
    }

