namespace TestingPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample S1 = new Sample();
            S1.Print();

            Sample S2= new Sample();
            S2.read();
            S2.Print();
        }
    }
}