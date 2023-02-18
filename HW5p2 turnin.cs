namespace HW5p2;
 public class Largest1
{ 
    // The method used to reveal the largest number of the two integers given
    static int largest(int n1, int n2){
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    public class Largest2
{
    public static int largest(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    
    public static int largest(int n1, int n2, int n3, int n4)
    {
        return largest(largest(n1, n2), largest(n3, n4));
    }
    
    static void Main(string[] args)
    {
    Console.Write("a = ");
    int a = Convert.ToInt16(Console.ReadLine());
    Console.Write("b = ");
    int b = Convert.ToInt16(Console.ReadLine());
    Console.Write("c = ");
    int c = Convert.ToInt16(Console.ReadLine());
    Console.Write("d = ");
    int d = Convert.ToInt16(Console.ReadLine());
    // Calling the largest number with the largest method
    Console.WriteLine("The largest number is: " + largest(a, b, c, d));
}
}
}