namespace Lista
{
    internal class Program
    {
        static void Main()
        {
            List<string>lista = new List<string>();
            lista.Add("kvbn");
            lista.Add("svfonsvi");
            lista.Add("sdvkjb");
            lista.Add("sdvksmv");

            lista.Reverse();
            int index = 1;

            Console.WriteLine("Elements in the list with foreach: ");
            foreach(string elem in lista)
            {
                Console.WriteLine($"A(z) {index} elem a listában: " + elem);
                index++;
            }
            Console.WriteLine();
            Console.WriteLine("Elements in the list with for: ");
            for (int i=0; i< lista.Count;i++)
            {
                Console.WriteLine($"A(z) {i+1} elem a listában: " + lista.ElementAt(i)) ;
            }

            Console.WriteLine();
            Console.WriteLine("Elements in the list with for backwards");
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"A(z) {i+1} elem listában: " + lista.ElementAt(i));
            }
            Console.WriteLine("Elements 2 is present in the list: " + lista.Contains(2));

            lista.Sort();
            lista.Reverse();
            index = 0;
            Console.WriteLine();
            foreach(int elem  in lista)
            {
                Console.WriteLine($"A(z) {index} elem a listában: " + elem);

            }
        }
    }
}
