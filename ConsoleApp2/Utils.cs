namespace ConsoleApp2
{
    static class Utils
    {
        public static void PrintBoolArray(bool[] arr)
        {
            foreach (bool b in arr)
            {
                Console.Write(b ? "1" : "0");
            }
            Console.WriteLine();
        }
    }
}
