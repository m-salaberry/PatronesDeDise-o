namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Degregorio";

            Singleton s1 = Singleton.GetIntance(name);

            string name2 = "Martinez";

            Singleton s2 = Singleton.GetIntance(name2);

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works properly");
            }
            else
            {
                Console.WriteLine("Singleton doesn't work, you must to review your code, dumbass");
            }
        }
    }
}