namespace OddNoLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var nQuery =
                from VrNum in n1
                where (VrNum % 2) != 0
                select VrNum;

            foreach (int VrNum in nQuery)
            {
                Console.Write("{0} ", VrNum);
            }
            Console.Write("\n");
        }
    }
}
