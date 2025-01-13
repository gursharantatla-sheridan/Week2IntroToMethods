namespace Week2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            string str = "hello";
            int[] arr = { 3, 4, 5 };

            Console.WriteLine("Before changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("arr[0] = " + arr[0]);

            ChangeValue(ref num, str, arr);

            Console.WriteLine("\n\nAfter changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("arr[0] = " + arr[0]);



            // output parameters
            int x = 10, y = 20;
            //int sum, mul;

            Calculate(x, y, out int sum, out int mul);

            Console.WriteLine("\n\nSum = " + sum);
            Console.WriteLine("Mul = " + mul);



            Console.Write("\n\nEnter a number: ");
            if (int.TryParse(Console.ReadLine(), out int n))
                Console.WriteLine("n = " + n);
            else
                Console.WriteLine("Invalid input. Please try again");

        }




        static void Calculate(int a, int b, out int sum, out int mul)
        {
            sum = a + b;
            mul = a * b;
        }



        static void ChangeValue(ref int n, string s, int[] a)
        {
            n = 100;
            s = "bye";
            a[0] = 100;
        }
    }
}
