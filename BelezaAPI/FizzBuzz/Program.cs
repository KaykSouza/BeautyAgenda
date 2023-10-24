namespace FizzBuzz
{
    internal class Program
    {
        //nível 1 fizzbuzz normal
        //nivel 2 fizbuzz com switch inves do if
        //nivel 3 fizzbuzz com switch sem end
        //nivel 4 sem operador de mod "%"
        static void Main(string[] args)
        {
            // Normal

            /* for (int num = 0; num <= 100; num++)
             {
                 if (num % 3 == 0 && num % 5 == 0)
                 {
                     Console.WriteLine("FizzBuzz");
                 }
                 else if (num % 3 == 0)
                 {
                     Console.WriteLine("Fizz");
                 }
                 else if (num % 5 == 0)
                 {
                     Console.WriteLine("Buzz");
                 }
                 else
                 {
                     Console.WriteLine(num);
                 }

             }
             Console.ReadLine();
            */

            for (int num = 0; num <= 15; num++)
            {
                //switch (num)
                //{
                //    case (num % 3 == 0 && num % 5 == 0):
                //        Console.WriteLine("FizBuzz");
                //        break;
                //    case (num % 3 == 0):
                //        Console.WriteLine("Buzz");
                //        break;
                //    case (num % 5 == 0):
                //        Console.WriteLine("Buzz");
                //        break;
                //    default:
                //        Console.WriteLine(num);
                //        break;
                //}
                switch (num % 15)
                {
                    case 0:
                    case 15:
                        Console.WriteLine("FizBuzz");
                        break;

                    case 3:
                    case 6:
                    case 9:
                    case 12:
                        Console.WriteLine("Fizz");
                        break;

                    case 5:
                    case 10:
                        Console.WriteLine("Buzz");
                        break;

                    default:
                        Console.WriteLine(num);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}