namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Please input a letter grade: ");
        // Gets letter grade from the user
        char grade=Console.ReadLine()[0];
        // using the switch block method
        switch(grade) {
            case 'A': Console.WriteLine("GPA point: 4");
            break;
            case 'B': Console.WriteLine("GPA point: 3");
            break;
            case 'C': Console.WriteLine("GPA point: 2");
            break;
            case 'D': Console.WriteLine("GPA point: 1");
            break;
            case 'F': Console.WriteLine("GPA point: 0");
            break;
            // If any letter besides A,B,C,D,F are entered
            default: Console.WriteLine("Wrong Letter Grade!");
            break;
        }

        }
    }

