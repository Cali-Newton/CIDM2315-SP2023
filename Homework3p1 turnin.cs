namespace Homework3p1;
class Program
{
    static void Main(string[] args)
    {
        bool nprime = true;
        Console.WriteLine("Input an integer: "); //user inputs an integer
        string input = Console.ReadLine();
        int number = Convert.ToInt16(input);

        for(int i=2; i<number/2;i++) // for loop that is checking for a prime number
        {
            if(number%i==0)
            {
                nprime = false;
                break;
            }
        }
        if(nprime) // if nprime is true then it will output prime, else number is non-prime
        {
            Console.WriteLine("N is Prime ");
        }
        else
        {
            Console.WriteLine("N is non-prime ");
        }
    }
}
