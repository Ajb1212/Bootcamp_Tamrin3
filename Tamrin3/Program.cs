namespace Tamrin3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());


            Console.WriteLine("____________________________________________");


            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());


            Console.ReadKey();
        }
    }

    public class Stack<T>
    {
        private IList<T> _items = new List<T>();

        public void Push(T item) => _items.Add(item);

        public T? Pop()
        {
            var latestItem = _items.Last();
            _items.Remove(latestItem);
            return latestItem;
        }

        public T Peek() => _items.Last();
    }

    public class Queue<T>
    {
        private IList<T> _items = new List<T>();

        public void Enqueue(T item) => _items.Add(item);

        public T? Dequeue()
        {
            var firstItem = _items.First();
            _items.Remove(firstItem);
            return firstItem;
        }

        public T Peek() => _items.First();
    }
}