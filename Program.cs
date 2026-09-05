namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 - Methods
            //Exercise 1

            Console.Write(" Enter frist numper : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write(" Enter sacand numper : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1- add");
            Console.WriteLine("2- subtract ");
            Console.WriteLine("3- Maltiple");
            Console.WriteLine("4- Divide");
            Console.WriteLine();

            Console.Write("entert your chose ");
            int chose = int.Parse(Console.ReadLine());

            switch (chose)
            {
                case 1:
                    Console.WriteLine($"Resalt :{num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resalt :{num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resalt :{num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"Resalt :{num1 / num2}");
                    break;

            }
            ///////////////////
            //Exercise2

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Original Name: {name}");
            Console.WriteLine($"Uppercase:  {name.ToUpper()}");
            Console.WriteLine($"Lowercase:  {name.ToLower()}");
            Console.WriteLine($"Length:  {name.Length}");
            Console.WriteLine($"Trimmed Name:  {name.Trim()}");



            //Exercise3
            while (true)
            {
             Console.Write("Enter your email :");
            string text = Console.ReadLine();

            if (text.Contains("@gmail.com"))
            {
                Console.WriteLine("ok ");
                    break;
            }
            else
            {
                Console.WriteLine("“Valid Gmail” if it ends with “@gmail.com”");
            } 
            }

            //Exercise 4
            Console.Write("Enter your name 1 : ");
            string nam1 = Console.ReadLine();

            Console.Write("Enter your name 2: ");
            string nam2 = Console.ReadLine();

            Console.Write("Enter your name 3: ");
            string nam3 = Console.ReadLine();

            Console.Write("Enter your name 4: ");
            string nam4 = Console.ReadLine();

            Console.Write("Enter your name 5: ");
            string nam5 = Console.ReadLine();


            Console.WriteLine($" th name is upper is {nam1.ToUpper()}");
            Console.WriteLine($" th name is upper is {nam2.ToUpper()}");
            Console.WriteLine($" th name is upper is {nam3.ToUpper()}");
            Console.WriteLine($" th name is upper is {nam4.ToUpper()}");
            Console.WriteLine($" th name is upper is {nam5.ToUpper()}");

            //Exercise5 && Exercise6

            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                arr[i]=int.Parse( Console.ReadLine() );
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"the valou index {i} = {arr[i]}");
            }

            
            int sam = 0;
            int main = arr[0];
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                sam += arr[i];
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                if(arr[i] < main)
                {
                    main = arr[i];
                }

            }
            Console.WriteLine($"the same is : {sam}");
            Console.WriteLine($"the avge is : {sam/5}");
            Console.WriteLine($"the max is : {max}");
            Console.WriteLine($"the mzin is : {main}");



        }
    }
}
