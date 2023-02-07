namespace ConsoleApp66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GenericList <int> intList = new GenericList <int>();
            //intList.Generic(5);
            //GenericList <string> strList = new GenericList<string>();
            //strList.Generic("Hello");

            GenericList<string> strList = new GenericList<string>();
            Console.WriteLine(strList.SwapList("Salam","Saghol"));



        }

    }

}
