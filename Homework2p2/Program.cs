namespace Homework2p2;
class Program
{
    static void Main(string[] args)
    {
    // Getting three inputs from the user
    Console.WriteLine("Please input the first number:");
    int a=Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Please input the second number:");
    int b=Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Please input the thrid number:");
    int c=Convert.ToInt16(Console.ReadLine());
    // writing the program to find the smallest number
    int smallest=0;
    //checking if a is the smallest
    if(a<b) {
        if(a<c) {
            smallest=a;
        }
    }
    // checking if b is the smallest
    if(b<a) {
        if(b<c) {
            smallest=b;
        }
    }
    // checking if c is the smallest
    if(c<a) {
        if(c<b) {
            smallest=c;
        }
    }
    // printing out which is the smallest number
    Console.WriteLine("The smallest value is: {0}", smallest);
    }
}
