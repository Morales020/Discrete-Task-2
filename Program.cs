namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Start Number : ");
            int num1 = int .Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The End Number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The Perfect Numbers Between {0} And {1} is : ", num1, num2);
            for (int i =num1;i<=num2;i++) { 
            int sum = 0;
            for (int j =1;j<i;j++) {
                    if (i % j == 0)
                    {
                        sum +=j;
                    }
                    }
                if (sum == i&& sum !=0)
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}