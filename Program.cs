using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestingPractices
{
    public class GFG<T>
    {
        private T data;
        public T value
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
    public class GenericMethodTesting
    {
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine($"{msg} {value}");
        }
    }
    internal class Program
    {
       static void Main(string[] args)
       {
            /*
                        Generic is a class which allows the user to define classes and methods with the placeholder.Generics were added to version 2.0 of the C# language. The basic idea behind using Generic is to allow type (Integer, String, … etc and user-defined types) to be a parameter to methods, classes, and interfaces. A primary limitation of collections is the absence of effective type checking. This means that you can put any object in a collection because all classes in the C# programming language extend from the object base class. This compromises type safety and contradicts the basic definition of C# as a type-safe language. In addition, using collections involves a significant performance overhead in the form of implicit and explicit type casting that is required to add or retrieve objects from a collection.
            To address the type safety issue, the.NET framework provides generics to create classes, structures, interfaces, and methods that have placeholders for the types they use.Generics are commonly used to create type-safe collections for both reference and value types.The.NET framework provides an extensive set of interfaces and classes in the System.Collections.Generic namespace for implementing generic collections.

            Generic Class

            Generics in C# is its most powerful feature. It allows you to define the type-safe data structures. This out-turn in a remarkable performance boost and high-grade code, because it helps to reuse data processing algorithms without replicating type-specific code. Generics are similar to templates in C++ but are different in implementation and capabilities. Generics introduces the concept of type parameters, because of which it is possible to create methods and classes that defers the framing of data type until the class or method is declared and is instantiated by client code. Generic types perform better than normal system types because they reduce the need for boxing, unboxing, and type casting the variables or objects.
            Parameter types are specified in generic class creation.

            To create objects of generic class, following syntax is used: BaseType  obj = new BaseType ()
                    */
            GFG<string> name = new GFG<string>();   // instance of string type
            name.value = "GeeksForGeeks";
            GFG<float> version = new GFG<float>();
            version.value = 5.123f;
            Console.WriteLine(name.value);
            Console.WriteLine(version.value);
            Console.WriteLine("------------------");

            //A Generic method with various parameters: Just as a method can take one argument, generics can take various parameters.One argument can be passed as a familiar type and other as a generic type, as shown below:
            GenericMethodTesting classObj = new GenericMethodTesting();
            classObj.Display("Integer", 123);
            classObj.Display("Character", 'H');
            classObj.Display("Decimal", 255.67);
        }
    }
}
