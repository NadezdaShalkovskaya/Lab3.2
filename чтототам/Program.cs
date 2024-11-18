namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double A_1 = 1;
            double A_2 = 2;
            double A_3 = (A_1+A_2)/2;
            Console.WriteLine("D=");
            double D = double.Parse(Console.ReadLine());
            int k = 3;
            while (Math.Abs(A_3*A_2)>=D)
            {
                A_1 = A_2;
                A_2 = A_3;
                A_3= (A_1+A_2)/2;
                k++;
            }
            Console.WriteLine("k = {0}; Ak-1={1};Ak={2};k,A_2,A_3");
            Console.ReadLine();
            //Хроменков 
        }
    }
}
