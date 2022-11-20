
using System.Collections;
using System.Collections.ObjectModel;
namespace TestingPractices
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("__Collections in C#________");
            List<int> mylist=new List<int>();   //creating a list of integers
            for(int j=5; j < 10; j++)   //adding items in mylist
            {
                mylist.Add(j*3);
            }
            foreach(int items in mylist)    //by using foreach loop displaying items of mylist
            {
                Console.WriteLine(items);
            }

            Queue myQueue = new Queue();    //creating a queue
            myQueue.Enqueue("C#");          //inserting elements into the Queue
            myQueue.Enqueue("PHP");
            myQueue.Enqueue("Perl");
            myQueue.Enqueue("Java");
            myQueue.Enqueue("C");
            Console.WriteLine("Total number of elements present in the Queue are: "+ myQueue.Count);//total count of element
            Console.WriteLine("Beginning Item is :" + myQueue.Peek());//Displaying the beginning element of Queue

            Collection<int> myColl = new Collection<int>();// Creating a collection of ints .
            myColl.Add(2);
            myColl.Add(3);
            myColl.Add(4);
            myColl.Add(5);
            foreach(int i in myColl)
            {
                Console.WriteLine(i+" ");
            }

            Collection<string> myCall = new Collection<string>();
            myCall.Add("A");
            myCall.Add("B");
            myCall.Add("C");
            myCall.Add("D");
            myCall.Add("E");
            Console.WriteLine("Count : "+ myCall.Count);
            Console.WriteLine("Elements at index 2 is : " + myCall[2]); //C
            Console.WriteLine("Elements at index 2 is : " + myCall[3]); //D
            Console.WriteLine(myCall.Contains("A"));    //True
            string[] arr = new string[myCall.Count];
            myCall.CopyTo(arr, 0);
            foreach(string str in arr)
            {
                Console.WriteLine(str);
            }
        }
    }
}
