using System;
using System.Collections;
using System.Collections.Specialized;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("________ArrayList _______________________________");
        //Creating an ArrayList
        ArrayList arlist = new ArrayList();
        //or
        var varlist = new ArrayList();  //recommended 

        // adding elements using ArrayList.Add() method
        var varlist1 = new ArrayList();
        varlist1.Add(1);
        varlist1.Add("Bill");
        varlist1.Add(" ");
        varlist1.Add(true);
        varlist1.Add(4.5);
        varlist1.Add(null);
        varlist1.Add('c');

        // adding elements using object initializer syntax
        var varlist2 = new ArrayList()
        {
            2,"Steve"," ",true,4.6,null
        };

        //using the AddRange() to add entire elements of others collection's data in ArrayList
        var obj1 = new ArrayList();
        var obj2 = new ArrayList()
        {
            1,"Bill"," ",true,4.34,null
        };
        int[] arr = { 100, 200, 300, 400 };
        Queue myQ = new Queue();
        myQ.Enqueue("Hello");
        myQ.Enqueue("World");

        obj1.AddRange(obj2);//adding arraylist in arraylist
        obj1.AddRange(arr);//adding array in arraylist
        obj1.AddRange(myQ);//adding Queue in arraylist 

        //Accessing an ArrayList
        var listVar = new ArrayList()
        {
            1,
            "Bill",
            300,
            4.5f
        };
        int firstElement = (int)listVar[0];//returns 1
        string secondElement = (string)listVar[1];//return "Bill"
        //int secondElement=(int) listVar[1]; //Error: cannot convert string to int

        //using var keyword without explicit casting
        var elementFirst = listVar[0];//returns 1
        var elementSecond = listVar[1];//return "Bill"
        //var elementFifth = listVar[5];//Error: Index out of range

        //update elements
        listVar[0] = "Steve";
        listVar[1] = 100;
        //listVar[5] = 500; //Error: Index out of range

        //Iterate an ArrayList
        ArrayList arrayListObj = new ArrayList()
        {
            1,
            "Bill",
            300,
            4.5f
        };
        foreach (var item in arrayListObj)
            Console.WriteLine(item + " ");
        for (int i = 0; i < arrayListObj.Count; i++)
            Console.WriteLine(i + " ");

        //Insert Elements in ArrayList using Insert()
        ArrayList obj = new ArrayList()
        {
            1,
            "Bill",
            300,
            4.5f
        };
        obj.Insert(1, "Second Item");
        foreach (var val in obj)
            Console.WriteLine(val + " ");

        //Insert Collection in ArrayList using InserRange()
        ArrayList object1 = new ArrayList() { 10, 20, 60 };
        ArrayList object2 = new ArrayList() { 30, 40, 50 };
        object1.InsertRange(2, object2);
        foreach (var show in object1)
            Console.WriteLine(show + " ");

        //Remove Elements from ArrayList  >>Use the Remove(),RemoveAt() or RemoveRange()<<
        ArrayList al = new ArrayList()
        {
            1,
            null,
            "Bill",
            300,
            " ",
            4.5f,
            300
        };
        al.Remove(null);    //Removes first occurance of null
        al.RemoveAt(4);     //Removes element at index 4
        al.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

        //Check element in ArrayList    >>Use Contains()<<
        ArrayList OBJ = new ArrayList()
        {
            1,
            "Bill",
            300,
            4.5f,
            300
        };
        Console.WriteLine(OBJ.Contains(300));   //true
        Console.WriteLine(OBJ.Contains("Bill")); //true
        Console.WriteLine(OBJ.Contains("BILL"));    //false
        Console.WriteLine(OBJ.Contains("Steve"));   //false
    }
}