namespace Multilevel_inhert
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass ch = new ChildClass(7, 5);
            ch.Add();
            ch.Sub();
            ch.Multi();

        }
    }
}
